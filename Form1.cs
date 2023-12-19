using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dia1003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraDoWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible == false)
                dateTimePicker1.Visible = true;
            else
                dateTimePicker1.Visible = false;
        }
    }
}
