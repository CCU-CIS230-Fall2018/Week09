using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SerializationExercise.Interfaces;
using System.Runtime.Serialization;


namespace SerializationExercise.Serializers
{
    public class DCSerializer : ISerializer
    {

        
        public T DeSerialize<T>(string filePath)
        {
            T csObj;
            var dcs = new DataContractSerializer(typeof(T));
            using (Stream s = File.OpenRead(filePath))
            {
                csObj = (T)dcs.ReadObject(s);
            }
            return csObj;
        }

        public void Serialize<T>(string saveToPath, T myCsObj)
        {
            var dcs = new DataContractSerializer(typeof(T));
            using (Stream s = File.Create(saveToPath))
            {
                dcs.WriteObject(s, myCsObj);
            }
        }
    }
}