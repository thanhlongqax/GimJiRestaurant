using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Management.RevenueManagement
{
    public partial class uc_revenueManagement : UserControl
    {
        string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "Octorber", "November", "December" };
        string[] quarter = { "Q1", "Q2", "Q3", "Q4" };
        public uc_revenueManagement()
        {
            InitializeComponent();
            InitializeChart();
        }




        private void InitializeChart()
        {

            chart_revenue.YAxes.GridLines.Display = false;

            chart_2.XAxes.Display = false;
            chart_2.YAxes.Display = false;
            ////////
            GenerateLine(month);
            chart_2.Datasets.Add(doughnot_chart);
            //chart_2.Datasets.Add(line_second);
            //chart_2.Title.Text = "Customer and dish";
            chart_2.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            //chart_2.Datasets.Add(line_second);
            chart_revenue.Datasets.Add(bar_chart);
            chart_revenue.Datasets.Add(spline_chart);


            chart_revenue.Update();
            chart_2.Update();
        }
        private void GenerateLine(string[] time)
        {

            for (int i = 0; i < time.Length; i++)
            {
                //// replace this code with data in sql : Y = data
                var random = new Random().Next(10, 100);
                spline_chart.DataPoints.Add(new LPoint()
                {
                    Label = time[i],
                    Y = random + Math.Round((double)(random / 5)),
                });
                bar_chart.DataPoints.Add(new LPoint()
                {
                    Label = time[i],
                    Y = random,
                });
                
                doughnot_chart.DataPoints.Add(new LPoint()
                {
                    Label = time[i],
                    Y = random,
                });
                


                ////////////////////////////////////////////////////////

            }

        }

        private void chart_2_Load(object sender, EventArgs e)
        {

        }
    }
}
