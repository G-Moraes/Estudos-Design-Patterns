using Newtonsoft.Json;

namespace SharedLibrary.JsonUtils
{
    public static class JsonUtils
    {
        public static T SafelyDeserializeJson<T> (string jsonAsString)
        {
            T deserializedObject;

            try
            {
                deserializedObject = JsonConvert.DeserializeObject<T>(jsonAsString);
            }
            catch
            {
                Console.WriteLine("Error while deserializing JSON!");

                return default(T);
            }

            return deserializedObject;
        }
    }
}
