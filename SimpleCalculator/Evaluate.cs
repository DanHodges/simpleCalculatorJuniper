using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public static string Eval(string input, Stack stack)
        {
            Parse StringToEvaluate = new Parse(input);
            StringToEvaluate.ParseInput();
            try
            {
                return StringToEvaluate.DoMathOrAddConstant(stack);
            }
            catch (Exception)
            {
                return "invalid input";
            }
        }
    }
}