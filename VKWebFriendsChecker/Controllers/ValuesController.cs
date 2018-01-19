using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vkFriendsModule;

namespace VKWebFriendsChecker.Controllers
{
    //[Route("api/[controller]")]
    [Route("meow")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public (List<User> Added, List<User> Removed) Get()
        {
            (List<User> Added, List<User> Removed) result = vkFriendsModule.Updater.GetUpdates();
            string send = "";
            if (result.Added.Count > 0) {
                send += "Новые друзья (это всегда хорошо ^_^):\n";
                int i = 0;
                foreach (var item in result.Added)
                {
                    ++i;
                    send = $"{send} {i}) {item.name} {item.surname} \n vk.com/id{item.id}\n";
                }
                send += "\n";
            }

            if (result.Removed.Count > 0)
            {
                send += "Нигодяи, которые покинули аккаунт. Подписки на них уже уничтожены:\n";
                int i = 0;
                foreach (var item in result.Removed)
                {
                    ++i;
                    send = $"{send} {i}) {item.name} {item.surname} \n vk.com/id{item.id}\n";
                    VKParcer.DelFriend(item.id);
                }
            }
            if ((result.Added.Count > 0) || (result.Removed.Count > 0))
                TelegramLogic.send(send);

            return result;
        }

        /*
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
