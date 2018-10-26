using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week9Serialization;

namespace Week9SerializationTests
{
    [TestClass]
    public class JSONTest
    {
        [TestMethod]
        public void JSONSerializerTester()
        {
            Teacher teacher = new Teacher();

            teacher.FirstName = "Mark";
            teacher.LastName = "Twain";
            teacher.Title = "Dr.";
            teacher.Subject = "History";
            Teacher parse = JsonSerializer.JsonParser(teacher);

        }
    }
}
