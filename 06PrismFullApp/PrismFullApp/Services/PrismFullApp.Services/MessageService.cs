using PrismFullApp.Services.Interfaces;

namespace PrismFullApp.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "你好，这是来自消息服务的问候！";
        }
    }
}
