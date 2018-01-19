using System;
using Newtonsoft.Json;

namespace vkFriendsModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = VKParcer.GetFriends(209243336, "name");
            int i = 0;
            foreach (var item in result)
            {
                ++i;
                Console.WriteLine($"{i}) {item.name} {item.surname} (id: {item.id})");
            }
        }
    }

}