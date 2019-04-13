using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AccountManager.Data.Factory
{
    public class AccountManagerDesignTimeFactory
                : IDesignTimeDbContextFactory<AccountManagerDBContext>
    {
        public AccountManagerDBContext CreateDbContext(string[] args)
        {
            var optionsBulider = new DbContextOptionsBuilder<AccountManagerDBContext>();
            optionsBulider.UseSqlServer(@"Server=.;Database=AccountManagerDb; integrated Security=true");
            return new AccountManagerDBContext(optionsBulider.Options);
        }
    }
}
