using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public string Last { get; set; }
        public string LastQ { get; set; }
        public void AddLast(string input) { Last = input; }
        public void AddLastQ(string input) { LastQ = input; }
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        public Dictionary<string, int> GetDictionary() { return dictionary; }
        public void AddToDictionary(string name, string value)
        {
            dictionary.Add(name, int.Parse(value));
        }
    }
}
