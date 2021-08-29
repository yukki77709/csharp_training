﻿using System;
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
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToNewContactPage();
            ContactData contact = new ContactData("Юлия1", "Степанова1");
            contactHelper.FillContactForm(contact);
            contactHelper.SubmitContactCreation();
            loginHelper.Logout();
        }

    }
}
