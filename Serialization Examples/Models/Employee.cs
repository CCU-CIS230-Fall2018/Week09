using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;







namespace Serialization_Examples.Models
{
	[DataContract]
	class Employee
	{
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public string EmplID { get; set; }
		[DataMember]
		private string Age;
		public string SSN { get; set; }

	}
}
