using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public static string Eval(string input)
        {
            Parse StringToEvaluate = new Parse(input);
            StringToEvaluate.ParseInput();
            try
            {
                //Stack stack = new Stack();
                //stack.AddLast(StringToEvaluate.DoMath().ToString());
                //stack.AddLastQ(input);
                return StringToEvaluate.DoMath().ToString();
            }
            catch (Exception)
            {
                return "invalid input";
            }
        }
    }
}