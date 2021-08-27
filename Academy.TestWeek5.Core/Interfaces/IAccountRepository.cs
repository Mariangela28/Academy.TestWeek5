using Academy.TestWeek5.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.TestWeek5.Core.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetByUsername(string username);
    }
}
