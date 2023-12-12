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

namespace Gimji.GUI.Management.Inventory_Management
{
    public partial class uc_inventoryManagement : UserControl
    {
        public uc_inventoryManagement()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void lb_stt_Click(object sender, EventArgs e)
        {

        }

        private void uc_inventoryManagement_Load(object sender, EventArgs e)
        {
            pal_listInventory.Controls.Clear();
            for (int i = 0; i < 15; i++)
            {
                pal_listInventory.Controls.Add(new uc_inventory());
            }

        }
        private void loadData()
        {
            pal_listInventory.Controls.Clear();

        }

        private void InitializeChart()
        {

            inventory_chart.XAxes.GridLines.Display = false;
            inventory_chart.YAxes.Display = false;
            inventory_chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;

            string[] type = { "Kimbak", "Tokbokki", "ABC", "D", "E", "G", "F" };
            long[] value = { 0, 0, 0 };
            GenerateLine(type, value);
            inventory_chart.Datasets.Add(bar_chart);
        }
        private void GenerateLine(string[] type, long[] value)
        {
            for (int i = 0; i < type.Length; i++)
            {

                ////replace label = type and Y value = value in array or list input
                var random = new Random().Next(10, 100);
                bar_chart.DataPoints.Add(new LPoint()
                {
                    Label = type[i],
                    Y = random,
                });

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
