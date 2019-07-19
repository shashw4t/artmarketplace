using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Marketplace.Services
{
    public class NullMailService : IMailService 
        //naming convention makes this interface start with I (created by extracting interface)
    {
        private readonly ILogger<NullMailService> logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            this.logger = logger;
        }

        public void SendMessage(string to, string subject, string body)
        {

        }


    }
}
