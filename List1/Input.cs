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
    public partial class Input : Form
    {
        int[,] table = new int[2,3];
        public Input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table[0, 0] = int.Parse(textBox1.Text);
            table[0, 1] = int.Parse(textBox2.Text);
            table[0, 2] = int.Parse(textBox3.Text);
            table[1, 0] = int.Parse(textBox4.Text);
            table[1, 1] = int.Parse(textBox5.Text);
            table[1, 2] = int.Parse(textBox6.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public int[,] Content
        {
            get
            {
                return table;
            }
        }
    }
}
