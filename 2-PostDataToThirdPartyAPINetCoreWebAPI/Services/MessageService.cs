using _2_PostDataToThirdPartyAPINetCoreWebAPI.Interfaces;
using _2_PostDataToThirdPartyAPINetCoreWebAPI.Model;
using System.Text.Json;

namespace _2_PostDataToThirdPartyAPINetCoreWebAPI.Services
{
    public class MessageService : IMessage
    {
        private readonly HttpClient httpClient;
        public MessageService()
        {
            httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://2e9bc1fd67fc4d1e88fc2f6af28d342b.api.mockbin.io/")
            };
        }

        public async Task<List<MessageRequest>> GetMessage()
        {
            try
            {
                var url = string.Format("https://2e9bc1fd67fc4d1e88fc2f6af28d342b.api.mockbin.io/");
                var result = new List<MessageRequest>();
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var MessageResponse = JsonSerializer.Deserialize<MessageRequest>(content, new JsonSerializerOptions()
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                    result.Add(MessageResponse);
                }
                else
                {
                    throw new Exception("Error");
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
