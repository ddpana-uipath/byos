using System.Collections.Generic;
using System.Threading.Tasks;

namespace Byos.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
