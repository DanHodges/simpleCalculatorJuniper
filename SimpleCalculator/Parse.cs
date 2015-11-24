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
        private string Input = "";
        public List<int> Numbers = new List<int>();
        string[] InputArray = new string[3];

        //Constuctor takes an input argument, strips it of white space,
        //and sets the inputs value as the global Input variable
        public Parse (string input)
        {
            foreach (char letter in input)
            {
                if (!char.IsWhiteSpace(letter))
                {
                    Input += letter;
                }
            }
        }

        //Parse input modifies the global "Input" string and assigns it to "InputArray
        //Index 0 is number one, index 1 is the operation to be performed, 
        //Index 2 is the last number
        public string[] ParseInput ()
        {
            char[] Signs = new char[5] { '+', '-', '*', '/','=' };
            string CurrentString = "";
            for (int i = 0; i < Input.Length; i++)
            {
                CurrentString += Input[i];

                //If current index is in signs array, ensure the next number isn't (e.g. invalid input).
                if (Signs.Contains(Input[i]))
                {
                    if (Signs.Contains(Input[i + 1])) { throw new ArgumentException("We don't play that way"); }
                    continue;
                }

                //If in range and the next number is an operation, 
                //we know we have our first number
                if (i < Input.Length -1 && Signs.Contains(Input[i+1]))
                {
                    InputArray[0] = CurrentString;
                    //Assign operation to InputArray[1]
                    InputArray[1] = Input[i + 1].ToString();
                    CurrentString = "";
                    //Increment i so that we begin our next cycle after the operation
                    i += 1;
                }
                if (i == Input.Length - 1)
                {
                    InputArray[2] = CurrentString;
                }
            }
            return InputArray;
        }

        public string DoMathOrAddConstant(Stack stack)
        {
            if (InputArray[1] == "=")
            {
                return AddConstant(stack);
            }
            else
            {
               return DoMath();
            }
        }

        public string AddConstant(Stack stack)
        {
            stack.AddToDictionary(InputArray[0], InputArray[2]);
            return InputArray[0] + " " + InputArray[1] + " " + InputArray[2];
        }

        public string DoMath()
        {
            switch (InputArray[1])
            {
                case "+" :
                    return (int.Parse(InputArray[0]) + int.Parse(InputArray[2])).ToString();
                case "-":
                    return (int.Parse(InputArray[0]) - int.Parse(InputArray[2])).ToString();
                case "*":
                    return (int.Parse(InputArray[0]) * int.Parse(InputArray[2])).ToString();
                case "/":
                    return (int.Parse(InputArray[0]) / int.Parse(InputArray[2])).ToString();
                case "%":
                    return (int.Parse(InputArray[0]) % int.Parse(InputArray[2])).ToString();
                default:
                        throw new ArgumentException("no good");
            }
        }
    }
}
