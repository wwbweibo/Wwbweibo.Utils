using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace Wwbweibo.Utils.Extensions
{
    public static class SerializeExtensions
    {
        public static byte[] Serialize(this ISerializable obj)
        {
            using (var ms = new MemoryStream())
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(ms, obj);
                var data = ms.ToArray();
                return data;
            }
        }

        public static T Deserialize<T>(this byte[] data) where T : class, ISerializable
        {
            using (var ms = new MemoryStream())
            {
                ms.Write(data, 0, data.Length);
                ms.Position = 0;

                BinaryFormatter formatter = new BinaryFormatter();
                var obj = formatter.Deserialize(ms) as T;
                return obj;
            }
        }

        public static string JsonSerialize(this object obj, bool camelCase=false)
        {
            if (camelCase)
            {
                var setting = new JsonSerializerSettings
                {
                    ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
                };
                return JsonConvert.SerializeObject(obj, setting);
            }
            return JsonConvert.SerializeObject(obj);
        }

        public static T JsonDeserialize<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}