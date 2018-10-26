using System;
using System.Threading;
using KellermanSoftware.CompareNetObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serialization_Examples.Models;
using Serialization_Examples.Serializers;

namespace SerializationUnitTests
{
	[TestClass]
	public class BinaryTests
	{
		Student student = new Student("0488615")
		{
			FirstName = "Jon",
			LastName = "Bolkema",
			Birthday = DateTime.Now,
			StudentID = "0488615",
		};
		
		[TestMethod]
		public void Serializable()
		{
			string FilePath = @"BinaryTester.xml";

			BinaryFormatter json = new BinaryFormatter();
			//CompareLogic compareLogic = new CompareLogic();
			json.Serialize(FilePath, student);
			Thread.Sleep(5000);
			var obj = json.Deserialize<Student>(FilePath);
			//Assert.IsInstanceOfType(obj, typeof(Student));
			//ComparisonResult result = compareLogic.Compare(student, obj);

		}
	}
}
