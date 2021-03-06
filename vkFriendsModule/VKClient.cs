﻿using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace vkFriendsModule
{
    public static class VKClient
    {
        public static string Ver = "5.8";
        private static string constructor = "https://api.vk.com/method/";
        private static string access = "place_token_here";

        public static List<User> GetFriends(int id, string fields)
        {
            string address = $"{constructor}friends.get?user_id={id}&fields={fields}&access_token={access}&v={Ver}";
            HttpClient query = new HttpClient();
            var result = query.GetAsync(address).Result.Content.ReadAsStringAsync().Result;

            var usersObject = JObject.Parse(result);

            var users = usersObject["response"]["items"];
            List<User> friendsList = users.ToObject<List<User>>();

            return friendsList.OrderBy(i => (i.surname, i.name)).ToList();
        }

        public static void DelFriend(int id) {
            string address = $"{constructor}friends.delete?user_id={id}&access_token={access}&v={Ver}";
            HttpClient query = new HttpClient();
            query.GetAsync(address);
        }
    
       
    }
}
