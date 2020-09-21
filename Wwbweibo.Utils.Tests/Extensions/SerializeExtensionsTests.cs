using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wwbweibo.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wwbweibo.Utils.Extensions.Tests
{
    [TestClass()]
    public class SerializeExtensionsTests
    {
        [TestMethod()]
        public void JsonSerializeTest()
        {
            Assert.AreEqual(SerializeExtensions.JsonSerialize(new { Name = "123" }, true), "{\"name\":\"123\"}");
        }
    }
}