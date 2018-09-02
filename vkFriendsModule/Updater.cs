using System;
using System.Collections.Generic;
using System.Linq;

namespace vkFriendsModule
{
    public static class Updater
    {
        public static (List<User> Added, List<User> Removed) GetUpdates()
        {
            List<User> prev = CheckFile.CreateFromFile();

            var result = VKClient.GetFriends(209243336, "name");
            CheckFile.WriteToFile(result);

            var inserted = result.Except(prev).ToList();
            var deleted = prev.Except(result).ToList();

            return (inserted, deleted);
            }
        }
}

