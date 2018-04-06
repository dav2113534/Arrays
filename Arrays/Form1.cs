using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] lottery_numbers;
            lottery_numbers = new int[49];
            /*
            lottery_numbers[0] =1;
            lottery_numbers[1] =2;
            lottery_numbers[2] =3;
            lottery_numbers[3] =4;
            */
            for (int i = 0; i != (lottery_numbers.Length); i++)
            {
                lottery_numbers[i] = i + 1;
                listBox1.Items.Add(lottery_numbers[i]);
            }

        }
    }
}
