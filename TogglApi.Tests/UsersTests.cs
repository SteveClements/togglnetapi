using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TogglApi.Tests
{
    [TestClass]
    public class UsersTests
    {


        [TestMethod]
        public void Users_Constructor_Test()
        {
            TogglAuthRequest ar = new TogglAuthRequest {
                ApiToken = "any string will pass",
                UserName = "",
                Password = ""
            };

            Users u = new Users(ar);
            Assert.IsNotNull(u);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Users_Constructor_With_All_Empty_Strings_Test()
        {
            TogglAuthRequest ar = new TogglAuthRequest {
                ApiToken = "",
                UserName = "",
                Password = ""
            };

            Users u = new Users(ar);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Users_Constructor_With_Only_Username_Test()
        {
            TogglAuthRequest ar = new TogglAuthRequest {
                ApiToken = "",
                UserName = "this should fail as without an api token you need both username and password",
                Password = ""
            };

            Users u = new Users(ar);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Users_Constructor_With_Only_Password_Test()
        {
            TogglAuthRequest ar = new TogglAuthRequest {
                ApiToken = "",
                UserName = "",
                Password = "this should fail as without an api token you need both username and password"
            };

            Users u = new Users(ar);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Users_Constructor_With_Null_Test()
        {
            Users u = new Users(null);
        }
    }
}
