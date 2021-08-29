using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests

{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void MetodGroupCreationTests()
        {
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData ("admin", "secret") );
            navigationHelper.GoToGroupsPage();
            InitNewGroupPage();
            GroupData group = new GroupData("qqq");
            group.Header = "lll";
            group.Footer = "yyy";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            loginHelper.Logout();
        }

    }
}

