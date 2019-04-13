using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManager.Data.Models
{ 
    [Table("AccountSap")]
    public class Account:Core.ModelBase<int>
    {
        public string Code { get; set; }
        public string Name{ get; set; }

        public AccountType AccountType { get; set; }

        public int AccountTypeID { get; set; }
    }
}
