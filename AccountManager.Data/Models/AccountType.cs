using System.Collections.Generic;

namespace AccountManager.Data.Models
{
    public class AccountType : Core.ModelBase<int>
    {
        public string  Code { get; set; }

        public string Name { get; set; }

        public ICollection<Account> Account { get; set; }
    }
}
