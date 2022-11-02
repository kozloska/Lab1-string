using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GetTest1()
        {
            string word1 = "процессор";
            string word2 = "информация";
            string massage = Logic.Task(word1, word2);
            Assert.AreEqual("нет да да да нет нет ", massage);
        }
        [TestMethod()]
        public void Getest2()
        {
            string word1 = "кредитор";
            string word2 = "редиска";
            string massage = Logic.Task(word1, word2);
            Assert.AreEqual("да да да да да нет нет ", massage);
        }
        [TestMethod()]
        public void GetTest3()
        {
            string word1 = "расписка";
            string word2 = "сенсор";
            string massage = Logic.Task(word1, word2);
            Assert.AreEqual("да нет да нет нет нет ", massage);
        }
        [TestMethod()]
        public void GetTest4()
        {
            string word1 = "привет";
            string word2 = "вектор";
            string massage = Logic.Task(word1, word2);
            Assert.AreEqual("нет да нет да да да ", massage);
        }

    }
}