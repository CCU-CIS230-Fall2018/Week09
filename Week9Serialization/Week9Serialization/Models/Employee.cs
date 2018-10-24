using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Week9Serialization.Serializers;


namespace Week9Serialization.Models
{
    [DataContract]
    public class Employee:Person
    {
        [DataMember]
        public string EmpID { get; set; }
    }
}
