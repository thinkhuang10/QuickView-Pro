using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public class JsonHelper
    {
        public async static Task WriteFile(object content,string path)
        {
            var str = JsonConvert.SerializeObject(content, Formatting.Indented, 
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            using (var file = new StreamWriter(path, false))
            {
                await file.WriteAsync(str);
            } 
        }

        public static JObject GetJObject(string path)
        {
            string jsonString = File.ReadAllText(path);//读取文件
            JObject jobject = JObject.Parse(jsonString);//解析成json

            return jobject;
        }

        public static JObject GetJObjectFromString(string jsonString)
        {
            JObject jobject = JObject.Parse(jsonString);//解析成json

            return jobject;
        }

        public static T ReadFile<T>(string path)
        {
            var sb = new StringBuilder();
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var file = new StreamReader(fs))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            sb.AppendLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return JsonConvert.DeserializeObject<T>(sb.ToString());
        }

    }
}
