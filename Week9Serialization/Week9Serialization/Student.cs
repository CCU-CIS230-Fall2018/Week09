using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Week9Serialization
{
    [Serializable]
    [DataContract]
    public class Student : Person 
    {
        public string Grade { get; set; }

        public string ID { get; set; }
    }
}
