using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Serialization
{
    interface ISerializer
    {
        void Serialize<T>(string saveToPath, T myCsObj);


        T Deserialize<T>(string filePath);

    }
}
