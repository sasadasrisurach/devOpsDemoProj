using NUnit.Framework;
using System.IO;

namespace devOpsDemoProj
{
    [TestFixture]
    public class SunnyDay
    {
        [TestCase]
        public void TestMethod1()
        {
            string path = @"c:\temp\MyTest.txt";

            Assert.IsTrue(File.Exists(path));

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Assert.IsTrue(s.Equals("Hello World"));
                    Assert.Pass();
                }
            }
        }
    }
}