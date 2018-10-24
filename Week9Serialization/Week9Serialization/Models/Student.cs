using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Week9Serialization.Serializers;

namespace Week9Serialization.Models
{
    [Serializable]
    public class Student:Person
    {
        public string StudentID { get; set; }
    }
}
