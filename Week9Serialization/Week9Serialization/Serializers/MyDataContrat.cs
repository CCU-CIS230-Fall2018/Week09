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


namespace Week9Serialization.Serializers
{
    public class MyDataContrat : IMySerializer
    {
        public T Deserialize<T>(string filePath)
        {
           T csObj;
            var dcs = new DataContractSerializer(typeof(T));
            using (StreamReader s = File.OpenText(filePath))
            {
                csObj = (T)dcs.ReadObject(s.BaseStream);
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

