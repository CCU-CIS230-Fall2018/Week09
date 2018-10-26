using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializationExercise.FunctionalClasses;
using SerializationExercise.Serializers;
using NUnit.CompareNetObjects;

namespace Week9SerializationTests
{
    [TestClass]
    public class JSONSerializerTest
    {
        /*[TestMethod]
        public void JSNTest()
        {
            Professional testPrf = new Professional("Blake", "Griffin","Baller","Detroit Pistons");
            string savePath = @"C:";
            NewtonJSONSerializer njs = new NewtonJSONSerializer();
            njs.Serialize<Professional>(savePath + "NewtonJSON_Test", testPrf);
            Professional newTestPrf = njs.DeSerialize<Professional>(savePath + "NewtonJSON_Test");
            //IsDeeplyEqual.Equals(testPrf, newTestPrf);
            Assert.AreEqual(testPrf.FirstName,newTestPrf.FirstName);
        }*/
    }
}
