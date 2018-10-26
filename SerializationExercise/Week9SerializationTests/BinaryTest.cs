using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializationExercise.FunctionalClasses;
using SerializationExercise.Serializers;
using NUnit.CompareNetObjects;

namespace Week9SerializationTests
{
    [TestClass]
    public class BinaryTest
    {
        [TestMethod]
        public void BinTest()
        {
            Individual testIvd = new Individual("John", "Wick");
            string savePath = @"C:";
            //string saveName = "BinaryTest";
            BinarySerializer bin = new BinarySerializer();
            bin.Serialize<Individual>(savePath + "BinarySerializer_Test", testIvd);
            Individual newTestIdv = bin.DeSerialize<Individual>(savePath + "BinarySerializer_Test");
            IsDeeplyEqual.Equals(testIvd, newTestIdv);
        }
    }
}
