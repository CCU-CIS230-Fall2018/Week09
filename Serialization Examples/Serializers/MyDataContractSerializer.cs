using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Examples.Interfaces;
using System.Runtime.Serialization;
using System.IO;

namespace Serialization_Examples.Serializers
{
	public class MyDataContractSerializer : IMySerializer
	{
		public T Deserialize<T>(string filePath)
		{
			T csObj;
			var json = new DataContractSerializer(typeof(T));
			using (var s = new FileStream(filePath, FileMode.Open))
			{
				csObj = (T)json.ReadObject(s);
			}
			return csObj;
		}

		public void Serialize<T>(string saveToPath, T myCsObj)
		{
			var dcs = new DataContractSerializer(typeof(T));
			using (Stream s = new FileStream(saveToPath,FileMode.Create))
			{
				dcs.WriteObject(s, myCsObj);
			}
		}
	}
}
