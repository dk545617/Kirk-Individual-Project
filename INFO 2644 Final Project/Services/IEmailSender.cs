using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INFO_2644_Final_Project.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
