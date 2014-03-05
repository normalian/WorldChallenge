using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldChallenge.Test
{
    using WorldChallenge;

    [TestClass]
    public class StringUtilTest
    {
        [TestMethod]
        public void TestMethod_同じ長さの並べ替え()
        {
            bool expected = true;
            bool actual = StringUtil.IsRearrange("abcde", "ebdac");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_同じ長さで並べ替えでない()
        {
            bool expected = false;
            bool actual = StringUtil.IsRearrange("abcde", "ebdfc");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_第一引数の方が長い()
        {
            bool expected = false;
            bool actual = StringUtil.IsRearrange("abcde", "ebac");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_第二引数の方が長い()
        {
            bool expected = false;
            bool actual = StringUtil.IsRearrange("abde", "ebdac");

            Assert.AreEqual(expected, actual);
        }
    }
}
