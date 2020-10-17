using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wwbweibo.Utils.Crypto;
using Wwbweibo.Utils.Extensions;

namespace Wwbweibo.Utils.Tests.Crypto
{
    [TestClass]
    public class HashHelperTests
    {
        
        [TestMethod]
        public void Md5Test()
        {
            var expected = "900150983CD24FB0D6963F7D28E17F72";
            Assert.AreEqual(expected, HashHelper.Md5Checksum("abc".ToBytes()));
        }
    }
}