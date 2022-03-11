using System.Threading.Tasks;

namespace MAQFurni.Models
{
    public interface ISendMailService
    {
        Task SendMail(MailContent mailContent);
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}