using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace vkFriendsModule
{
    public class User
    {
        [JsonProperty("first_name")]
        public string name;

        [JsonProperty("last_name")]
        public string surname;

        [JsonProperty("id")]
        public int id;

        public override bool Equals(object obj)
        {
            return (obj as User).id == id;
        }

        public override int GetHashCode()
        {
            return id;
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
