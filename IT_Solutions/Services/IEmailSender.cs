using IT_Solutions.Models;

namespace IT_Solutions.Services
{
    public interface IEmailSender
    {
        void SendMessage(MessageModel message);
    }
}