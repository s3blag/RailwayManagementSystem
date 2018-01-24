using Microsoft.VisualStudio.TestTools.UnitTesting;
using RailwayManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.Tests
{
    [TestClass()]
    public class LoginFormTests
    {
        [TestMethod()]
        public void EncryptTest()
        {
           string encryptedPassword = Encrypt(string admin);
        }
    }
}