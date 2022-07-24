using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Numbers
    {
        public bool checknumber(long a)
        {
            if (a < 0 || a > 0xFFFFFFFF)
            {
                string message = "Числа мають бути в діапазоні [0;4294967295]";
                string title = "Error";
                MessageBox.Show(message, title);
                return false;
            }

            return true;
        }

    }
}
