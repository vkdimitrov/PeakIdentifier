using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace PeakIdentifier
{
    class Spectrum
    {
        private StreamReader reader;
        public static List<float> spectrum = new List<float>();
        private int rows;

        public int Rows()
        {
            return this.rows;
        }
        public Spectrum(string filename)
        {
            try
            {
                this.reader = new StreamReader(filename);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("nqma fail");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("nemoga da otvorq faila");
            }
            using (this.reader)
            {
                string line = this.reader.ReadLine();
                this.rows = 1;

                while (line != null)
                {
                    this.rows++;
                    Spectrum.spectrum.Add(Int32.Parse(line.Trim()));
                    line = this.reader.ReadLine();
                }
            }
            
        }
        public void Dump()
        {
            for (int i = 0; i <10; i++)
            {
                //MessageBox.Show(Spectrum.spectrum.ElementAt(i).ToString());
            }
        }
    }
}
