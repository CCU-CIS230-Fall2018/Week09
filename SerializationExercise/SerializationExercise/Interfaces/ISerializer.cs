using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExercise.Interfaces
{
    public interface ISerializer
    {
        void Serialize<T>(string saveToPath, T myCsObj);

        T DeSerialize<T>(string filePath);

    }
}
