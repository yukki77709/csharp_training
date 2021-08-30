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
            ContactData contact = new ContactData("Юлия1", "Степанова1");
            app.Contact.Create(contact);
            app.Auth.Logout();
        }

        [Test]
        public void EmtyContactCreationTests()
        {
            ContactData contact = new ContactData("", "");
            app.Contact.Create(contact);
            app.Auth.Logout();
        }

    }
}
