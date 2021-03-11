using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parenthesis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parenthesis.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsBalancedTest()
        {
            string s = "(((1+1))))";
            bool b = false;

            bool expect;

            expect = Program.IsBalanced(s);

            Assert.AreEqual(b, expect, "нет сбалансированности");
        }
    }
}