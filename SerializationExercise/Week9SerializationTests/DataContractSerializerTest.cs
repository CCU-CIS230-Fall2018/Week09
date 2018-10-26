using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializationExercise.FunctionalClasses;
using SerializationExercise.Serializers;
using NUnit.CompareNetObjects;

namespace Week9SerializationTests
{
    [TestClass]
    public class DataContractSerializerTest
    {
        [TestMethod]
        public void DCSTest()
        {
            SuperHero testHero = new SuperHero("Bruce","Wayne","Batman","He's Rich");
            string savePath = @"C:";
            DCSerializer dcs = new DCSerializer();
            dcs.Serialize<SuperHero>(savePath + "DataContractSerializer_Test", testHero);
            SuperHero newTestHero = dcs.DeSerialize<SuperHero>(savePath + "DataContractSerializer_Test");
            IsDeeplyEqual.Equals(testHero, newTestHero);
        }
    }
}
