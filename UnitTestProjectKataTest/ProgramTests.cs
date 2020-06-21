using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppLinqDictionary;
using System;
using System.Collections.Generic;
using System.Text;

using ConsoleAppLinqDictionary;

using System.Linq;

namespace ConsoleAppLinqDictionary.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MyLanguagesTest()
        {
            {
                CollectionAssert.AreEqual(Program.MyLanguages(new Dictionary<string, int> { { "Java", 10 }, { "Ruby", 80 }, { "Python", 65 } }).ToArray(), new string[] { "Ruby", "Python" });
                CollectionAssert.AreEqual(Program.MyLanguages(new Dictionary<string, int> { { "Java", 100 }, { "Ruby", 80 }, { "Python", 65 } }).ToArray(), new string[] { "Java", "Ruby", "Python" });
                CollectionAssert.AreEqual(Program.MyLanguages(new Dictionary<string, int> { { "Hindi", 60 }, { "Greek", 71 }, { "Dutch", 93 } }).ToArray(), new string[] { "Dutch", "Greek", "Hindi" });
                CollectionAssert.AreEqual(Program.MyLanguages(new Dictionary<string, int> { { "C++", 50 }, { "ASM", 10 }, { "Haskell", 20 } }).ToArray(), new string[] { });
            }
        }
    }
}