using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace SerializationExercise.FunctionalClasses
{
    [Serializable]
    [DataContract]
    public class Individual
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }

        public Individual(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
