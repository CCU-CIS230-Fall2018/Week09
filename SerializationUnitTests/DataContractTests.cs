using System;
using System.Threading;
using KellermanSoftware.CompareNetObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serialization_Examples.Models;
using Serialization_Examples.Serializers;


namespace SerializationUnitTests
{
	[TestClass]
	public class DataContractTests
	{
		Student student = new Student("0488615")
		{
			FirstName = "Jon",
			LastName = "Bolkema",
			Birthday = DateTime.Now,
			StudentID = "0488615",
		};
		string FilePath = @"DataContractTests.d";
		MyDataContractSerializer json = new MyDataContractSerializer();

		[TestMethod]
		public void Serializable()
		{
			CompareLogic compareLogic = new CompareLogic();
			json.Serialize(FilePath,student);
			var obj = json.Deserialize<Student>(FilePath);
			Assert.IsInstanceOfType(obj, typeof(Student));
			ComparisonResult result = compareLogic.Compare(student, obj);
			
		}
	}
}
