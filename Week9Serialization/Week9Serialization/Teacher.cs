using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Week9Serialization
{
    [DataContract]
    public class Teacher : Person
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Subject { get; set; }

        [DataMember]
        public List<Student> Students { get; set; }

    }
}
