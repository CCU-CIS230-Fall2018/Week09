using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace SerializationExercise.FunctionalClasses
{
    [DataContract]
    public class SuperHero : Individual
    {
        [DataMember]
        public string HeroName { get; set; }
        [DataMember]
        public string Power { get; set; }

        public SuperHero(string firstName, string lastName, string heroName, string power)
            : base (firstName, lastName)
        {
            HeroName = heroName;
            Power = power;
        }
    }
}
