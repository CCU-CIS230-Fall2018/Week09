using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using SerializationExercise.Interfaces;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationExercise.Serializers
{
    public class BinarySerializer : ISerializer
    {
        public T DeSerialize<T>(string filePath)
        {
            T csObj;
            var bin = new BinaryFormatter();
            Stream s = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            csObj = (T)bin.Deserialize(s);
            s.Close();
            return csObj;
        }

        public void Serialize<T>(string saveToPath, T myCsObj)
        {
            var bin = new BinaryFormatter();
            Stream s = new FileStream(saveToPath, FileMode.Create, FileAccess.Write, FileShare.None);
            bin.Serialize(s, myCsObj);
            s.Close();
        }
    }
}
