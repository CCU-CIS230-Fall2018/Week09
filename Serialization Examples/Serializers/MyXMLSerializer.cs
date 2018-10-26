using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Examples.Interfaces;
using System.Xml.Serialization;
using System.IO;

namespace Serialization_Examples.Serializers
{
	public class MyXMLSerializer : IMySerializer
	{
		public T Deserialize<T>(string filePath)
		{
			T csObj;
			var xml = new XmlSerializer(typeof(T));
			using (var s = new StreamReader(filePath))
			{
				csObj = (T)xml.Deserialize(s);
			}
			return csObj;
		}

		public void Serialize<T>(string saveToPath, T myCsObj)
		{
			var xml = new XmlSerializer(typeof(T));
			using (var s = new StreamWriter(saveToPath))
			{
				xml.Serialize(s, myCsObj);
			}
		}
	}
}
