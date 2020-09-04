using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Extensions.Utils;
using Wwbweibo.Utils.Crypto;

namespace Wwbweibo.Utils.Crypto.Tests
{
    [TestClass()]
    public class DesHelperTests
    {
        [TestMethod()]
        public void DesDecryptTest()
        {
            var text = "abc";
            var key = "111";

            var encoded = DesHelper.DesEncrypt(text.ToBytes(), key.ToBytes(), new byte[0]);
            var decoded = DesHelper.DesDecrypt(encoded, key.ToBytes(), new byte[0]);
            Assert.AreEqual(text, decoded.GetString());
        }
    }
}