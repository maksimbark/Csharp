using System;
using System.Collections.Generic;
using System.Linq;

namespace vkFriendsModule
{
    //TODO: Struct ??
    public struct Updater
    {
        public static (List<User> Added, List<User> Removed) GetUpdates()
        {
            //TODO: var prev = CheckFile ?? 
            List<User> prev = new List<User>();

            prev = CheckFile.CreateFromFile();
            var result = VKParcer.GetFriends(209243336, "name");
            CheckFile.WriteToFile(result);

            var inserted = result.Except(prev).ToList();
            var deleted = prev.Except(result).ToList();

            return (inserted, deleted);
            }
        }
}

