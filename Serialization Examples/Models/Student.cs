using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization_Examples.Models
{
	[DataContract]
	public class Student
	{
		public Student(string ID)
		{
			StudentID = ID;
		}
		[DataMember]
		public string StudentID { get; set; }
		[DataMember]
		public string FirstName { get; set; }
		[DataMember]
		public string LastName { get; set; }
		[DataMember]
		public DateTime Birthday { get; set; }
		[XmlIgnore]
		[DataMember]
		public string SSN { get; set; }

	}
}
