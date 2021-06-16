using IT_Solutions.Models;
using System.Threading.Tasks;

namespace IT_Solutions.Services
{
    public interface IEmailSender
    {
        Task<bool> SendMessageAsync(MessageModel message);
    }
}