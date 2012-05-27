using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PeakIdentifier
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void Browse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textFile.Text = ofd.FileName;
            }
        }

        private void Identify_Click(object sender, EventArgs e)
        {
            Spectrum peak = new Spectrum(textFile.Text);
            textFile.Text = "asd";
            chart1.Series.Add(textFile.Text);
            chart1.Series[textFile.Text].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            int rows = peak.Rows();
           // MessageBox.Show(rows.ToString());
            for (int i = 0; i < rows-1; i++)
            {
                chart1.Series[textFile.Text].Points.AddY(Spectrum.spectrum.ElementAt(i));
            }

            //chart1.Series[textFile.Text].Points.AddY(20);
          //  chart1.Series[textFile.Text].ChartArea = "ChartArea1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
