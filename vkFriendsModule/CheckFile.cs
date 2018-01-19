using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace vkFriendsModule
{
    public static class CheckFile
    {
        public static List<User> CreateFromFile()
        {
            return (JsonConvert.DeserializeObject<List<User>>(System.IO.File.ReadAllText(@"/users/maksimbarkalov/lastFriends.json")));
        }

        public static void WriteToFile(List<User> toWrite) {
            System.IO.File.WriteAllText(@"/users/maksimbarkalov/lastFriends.json", JsonConvert.SerializeObject(toWrite));
        }

    }
}
