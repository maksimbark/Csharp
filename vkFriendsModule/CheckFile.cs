using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace vkFriendsModule
{
    public static class CheckFile
    {

        private static string fileName = "lastFriendsStats.json";

        public static List<User> CreateFromFile()
        {
            if (System.IO.File.Exists(fileName))
                return (JsonConvert.DeserializeObject<List<User>>(System.IO.File.ReadAllText(fileName)));
            return new List<User>();
        }

        public static void WriteToFile(List<User> toWrite) {
            System.IO.File.WriteAllText(fileName, JsonConvert.SerializeObject(toWrite));
        }

    }
}
