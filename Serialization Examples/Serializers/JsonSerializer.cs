using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Examples.Serializers
{
	public class JsonSerializer
	{
		public T Deserialize<T>(string filePath)
		{
			T csObj;
			var json = new DataContractJsonSerializer(typeof(T));
			using (var s = new FileStream(filePath, FileMode.Open))
			{
				csObj = (T)json.ReadObject(s);
			}
			return csObj;
		}

		public void Serialize<T>(string saveToPath, T myCsObj)
		{
			var json = new DataContractJsonSerializer(typeof(T));
			using (var s = new FileStream(saveToPath,FileMode.Create))
			{
				json.WriteObject(s, myCsObj);
			}
		}
	}
}
