using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Windows_lol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Process> plist = new List<Process>();
            foreach (Process p in Process.GetProcesses())
            {
                string title = p.MainWindowTitle;
                if (!String.IsNullOrEmpty(title))
                {
                    plist.Add(p);
                }
            }
            foreach (Process p in plist)
            {
                listView1.Items.Add(p.MainWindowTitle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form lol = Form.ActiveForm;
            lol.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form lol = Form.ActiveForm;
            Size mySize = new Size(Convert.ToInt32(textBox2.Text.Split(';')[0]), Convert.ToInt32(textBox2.Text.Split(';')[1]));
            lol.Size = mySize;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form lol = Form.ActiveForm;
            Point myPoint = new Point(Convert.ToInt32(textBox3.Text.Split(';')[0]), Convert.ToInt32(textBox3.Text.Split(';')[1]));
            lol.Location = myPoint;
        }
    }
}
