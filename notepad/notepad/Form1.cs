using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace notepad
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "  ";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form3 f3 = new Form3(this);
            f3.Show();

        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();

        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString(); 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "text files|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fn);
                
            }
                
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                this.textBox1.Text = " ";
            }
            else
            {

                saveFileDialog1.Filter = "all text (*.txt)|*.txt";
                DialogResult dr = this.saveFileDialog1.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    string fn = saveFileDialog1.FileName;
                    fn += ".txt";
                    File.WriteAllText(fn, this.textBox1.Text);
                }
            }
        
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            this.textBox1.BackColor = Color.Silver;
            this.textBox1.ForeColor = Color.Navy;
            this.textBox1.ScrollBars = ScrollBars.Both;
            this.Text = "IQRA YOUSUFZAIE";
            this.textBox1.Dock = DockStyle.Fill;
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            timeDateToolStripMenuItem.ShortcutKeys = Keys.F5;
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            findNextToolStripMenuItem.ShortcutKeys = Keys.F3;
            replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            goToToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            this.wordWrapToolStripMenuItem.Checked = false;
            this.textBox1.WordWrap = true;
            
            
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                wordWrapToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Application.Exit();
            openFileDialog1.Filter = "(*.txt)|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fn);

            }
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            DialogResult drr = this.saveFileDialog1.ShowDialog();
            if (drr == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                fn += ".txt";
                File.WriteAllText(fn, this.textBox1.Text);
            }
        }


        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void withColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.fontDialog1.Color;
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void withoutColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = false;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CREATED BY IQRA QUDDUS");
        }
    }
}
