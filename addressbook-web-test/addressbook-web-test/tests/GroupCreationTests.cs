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
            GroupData group = new GroupData("qqq");
            group.Header = "lll";

            group.Footer = "yyy";
            app.Group.Create(group);
            app.Auth.Logout();
        }

        [Test]
        public void EmtyGroupCreationTests()
        {

            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Group.Create(group);
            app.Auth.Logout();
        }

    }
}

