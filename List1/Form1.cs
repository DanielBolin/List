using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List1
{
    public partial class Form1 : Form
    {
        int[,] t; 
        public Form1()
        {
            InitializeComponent();
        }

        private void 輸入表格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input input = new Input();
            input.ShowDialog();
            t = input.Content;
            計算ToolStripMenuItem.Enabled = true;
        }

        private void 計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Output output = new Output();
            output.DoComputeration(t);
            output.ShowDialog();
        }
    }
}
