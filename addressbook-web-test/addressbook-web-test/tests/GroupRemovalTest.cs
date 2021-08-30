using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void MetodGroupRemovalTests()
        {
            app.Navigator.GoToGroupsPage();
            app.Group
                .SelectGroup(1)
                .RemoveGroup()
                .ReturnToGroupPage();
            app.Auth.Logout();
        }
    }
}

