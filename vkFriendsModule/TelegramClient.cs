using System.Net.Http;

namespace vkFriendsModule
{
   public class TelegramClient
    {
        public static void send(string add)
        {
            //todo: add smth
            string address = "https://api.telegram.org/bot[botid]:[bot_token]/sendMessage?chat_id=-[chat_id]&text=";
            address += "Произошло изменение в списке друзей ВКонтакте.\n";
            address += add;

            HttpClient query = new HttpClient();
            query.GetAsync(address);

        }
    }
}