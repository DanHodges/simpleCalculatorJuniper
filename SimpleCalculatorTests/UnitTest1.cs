using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using Xunit;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParseTests
    {
        [TestMethod]
        public void ParseFirstNumber()
        {
            string Expected = "123";
            Parse blah = new Parse("123+123");
            string [] Actual = blah.ParseInput();
            //throw new ArgumentException(Actual[2]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Actual[0], Expected);
        }
        [TestMethod]
        public void ParseMathSign()
        {
            string Expected = "+";
            Parse blah = new Parse("123+123");
            string[] Actual = blah.ParseInput();
            //throw new ArgumentException(Actual[2]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Actual[1], Expected);
        }
        [TestMethod]
        public void ParseLastNumber()
        {
            string Expected = "456";
            Parse blah = new Parse("123+456");
            string[] Actual = blah.ParseInput();
            //throw new ArgumentException(Actual[2]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Actual[2], Expected);
        }
        [TestMethod]
        public void ParseLastNegativeNumber()
        {
            string Expected = "-456";
            Parse blah = new Parse("123+ -456");
            string[] Actual = blah.ParseInput();
            //throw new ArgumentException(Actual[2]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected,Actual[2]);
        }
        [TestMethod]
        public void ParseFirstNegativeNumber()
        {
            string Expected = "-123";
            Parse blah = new Parse(" -123+456");
            string[] Actual = blah.ParseInput();
            //throw new ArgumentException(Actual[);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, Actual[0]);
        }
        [TestMethod]
        public void DoEasyMath()
        {
            string Expected = "3";
            Parse blah = new Parse("1+2");
            blah.ParseInput();
            string Actual = blah.DoMath();
            //throw new ArgumentException(Actual[);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void DoMoreMath()
        {
            string Expected = "10";
            Parse blah = new Parse("5*2");
            blah.ParseInput();
            string Actual = blah.DoMath();
            //throw new ArgumentException(Actual[);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void DoMathWithNegatives()
        {
            string Expected = "-10";
            Parse blah = new Parse("5*-2");
            blah.ParseInput();
            string Actual = blah.DoMath();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void DoMoreMathWithNegatives()
        {
            string Expected = "5";
            Parse blah = new Parse("-10/-2");
            blah.ParseInput();
            string Actual = blah.DoMath();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, Actual);
        }
        //[TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]
        //public void HandleBadInput()
        //{
        //    int Expected = 5;
        //    Parse blah = new Parse("-10/-2");
        //    blah.ParseInput();
        //    int Actual = blah.DoMath();
        //    Xunit.Assert.Throws<NullReferenceException>(blah.DoMath());
        //}
    }
}
