using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bbc.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using bbc.Functions;

namespace bbc.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckExistLessonInLocalDBTest()
        {
            bool isExist = HandleData.CheckExistLessonInLocalDB("YEzPzAiKoBTDtka6Km2S");
            Assert.AreEqual(false, isExist);
        }
    }
}
