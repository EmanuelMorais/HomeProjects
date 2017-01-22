using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdDinner.Controllers;

namespace NerdDinner.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTests
    {
        private MockRepository mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
            
            AccountController accountController = this.CreateAccountController();
            
            
        }

        private AccountController CreateAccountController()
        {
            return new AccountController();
        }
    }
}
