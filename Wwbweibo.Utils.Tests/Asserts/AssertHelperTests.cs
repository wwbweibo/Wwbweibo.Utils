using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wwbweibo.Utils.Asserts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Wwbweibo.Utils.Asserts.Tests
{
    [TestClass()]
    public class AssertHelperTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void AssertNullTest()
        {
            AssertHelper.AssertNull(null);
        }

        [TestMethod()]
        public void AssertNull_Pass_Test()
        {
            AssertHelper.AssertNull(new object());
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void AssertNullOrEmpty_when_input_is_Enumerable()
        {
            IEnumerable data = new List<object>();
            AssertHelper.AssertNullOrEmpty(data);
        }

        [TestMethod]
        public void AssertNullOrEmpty_when_input_is_Enumerable_Pass()
        {
            var list = new List<object>();
            list.Add(new object());
            IEnumerable data = list.AsEnumerable();
            AssertHelper.AssertNullOrEmpty(data);
        }

        [TestMethod]
        public void AssertNullOrEmpty_when_input_is_Queryable()
        {
            var list = new List<object>();
            list.Add(new object());
            IQueryable data = list.AsQueryable();
            AssertHelper.AssertNullOrEmpty(data);
        }
    }
}