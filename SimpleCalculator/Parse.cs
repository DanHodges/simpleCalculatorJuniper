using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Parse
    {
        private string Input;
        public List<int> Numbers = new List<int>();
        string[] InputArray = new string[3];

        public Parse (string input)
        {
            Input = input;
        }
        public string[] ParseInput ()
        {
            string NumOne = "@";
            char Operation = '@';
            string NumTwo = "@";
            int OpIndex = 0;
            char[] Signs = new char[4] { '+', '-', '*', '/' };
            string CurrentString = "";
            for (int i = 0; i < Input.Length; i++)
            {
                if (Signs.Contains(Input[i]))
                {
                    CurrentString += Input[i];
                    if(Signs.Contains(Input[i + 1]))
                    {
                        throw new ArgumentException("We don't play that way");
                    }
                    continue;
                }
                if (!char.IsWhiteSpace(Input[i]))
                {
                  CurrentString += Input[i];
                }
                if (char.IsWhiteSpace(Input[i]))
                {
                    continue;
                }
                if (i < Input.Length -1 && Signs.Contains(Input[i+1]))
                {
                    NumOne = CurrentString;
                    CurrentString = "";
                    Operation = Input[i + 1];
                    i += 1;
                    OpIndex = i;
                }
                if (i == Input.Length - 1)
                {
                    NumTwo = CurrentString;
                }
            }
            InputArray[0] = NumOne;
            InputArray[1] = Operation.ToString();
            InputArray[2] = NumTwo;
            return InputArray;
        }
        public int DoMath()
        {
            switch (InputArray[1])
            {
                case "+" :
                    return int.Parse(InputArray[0]) + int.Parse(InputArray[2]);
                case "-":
                    return int.Parse(InputArray[0]) - int.Parse(InputArray[2]);
                case "*":
                    return int.Parse(InputArray[0]) * int.Parse(InputArray[2]);
                case "/":
                    return int.Parse(InputArray[0]) / int.Parse(InputArray[2]);
                case "%":
                    return int.Parse(InputArray[0]) % int.Parse(InputArray[2]);
                default:
                        throw new ArgumentException("no good");
            }
        }
    }
}
