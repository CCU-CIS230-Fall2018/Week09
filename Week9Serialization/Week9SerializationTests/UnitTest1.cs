using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week9Serialization.Models;
using Week9Serialization.Interfaces;
using Week9Serialization.Serializers;

namespace Week9SerializationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestData()
        {
            string savePath = @"C:";
            Employee emp = new Employee
            {
                FirstName = "Cora",
                LastName = "Wiersema",
                EmpID = "857039"
            };
            MyDataContrat dcs = new MyDataContrat();
            dcs.Serialize(savePath + "DataContractSerializer.txt", emp);
            Employee oldEmp = dcs.Deserialize<Employee>(savePath + "DataContractSerializer.txt");
            Assert.AreEqual(emp.FirstName, oldEmp.FirstName);
            Assert.AreEqual(emp.LastName, oldEmp.LastName);
            Assert.AreEqual(emp.EmpID, oldEmp.EmpID);
        }
        [TestMethod]
        public void TestBinary()
        {
            string savePath = @"C:";
            Person person = new Person
            {
                FirstName = "Blair",
                LastName = "Waldorf"
            };
            var bi = new MyBinary();
            bi.Serialize(savePath + "BinarySerializer.bin", person);
            Person oldPerson = bi.Deserialize<Person>(savePath + "BinarySerializer.bin");
            Assert.AreEqual(person.FirstName, oldPerson.FirstName);
            //Assert.AreEqual(person.LastName, oldPerson.LastName);
            
        }
        [TestMethod]
        public void TestJSON()
        {
            string savePath = @"C:";
            Student stu = new Student
            {
                FirstName = "Chuck",
                LastName = "Bass",
                StudentID = "161026"
            };
            MyJSON js = new MyJSON();
            js.Serialize(savePath + "JSONex.json", stu);
            Student oldStu = js.Deserialize<Student>(savePath + "JSONex.json");
            Assert.AreEqual(stu.FirstName, oldStu.FirstName);
            Assert.AreEqual(stu.LastName, oldStu.LastName);
            //Assert.AreEqual(stu.StudentID, oldStu.StudentID);
        }
    }
}
