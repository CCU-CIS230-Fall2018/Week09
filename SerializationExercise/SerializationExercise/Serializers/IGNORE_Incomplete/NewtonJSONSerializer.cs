using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using SerializationExercise.Interfaces;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;


namespace SerializationExercise.Serializers
{
    /*public class NewtonJSONSerializer : ISerializer
    {
        public T DeSerialize<T>(string filePath)
        {
            T csObj;
            var jsn = new Newtonsoft.Json.JsonSerializer();
            StreamReader s = new StreamReader(filePath);
            csObj = (T)jsn.Deserialize(s);
            s.Close();
            return csObj;
        }

        public void Serialize<T>(string saveToPath, T myCsObj)
        {
            var jsn = new Newtonsoft.Json.JsonSerializer();
            using (JsonReader s = new JsonReader(saveToPath))
            {
                jsn.Serialize(s, myCsObj);
            }
        }
    }*/
}
