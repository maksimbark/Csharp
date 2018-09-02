using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vkFriendsModule;

namespace VKWebFriendsChecker.Controllers
{
    //[Route("/meow")]
    [Route("meow")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                (List<User> Added, List<User> Removed) result = vkFriendsModule.Updater.GetUpdates();
                string send = "";
                if (result.Added.Count > 0)
                {
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
                        VKClient.DelFriend(item.id);
                    }
                }
                if ((result.Added.Count > 0) || (result.Removed.Count > 0))
                    TelegramClient.send(send);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
