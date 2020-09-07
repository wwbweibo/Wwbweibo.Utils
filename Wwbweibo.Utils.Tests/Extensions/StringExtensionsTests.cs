using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wwbweibo.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wwbweibo.Utils.Extensions.Tests
{
    [TestClass()]
    public class StringExtensionsTests
    {
        [TestMethod()]
        public void ToIntTest()
        {
            string a = "10";
            Assert.AreEqual(10, a.ToInt());
        }

        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void ToIntTest_throw_exception()
        {
            string a = "a";
            Assert.AreEqual(10, a.ToInt(throwException: true));
        }

        [TestMethod]
        public void ToIntTest_default_value()
        {
            string a = "a";
            Assert.AreEqual(10, a.ToInt(value: 10));
        }

        [TestMethod()]
        public void ToDoubleTest()
        {
            string a = "10.0";
            Assert.AreEqual(10.0, a.ToDouble());
        }

        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void ToDoubleTest_throw_exception()
        {
            string a = "10.a";
            Assert.AreEqual(10, a.ToDouble(throwException: true));
        }

        [TestMethod]
        public void ToDoubleTest_default_value()
        {
            string a = "a";
            Assert.AreEqual(10.1, a.ToDouble(value: 10.1));
        }

        [TestMethod()]
        public void ToFloatTest()
        {
            string a = "10.1";
            Assert.AreEqual(10.1f, a.ToFloat());
        }

        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void ToFloatTest_throw_exception()
        {
            string a = "a";
            Assert.AreEqual(10, a.ToFloat(throwException: true));
        }

        [TestMethod]
        public void ToFloatTest_default_value()
        {
            string a = "a";
            Assert.AreEqual(10.1f, a.ToFloat(value: 10.1f));
        }
    }
}