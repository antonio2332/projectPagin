using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Paging.Tests
{
    [TestClass()]
    public class PagerTests
    {
        [TestMethod()]

        public void Setters_Changing_PagesCount()
        { // проверка что правильно срабатывает изменение кол-ва заисей и записей на странице. В одном тесте, т.к. вызывается один и тот метод внутри класса

            int countRecs = 125;
            int countOnPage = 7;

            Pager pager1 = new Pager(countRecs, countOnPage);
            Pager pager2 = new Pager(20, 5);

            //
            pager2.CountOfRecs = countRecs;
            pager2.CountOnPage = countOnPage;
            
            //
            Assert.AreEqual(pager1.PagesCount, pager2.PagesCount);
        }

        [TestMethod()]
        public void getResultTest()
        {//проверка что getResult возвращает не пустой текстовый список и что в конце него сеть 2 числовых значения (границы для обрезки массива)


            int countRecs = 150;
            int countOnPage = 15;
            int toPage = 5;
            int countVisiblePages = 10;
            int pageAtVisiblePages = 3;
            Pager pager1 = new Pager(countRecs, countOnPage);

            List<string> pagesTxts = pager1.getResult(toPage, countVisiblePages, pageAtVisiblePages);


            
            for (int i = 0; i <  pagesTxts.Count - 2; ++i)
            {
                if (String.IsNullOrEmpty(pagesTxts[i])) Assert.Fail();
            }

            int rez;

            Assert.IsTrue(int.TryParse(pagesTxts[pagesTxts.Count - 2], out rez) && int.TryParse(pagesTxts[pagesTxts.Count - 1], out rez));
        }

        //[TestMethod()]
        //public void cuttingTest()
        //{
        //    Assert.Fail();
        //}


    }
}
