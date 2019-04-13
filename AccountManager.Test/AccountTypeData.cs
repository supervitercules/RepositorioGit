using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountManager.Data.Factory;
using AccountManager.Data;

namespace AccountManager.Test
{
    [TestClass]
    public class AccountTypeData
    {
        public AccountTypeData()
        {
            var factory = new AccountManagerDesignTimeFactory();

        }

        [TestMethod]
        public void AddOk()
        {
        }
    }

   
}
