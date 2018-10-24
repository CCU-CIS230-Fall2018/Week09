using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using Week9Serialization.Interfaces;
using System.Runtime.Serialization.Formatters.Binary;

namespace Week9Serialization.Serializers
{
    public class MyBinary:IMySerializer
    {
        public T Deserialize<T>(string filePath)
        {
            T csObj;
            var bi = new BinaryFormatter();
            Stream s = new FileStream(filePath,FileMode.Open,FileAccess.Read,FileShare.Read);
            csObj = (T)bi.Deserialize(s);
            s.Close();
            return csObj;
            
        }
        public void Serialize<T>(string saveToPath, T myCsObj)
        {
            var bi = new BinaryFormatter();
            Stream s = new FileStream(saveToPath, FileMode.Create, FileAccess.Write, FileShare.None);
            bi.Serialize(s, myCsObj);
            s.Close();
        }
    }
}
