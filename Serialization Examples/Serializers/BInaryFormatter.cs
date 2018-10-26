using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Examples.Interfaces;
namespace Serialization_Examples.Serializers
{
	public class BinaryFormatter : IMySerializer
	{
		public T Deserialize<T>(string filePath)
		{
			T csObj;
			BinaryFormatter binary = new BinaryFormatter();
			using (Stream s = new FileStream(filePath, FileMode.Open))
			{
				csObj = (T)binary.Deserialize<T>(filePath);
			}
			return csObj;
		}

		public void Serialize<T>(string saveToPath, T myCsObj)
		{
			BinaryFormatter binary = new BinaryFormatter();
			using (Stream s = new FileStream(saveToPath, FileMode.Create,FileAccess.Write,FileShare.None))
			{
				binary.Serialize(saveToPath, myCsObj);
			}
		}
	}
}
