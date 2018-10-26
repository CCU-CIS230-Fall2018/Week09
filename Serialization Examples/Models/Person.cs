using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Examples.Models
{
	[DataContract]
	class Person
	{
		[DataMember]
		public byte Male { get; set; }
		[DataMember]
		public int Height { get; set; }
		[DataMember]
		public string HairColor { get; set; }
		[DataMember]
		public string Ethnicity { get; set; }
	}
}
