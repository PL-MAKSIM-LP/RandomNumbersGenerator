using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Request
    {
        public string? mode { get; set; }
        public uint max { get; set; }
        public uint min { get; set; }
        public uint argA { get; set; }
        public uint argC { get; set; }
        public uint countNumbers { get; set; }
        public bool newseed { get; set; }
        public uint bordervalue { get; set; }
    }
}
