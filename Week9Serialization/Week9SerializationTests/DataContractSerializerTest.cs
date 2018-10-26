using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week9Serialization;

namespace Week9SerializationTests
{
    [TestClass]
    public class DataContractSerializerTest
    {
        [TestMethod]
        public void DataContractTester()
        {
            Teacher teacher = new Teacher();

            teacher.FirstName = "Mark";
            teacher.LastName = "Twain";
            teacher.Title = "Dr.";
            teacher.Subject = "History";
            Teacher parse = DataContractSerializers.DataSerializer(teacher);
        }
    }
}
