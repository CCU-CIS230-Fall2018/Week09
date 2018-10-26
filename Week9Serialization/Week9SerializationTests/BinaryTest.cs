using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week9Serialization;

namespace Week9SerializationTests
{
    [TestClass]
    public class BinaryTest
    {
        [TestMethod]
        public void BinarySerializerTester()
        {
            Teacher teacher = new Teacher();

            teacher.FirstName = "Mark";
            teacher.LastName = "Twain";
            teacher.Title = "Dr.";
            teacher.Subject = "History";


        }
    }
}
