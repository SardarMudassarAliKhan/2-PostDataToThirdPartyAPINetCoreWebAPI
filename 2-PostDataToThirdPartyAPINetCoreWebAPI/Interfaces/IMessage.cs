using _2_PostDataToThirdPartyAPINetCoreWebAPI.Model;

namespace _2_PostDataToThirdPartyAPINetCoreWebAPI.Interfaces
{
    public interface IMessage
    {
        Task<List<MessageRequest>> GetMessage();
    }
}
