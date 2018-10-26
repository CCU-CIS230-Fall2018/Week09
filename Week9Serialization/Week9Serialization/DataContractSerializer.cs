using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace Week9Serialization
{
    class MyDataContractSerializer : MyInterface
    {
        private List<Type> knownTypes;
        public MyDataContractSerializer(List<Type> types)
        {
            knownTypes = types;
        }
        public T Deserialize<T>(string createToPath)
        {
            T csObject;
            var dcs = new DataContractSerializer(typeof(T), knownTypes);
            try
            {
                using (Stream s = File.OpenRead(createToPath))
                {
                    return csObject = (T)dcs.ReadObject(s);
                }
            }
            catch
            {
                return default(T);
            }
        }

        public void Serialize<T>(string saveToPath, T myCsObj)
        {
            var dcs = new DataContractSerializer(typeof(T), knownTypes);
            using (Stream s = File.Create(saveToPath))
            {
                dcs.WriteObject(s, myCsObj);
            }
        }
    }
}
