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
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData ("admin", "secret") );
            app.Navigator.GoToGroupsPage();
            app.Group.InitNewGroupPage();
            GroupData group = new GroupData("qqq");
            group.Header = "lll";
            group.Footer = "yyy";
            app.Group.FillGroupForm(group);
            app.Group.SubmitGroupCreation();
            app.Group.ReturnToGroupPage();
            app.Auth.Logout();
        }

    }
}

