using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Serialization
{
    interface MyInterface
    {
        void Serialize<T>(string saveToPath, T myObject);

        T Deserialize<T>(string createToPath);
    }
}
