using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace vkFriendsModule
{
    //TODO: Rename
    public class User
    {
        [JsonProperty("first_name")]
        public string name;

        [JsonProperty("last_name")]
        public string surname;

        [JsonProperty("id")]
        public int id;

        //TODO: Check type
        public override bool Equals(object obj)
        {
            return (obj as User).id == id;
        }

        //TODO: Hash with name^surname
        public override int GetHashCode()
        {
            return id;
        }
        public override string ToString()
        {
            return $"{name} {surname} (https://vk.com/id{id})";
        }
    }
    /*
    public class UserComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            return x.id == y.id;
        }

        public int GetHashCode(User obj)
        {
            return obj.id;
        }
    }
    */
}
