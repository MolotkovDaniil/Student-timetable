﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        /// <summary>
        /// Удаление существующих данных выбранной строки из таблицы
        /// </summary>
        [TestMethod]
       public void Task_395_1()
		{
            MEnclosures gr = new MEnclosures("Ж", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            //act 
            RefData.CEnclosures.Insert(gr);
            bool result = RefData.CEnclosures.Insert(gr);
            //assert 
            Assert.AreEqual(true, RefData.CEnclosures.Delete(gr));
        }
        /// <summary>
        /// Удаление данных из пустой таблицы
        /// </summary>
        [TestMethod]

        public void Task_395_2()
        {
           //arrange 
            MEnclosures gr = new MEnclosures("Я", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            //act 
            bool actual = RefData.CEnclosures.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
