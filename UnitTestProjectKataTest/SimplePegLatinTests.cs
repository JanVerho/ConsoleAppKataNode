using ConsoleAppKataNode;
using ConsoleAppObjContains;
using ConsoleAppSimplePigLatin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestProjectKataTest
{
    [TestClass] //SimplePegLatinTests
    public class SimplePegLatinTests
    {
        public static string Solution(string str)
        {
            return String.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
        }

        [TestMethod]
        public void KataTestsWord()
        {
            Assert.AreEqual("igPay", ConsoleAppSimplePigLatin.MyClass.PigIt("Pig"));
            Assert.AreEqual("hisTay", ConsoleAppSimplePigLatin.MyClass.PigIt("This"));
        }

        [TestMethod]
        public void KataTestsPhrase()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", ConsoleAppSimplePigLatin.MyClass.PigIt("Pig latin is cool"), "Er is een fout in de string!");
            Assert.AreEqual("hisTay siay ymay tringsay", ConsoleAppSimplePigLatin.MyClass.PigIt("This is my string"));
        }

        [TestMethod]
        public void RandomTests()
        {
            var random = new Random();
            string randomStr;
            for (int i = 0; i < 10; i++)
            {
                randomStr =
                    String.Join("", Enumerable.Range(0, 20).Select((o, x) => (char)random.Next('a', 'z') + ((x + 1) % 3 == 0 ? " " : "")));

                Assert.AreEqual(Solution(randomStr), ConsoleAppSimplePigLatin.MyClass.PigIt(randomStr));
            }
        }
    }
}