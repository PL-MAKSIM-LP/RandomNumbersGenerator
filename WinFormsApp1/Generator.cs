using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Generator
    {

        public uint seed = 0xFE408F7A, tmpseed, border;

        private uint mashtab(uint res, uint min, uint max)
        {
            return (uint)(res % (max - min) + min);
        }

        private uint linear(uint seed, uint a, uint c)
        {
            ulong res = seed * a + c;

            return (uint)(res / 65536) % 32768;

        }

        public uint pseudorandom(uint a, uint c, uint max, uint min)
        {
            tmpseed = linear(tmpseed, a, c);

            return mashtab(tmpseed, min, max);
        }

    }
}
