using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Examples.Models;
using Serialization_Examples.Interfaces;
using Serialization_Examples.Serializers;

namespace Serialization_Examples
{
	class Program
	{
		static void Main(string[] args)
		{
			// var SavePath = @"C:\Users\Jon\OneDrive\School\Fall 2018\Programming Foundations II\DemoSaveFolder\";
			// var student = new Student("0488615")
			// {
			//	 FirstName = "Jon",
			//	LastName = "Bolkema",
			//	Birthday = DateTime.Now,
			//	// StudentID = "0488615",
			//	SSN = "123-45-6789"
			// };
			// var myXml = new MyXMLSerializer();
			// myXml.Serialize(SavePath + "XMLserializedStudent.xml", student);

			// var oldStudentRecord = myXml.Deserialize<Student>(SavePath + "XMLserializedStudent.xml");
			// Console.WriteLine($"Hi! My name is {oldStudentRecord.FirstName} {oldStudentRecord.LastName}. If you want to " +
			//	$"steal my identity, my SSN is {oldStudentRecord.SSN}");
			// var emp = new Employee
			// {
			//	Name = "Jeremy Porier",
			//	EmplID = "13211244",
			//	SSN = "123-45-6789"
			// };
			// string FilePath = @"C:\Users\Jon\OneDrive\School\Fall 2018\Programming Foundations II\Week09\SerializationUnitTests\BinaryTests.bin";
			// BinaryFormatter json = new BinaryFormatter();



			// CompareLogic compareLogic = new CompareLogic();
			// json.Serialize(FilePath, emp);

			// var obj = json.Deserialize<Student>(FilePath);
			// Console.WriteLine(obj);
			// Assert.IsInstanceOfType(obj, typeof(Student));
			// ComparisonResult result = compareLogic.Compare(student, obj);

		}
	}
}
