using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paging;

//using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Class1.Pager pager1;
        Control last;
        private int curPage = 0;
        private int countVisiblePages = 10;
        private int pageAtVisiblePages = 7;
        private int recsOnPage = 10;

        private int recordsCount = 111;
        private List<string> records;
        
        public Form1()
        {
            InitializeComponent();


            NUMRecCount.Value = recordsCount;
            NUMRecsAtPage.Value = recsOnPage;
            NUMVisiblePagesCount.Value = countVisiblePages;
            NUMPoljenie.Value = pageAtVisiblePages;


            records = new List<string>();

            initPager();
            Otobrajenie(1);

        }



    //    public string[] logika(int count Pages


        private void setControlProperties(Control page, string caption)
        {
            page.Font = LToBegin.Font;
            page.Left = last.Left + last.Width + 3;
            page.Top = last.Top;
            page.Text = caption;
            page.AutoSize = true;
            panel2.Controls.Add(page);
            page.Click += LPage_Click;
            if (caption == curPage.ToString())
            {
                page.ForeColor = Color.DarkOrchid;
            }
            page.Show();
            last = page;
        }

        private void LPage_Click(object sender, EventArgs e)
        {
            int toPage = 1;

            switch (((Label) sender).Text)
            {
                case "<":
                    toPage = curPage > 1 ? curPage - 1 : 1;
                    break;
                case ">":
                    toPage = curPage < pager1.PagesCount ? curPage + 1 : pager1.PagesCount;
                    break;
                case "<<":
                    toPage = 1;
                    break;
                case ">>":
                    toPage = pager1.PagesCount;
                    break;
                default:
                    if (!int.TryParse(((Label) sender).Text, out toPage)) toPage = 1;
                    break;
            }

            Otobrajenie(toPage);

        }
        
        private void Otobrajenie(int toPage)
        {

            List<string> pagesTxts = pager1.getResult(toPage, countVisiblePages, pageAtVisiblePages);
            

           // List<string> pagesTxts = pager1.pagesText(toPage, countVisiblePages, pageAtVisiblePages);
            if (pagesTxts.Count == 0) return;
            curPage = toPage;


            last = LToBegin;
            panel2.Controls.Clear();

            textBox1.Text = "";

            for (int i = 0; i < pagesTxts.Count - 2; ++i)
            {
                setControlProperties(new Label(), pagesTxts[i]);
            }

            int[] points = {Convert.ToInt32(pagesTxts[pagesTxts.Count - 2])
                , Convert.ToInt32(pagesTxts[pagesTxts.Count - 1])};

            for (int i = points[0]; i < points[1]; ++i)
            {
                if (i >= records.Count) break;
                textBox1.Text += records[i] + "\r\n";
            }

        }

        private void initPager()
        {
            records.Clear();
            for (int i = 0; i < recordsCount; ++i)
            {
                records.Add("- Запись № " + (i + 1));
            }

            if(pager1 == null)
                pager1 = new Class1.Pager(recordsCount, recsOnPage);
            else
            {
                pager1.CountOfRecs = recordsCount;//Convert.ToInt32(NUMRecCount);
                pager1.CountOnPage = recsOnPage;
            }
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            recordsCount = Convert.ToInt32(NUMRecCount.Value);
            countVisiblePages = Convert.ToInt32(NUMVisiblePagesCount.Value);
            pageAtVisiblePages = Convert.ToInt32(NUMPoljenie.Value);
            recsOnPage = Convert.ToInt32(NUMRecsAtPage.Value);

            initPager();
            Otobrajenie(1);
        }

        
        //extern void 

    }
}
