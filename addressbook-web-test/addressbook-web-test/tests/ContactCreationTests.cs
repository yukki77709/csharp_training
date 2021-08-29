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
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToNewContactPage();
            ContactData contact = new ContactData("Юлия1", "Степанова1");
            app.Contact.FillContactForm(contact);
            app.Contact.SubmitContactCreation();
            app.Auth.Logout();
        }

    }
}
