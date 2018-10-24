using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Week9Serialization.Interfaces;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Week9Serialization.Serializers
{
    public class MyJSON:IMySerializer
    {
        public T Deserialize<T>(string filePath)
        {
            T csObj;
            var serializer = new JsonSerializer
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Newtonsoft.Json.Formatting.Indented
            };
            using (StreamReader s = File.OpenText(filePath))
            {
                csObj = (T) serializer.Deserialize(s, typeof(T));

            }
            return csObj;
        }
        public void Serialize<T>(string saveToPath, T myCsObj)
        {
            var serializer = new JsonSerializer
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Newtonsoft.Json.Formatting.Indented
            };
            using (StreamWriter s = File.CreateText(saveToPath))
            {
                serializer.Serialize(s, myCsObj);

            }
        }
    }
}
