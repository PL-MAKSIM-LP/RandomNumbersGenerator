
using NAudio.Wave;

namespace noisegenerator
{
    internal class Noise
    {
        private uint readednumber, tmp;
        public void readedNumberMicrophone(uint a)
        {
            tmp = a;
            WaveInEvent waveIn = new WaveInEvent();
            waveIn.DeviceNumber = 0;
            int sampleRate = 44000; // 44 kHz
            int channels = 1; // mono
            waveIn.DataAvailable += waveIn_DataAvailable;
            waveIn.WaveFormat = new WaveFormat(sampleRate, channels);
            waveIn.StartRecording();
            Thread.Sleep(200);
            waveIn.StopRecording();

        }

        public uint getreadednumber()
        { 
            return readednumber;
        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {

            int index = e.BytesRecorded;
            readednumber = 0;
            int counter = 0;
            while (counter < 33 || index > 1)
            {

                index--;
                if (index < 0) break;
                if (e.Buffer[index] > 10 && e.Buffer[index] < 255)
                {
                    counter++;
                    readednumber = readednumber << 1;
                    if (e.Buffer[index] >= tmp)
                        readednumber += 1;
                    else 
                        readednumber += 0;
                }
            }
        }

        public uint generaterandom(uint min, uint max, uint tmp)
        {
            uint res;
            Noise noise = new Noise();
            noise.readedNumberMicrophone(tmp);
            res = noise.getreadednumber();
            noise = null;
            res = res % (max - min) + min;
            return res;
        }
    }
}
