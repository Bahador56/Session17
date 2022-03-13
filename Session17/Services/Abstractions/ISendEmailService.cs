using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session17.Services.Abstractions
{
    public interface ISendEmailService
    {
        bool SendEmail(string from,string to,string body, string[] attachmenturls);


    }
}
