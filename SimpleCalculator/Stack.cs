using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Stack
    {
        public string Last { get; set; }
        public string LastQ { get; set; }
        public void AddLast(string input) { Last = input; }
        public void AddLastQ(string input) { LastQ = input; }
    }
}
