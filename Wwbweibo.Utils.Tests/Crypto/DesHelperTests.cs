using System;
using Core.Extensions.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wwbweibo.Utils.Crypto;

namespace Wwbweibo.Utils.Tests.Crypto
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

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void DesDecrypt_VeryLongKey_Test()
        {
            var text = "abc";
            var key = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111";

            var encoded = DesHelper.DesEncrypt(text.ToBytes(), key.ToBytes(), new byte[0]);
            var decoded = DesHelper.DesDecrypt(encoded, key.ToBytes(), new byte[0]);
            Assert.AreEqual(text, decoded.GetString());
        }
    }
}