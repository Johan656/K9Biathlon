using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Services
{
    public class NullMailServices : IMailService
    {
        private readonly ILogger<NullMailServices> _logger;

        public NullMailServices(ILogger<NullMailServices> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string to, string subject, string body)
        {
            // Log the message
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
        }
    }
}
