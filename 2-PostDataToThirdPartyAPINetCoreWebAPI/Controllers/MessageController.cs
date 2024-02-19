using _2_PostDataToThirdPartyAPINetCoreWebAPI.Interfaces;
using _2_PostDataToThirdPartyAPINetCoreWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2_PostDataToThirdPartyAPINetCoreWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessage _message;

        public MessageController(IMessage message)
        {
            _message = message;
        }

        [HttpGet]
        public async Task<IEnumerable<MessageRequest>> GetMessage()
        {
            return await _message.GetMessage();
        }
    }
}
