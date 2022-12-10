using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//using LiveCharts; using LiveCharts.Wpf;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Timer timer = new Timer();
            timer.Interval = (1 * 200); // 1 sec.
            timer.Tick += new EventHandler(DisplayGraph); //timer1_tick represents the name of Tick Event
            timer.Start();*/
        }

        Func<ChartPoint,string> labelPoint =chartpoint=> string.Format("{0} {1:P}", chartpoint.Y, chartpoint.Participation);
        /*
        public void DisplayGraph(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.Analyst)
                series.Add(new PieSeries() {
                    Title=obj.Year.ToString(),
                    Values=new ChartValues<int> { obj.Expenses },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            pieChart1.Series = series;
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.Analyst)
                series.Add(new PieSeries() {
                    Title=obj.Year.ToString(),
                    Values=new ChartValues<int> { obj.Expenses },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            pieChart1.Series = series;
        }
    }
}
