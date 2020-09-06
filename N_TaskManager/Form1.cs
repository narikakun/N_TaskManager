using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void get_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcesses();

            foreach (System.Diagnostics.Process p in ps)
            {
                try
                {
                    var responding = "";
                    if (!p.Responding)
                    {
                        responding = "応答なし";
                    }
                    dataGridView1.Rows.Add(p.ProcessName, p.Id, p.MainModule.FileName, p.TotalProcessorTime, p.WorkingSet64, responding);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcessesByName(textBox1.Text);
                foreach (System.Diagnostics.Process p in ps)
                {
                    p.Kill();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
