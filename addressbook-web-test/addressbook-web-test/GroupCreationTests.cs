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
            OpenHomePage();
            Login(new AccountData ("admin", "secret") );
            GoToGroupsPage();
            InitNewGroupPage();
            GroupData group = new GroupData("qqq");
            group.Header = "lll";
            group.Footer = "yyy";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            Logout();
        }

    }
}

