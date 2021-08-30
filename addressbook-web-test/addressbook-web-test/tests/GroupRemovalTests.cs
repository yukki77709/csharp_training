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
            app.Group.Removal(1);
            app.Auth.Logout();
        }
    }
}

