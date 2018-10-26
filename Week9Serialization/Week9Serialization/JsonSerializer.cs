using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Serialization
{
    public class JsonSerializer
    {
        public static Teacher JsonParser(Teacher teacher)
        {               
            string output = JsonConvert.SerializeObject(teacher);
           
            Console.WriteLine("Json Serialized:");
            Console.WriteLine(output);
            Teacher deserializedProduct = JsonConvert.DeserializeObject<Teacher>(output);
            Console.WriteLine("Json Deserialized:");
            Console.WriteLine(deserializedProduct);
            return deserializedProduct;
        }
    }
}
