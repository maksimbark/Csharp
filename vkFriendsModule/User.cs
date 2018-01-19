using System;
using Newtonsoft.Json;
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
    }
}
