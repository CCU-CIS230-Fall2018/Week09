using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Week9Serialization
{
    class BinaryFormattercs : MyInterface
    {
        private List<Type> knownTypes;
        public BinaryFormattercs(List<Type> types)
        {
            knownTypes = types;
        }
        public void Serialize<T>(string saveToPath, T myCsObj)
        {
            FileStream fs = new FileStream(saveToPath, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, knownTypes);
            fs.Close();
        }

        public T Deserialize<T>(string createToPath)
        {
            FileStream fs = new FileStream(createToPath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            knownTypes = (List<Type>) formatter.Deserialize(fs);
            return default(T);
        }
    }
}
