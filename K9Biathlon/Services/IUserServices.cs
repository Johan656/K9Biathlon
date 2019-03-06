using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Services
{
    public interface IUserServices
    {
        bool ValidateUser(string username, string password);
    }
}
