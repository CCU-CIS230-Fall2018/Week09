using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9Serialization
{
    class BinaryFormatter
    {
        
        private List<Type> knownTypes;
        public void MyDataContractSerializer (List<Type> types)
        {
            knownTypes = types;                
        }
        public T Deserialize<T>(string filePath)
        {
            T contractObject;
            var dataSerializer = new DataContractSerializer(typeof(T), knownTypes);
            using (Stream stream = File.OpenRead(filePath))
            {
                contractObject = (T)dataSerializer.ReadObject(stream);
            }
            return contractObject;
        }
        public void BinaryParser(Teacher teacher)
        {
            Teacher knownTypes = teacher;
        }

        public void Serialize<T>(string saveToPath, T myContractSerializerObject)
        {
            var dataContract = new DataContractSerializer(typeof(T), knownTypes);
            using (Stream stream = File.Create(saveToPath))
            {
                dataContract.WriteObject(stream, myContractSerializerObject);
            }

        }
    }
}
