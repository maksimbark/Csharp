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
            if (obj is User)
            {
                return (obj as User).id == id;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return id;
        }
        public override string ToString()
        {
            return $"{name} {surname} (https://vk.com/id{id})";
        }
    }
}
