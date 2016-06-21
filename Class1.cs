using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//using Windows.Foundation;
//using Windows.UI;
//using Windows.UI.Xaml.Controls;

namespace Paging
{
        public class Pager  
        {
            private int pagesCount;
            private int countOfRecs;
            private int countOnPage;

            /// <summary>
            /// Размер "Окошка"
            /// </summary>
            /// <param name="CRecs">число записей в массиве</param>
            /// <param name="COnPage">Число записей на странице</param>
            public Pager(int CRecs, int COnPage) // при создании определяется кол-во страниц
            {
                countOfRecs = Math.Abs(CRecs);
                countOnPage = Math.Abs(COnPage);
                pagesCount = calcPagesCount();
            }

            private int calcPagesCount()
            {
                 return (countOfRecs%countOnPage) == 0 ? countOfRecs/countOnPage : countOfRecs/countOnPage + 1;
            }

            public int CountOfRecs// при изменении countOfRecs пересчитываем кол-во страниц
            {
                get { return countOfRecs; }
                set
                {
                    if (value == countOfRecs) return;
                    countOfRecs = value;
                    pagesCount = calcPagesCount();
                }
            }

            public int CountOnPage// при изменении countOnPage пересчитываем кол-во страниц
            {
                get { return countOnPage; }
                set
                {
                    if (value == countOnPage) return;
                    countOnPage = value;
                    pagesCount = calcPagesCount();
                }
            }

            public int PagesCount
            {
                get { return pagesCount;}
            }

            /// <summary>
            /// Возвращает список страниц
            /// </summary>
            /// <param name="numPage"></param>
            /// <param name="len">кол-во отображаемых страниц</param>
            /// <param name="center">выделенная страница среди отображаемых</param>
            /// <returns></returns>
            private List<string> pagesText(int numPage, int len, int center)
            {
                if (numPage > pagesCount || len < 1) return null;

                if (numPage <= 0) numPage = 1;
                if (center <= 0) center = 1;
                if (center > len) center = len/2 + 1;

                List<string> pTexts = new List<string>();
                //if (pagesCount - len > 1 && numPage > center) pTexts.Add("1");
                //else
                    pTexts.Add("<<");

              //  if (numPage > 1)
                    pTexts.Add("<");


                int firstInd;
                if (numPage <= center || pagesCount - len < 1) firstInd = 1;
                else if (numPage + (len - center ) > pagesCount) firstInd = pagesCount - len + 1;
                else firstInd = numPage - (center - 1);

                int count = 0;
                while (firstInd <= pagesCount && count < len)
                {
                    pTexts.Add(firstInd.ToString());
                    ++firstInd;
                    ++count;
                }

               // if (numPage < pagesCount)
                pTexts.Add(">");

                if (firstInd > pagesCount)
                pTexts.Add(">>");
                else pTexts.Add(pagesCount.ToString());
                
                
                return pTexts;
            }

            private List<string> Otobrajenie(List<string> pTexts, int curPage)
            {
                // Рассчитываю точки вырезки в массиве записей для выбранной страницы
                if (curPage < 1) curPage = 1;
                if (curPage > PagesCount) curPage = PagesCount;

                int x = countOnPage * (curPage - 1);
                int y;
                if (curPage == PagesCount)
                    y = countOfRecs + 1;
                else y = x + countOnPage;

                pTexts.Add(x.ToString());
                pTexts.Add(y.ToString());

                return pTexts;
            }

            public List<string> getResult(int numPage, int len, int center)
            {
                List<string> result = pagesText(numPage, len, center);
                result = Otobrajenie(result, numPage);
                return result;
            }

            ///// <summary>
            ///// Рассчет точек вырезки в массиве записей для выбранной страницы
            ///// </summary>
            ///// <param name="curPage">номер страницы</param>
            ///// <returns></returns>
            //public int[] cutting(int curPage)
            //{
            //    if (curPage < 1) curPage = 1;
            //    if (curPage > PagesCount) curPage = PagesCount;

            //    int x = countOnPage * (curPage - 1);
            //    int y;
            //    if (curPage == PagesCount)
            //        y = countOfRecs + 1;
            //    else y = x + countOnPage;

            //    int[] points = new int[2] {x, y};

            //    return points;
            //}
        }
}
