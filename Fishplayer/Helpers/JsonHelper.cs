﻿using Newtonsoft.Json;
namespace Fishplayer.Helpers
{
    public class JsonHelper
    {
        public static string Serialize<T>(T item) where T : class
        {
            return JsonConvert.SerializeObject(item);
        }

        public static T DeSerialize<T>(string value) where T : class
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
