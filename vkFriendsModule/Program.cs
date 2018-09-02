using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace vkFriendsModule
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<User> prev = new List<User>();

            prev = CheckFile.CreateFromFile();

            var result = VKClient.GetFriends(209243336, "name");
            int i = 0;
            foreach (var item in result)
            {
                ++i;
                Console.WriteLine($"{i}) {item.name} {item.surname} (id: {item.id})");
            }
            Console.WriteLine($"Total count: {result.Count}");
            CheckFile.WriteToFile(result);

            var inserted = result.Except(prev);
            var deleted = prev.Except(result);

            if (deleted.Count() > 0)
            {
                Console.WriteLine("Deleted:");
                i = 0;
                foreach (var item in deleted)
                {
                    ++i;
                    Console.WriteLine($"{i}) {item.name} {item.surname} (https://vk.com/id{item.id})");
                }
            }

            if (inserted.Count() > 0)
            {
                Console.WriteLine("Added:");
                i = 0;
                foreach (var item in inserted)
                {
                    ++i;
                    Console.WriteLine($"{i}) {item.name} {item.surname} (https://vk.com/id{item.id}) ");
                }
            }

        }
    }

}
