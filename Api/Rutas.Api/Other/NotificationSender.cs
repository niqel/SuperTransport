using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TmsTcAPI.Other
{
    public class NotificationSender
    {
        public static async Task<bool> Send(string[] tokens, string title, string body, int operation = 0)
        {
            bool sent = false;

            var notification = new
            {
                app_id = OneSignal.AppId,
                include_player_ids = tokens,
                data = new
                {
                    title,
                    body,
                    operation
                },
                contents = new
                {
                    en = body
                },
                content_available = true,
                mutable_content = true
            };

            string json = JsonConvert.SerializeObject(notification);

            var request = new HttpRequestMessage(HttpMethod.Post, OneSignal.Url);
            request.Headers.TryAddWithoutValidation("Authotization", "key=" + OneSignal.APIKey);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage result;
            using (var client = new HttpClient())
            {
                result = await client.SendAsync(request);
                sent = result.IsSuccessStatusCode;
            }
            return sent;
        }
    }
}