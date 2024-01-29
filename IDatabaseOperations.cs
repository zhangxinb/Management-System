using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    public interface IDatabaseOperations
    {
        void InsertUser(string username, string password, string phoneNum);
        string GetUserPassword(string username);
    }

}
