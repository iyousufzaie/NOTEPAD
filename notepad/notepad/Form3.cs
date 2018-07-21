using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Find";
            this.label1.Text = "Find what";
            this.button1.Text = "Find";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (f1.textBox1.Text.Contains(this.textBox1.Text))
            {
                MessageBox.Show("Find" + '"' + textBox1.Text + '"');
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
