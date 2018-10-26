using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using SerializationExercise.Serializers;


namespace SerializationExercise.FunctionalClasses
{
    [Serializable]
    public class Professional : Individual
    {
        public string Occupation { get; set; }
        public string Affiliation { get; set; }

        public Professional(string firstName, string lastName, string occupation, string affiliation)
            : base(firstName, lastName)
        {
            Occupation = occupation;
            Affiliation = affiliation;
        }
    }
}
