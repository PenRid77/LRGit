using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LR2
{
    public partial class MainMenu : Form, IMainView
    {
       
        public event Action ShowedRunnerStats;
        public MainMenu()
        {
            InitializeComponent();
        }



        public new void Show()
        {
            Application.Run(this);
        }
        public void DrawData(List<List<string>> data)
        {

           

            listView1.Clear();

            List<ListViewItem> listViewItems = CreateListViewItems(data);
            foreach (var item in CreateColumns(data))
            {
                listView1.Columns.Add(item);
            }
            foreach (var item in listViewItems)
            {
                listView1.Items.Add(item);
           
          }



        }
        public void DrawGraphic(Dot[] dots)
        {
           Series series = new Series();
            series.Name = "Chart" + (chart1.Series.Count - 1).ToString();
            var rand = new Random();
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.FromArgb(255, rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            chart1.Series.Add(series);
            for (int i = 0; i < dots.Length; i++)
            {
                chart1.Series[chart1.Series.Count-1].Points.AddXY(dots[i].X, dots[i].Y);

            }

        }
        public void ClearGraphic()
        {
            chart1.Series.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private List<ColumnHeader> CreateColumns(List<List<string>> data)
        {
            List<ColumnHeader> columnHeaders = new List<ColumnHeader>();
            for (int i = 0; i < data[0].Count; i++)
            {
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = data[0][i];

                columnHeaders.Add(columnHeader);
            }
            return columnHeaders;
        }
        private List<ListViewItem> CreateListViewItems(List<List<string>> data)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            for (int i = 1; i < data.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(data[i][0]);
                for (int j = 1; j < data[i].Count; j++)
                {
                    listViewItem.SubItems.Add(data[i][j]);

                }
                listViewItems.Add(listViewItem);
            }


            return listViewItems;

        }
     
        private void ShowRunnerStats(object sender, EventArgs e)
        {
            ShowedRunnerStats?.Invoke();
        }

    }
}
