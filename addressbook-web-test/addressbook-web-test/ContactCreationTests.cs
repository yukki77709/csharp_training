using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void MetodContactCreationTests()
        {
            OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            GoToNewContactPage();
            ContactData contact = new ContactData("Юлия1", "Степанова1");
            FillContactForm(contact);
            SubmitContactCreation();
            loginHelper.Logout();
        }

    }
}
