using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9Serialization
{
    public class DataContractSerializers
    {
        public static Teacher DataSerializer(Teacher teacher)
        {
            int flag = 0;
            // Because I do not want to cause errors if the file path is not in your computer I will not be running the lower code.
            if(flag == 0)
            {
                return teacher;
            }
            var savePath = @"C:\inclass_demos";
            FileStream writer = new FileStream(savePath, FileMode.Create);
            DataContractSerializer serializer = new DataContractSerializer(typeof(Person));
            serializer.WriteObject(writer, teacher);
            writer.Close();
            return teacher;
        }
    }
}
