using devFglDemo.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace devFglDemo.Tests.DomainTests
{
    [TestClass]
    public class UserDomainTests
    {
        //[TestMethod]
        public void DadoNomeInvalidoDeveRetornarUmaNotificacao()
        {
            var user = new User("", "jonathas@dev.com", "Masculino");
            Assert.AreEqual(1, user.Notifications);
            
        }
    }
}
