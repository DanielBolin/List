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
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }
        public void DoComputeration(int[,]t)
        {
            int[] rowSum = RowSum(t);
            int[] colSum = ColSum(t);
            int totalSum = TotalSum(t);
            richTextBox1.Text = "表格統計結果\n" + "\t1\t2\t3\t總和\n" + "1\t" + t[0, 0].ToString() + "\t" + t[0, 1].ToString() + "\t" + t[0, 2].ToString() + "\t" + rowSum[0].ToString() + "\n" + "2\t" + t[1, 0].ToString() + "\t" + t[1, 1].ToString() + "\t" + t[1, 2].ToString() + "\t" + rowSum[1].ToString() + "\n" + "總和\t" + colSum[0].ToString() + "\t" + colSum[1].ToString() + "\t" + colSum[2].ToString() + "\t" + totalSum.ToString() + "\n";


        }
        private int[] RowSum(int[,] data)
        {
            int[] r = new int [2];
            r[0]= data[0, 0] + data[0, 1] + data[0, 2];
            r[1]= data[1, 0] + data[1, 1] + data[1, 2];
            return r;
        }
        private int[] ColSum(int[,] data)
        {
            int[] c = new int[3];
            c[0] = data[0, 0] + data[1, 0];
            c[1] = data[0, 1] + data[1, 1];
            c[2] = data[0, 2] + data[1, 2];
            return c;
        }
        private int TotalSum(int[,] data)
        {
            int t = 0;
            t = data[0, 0] + data[0, 1] + data[0, 2] + data[1, 0] + data[1, 1] + data[1, 2];
            return t;
        }
    }
}
