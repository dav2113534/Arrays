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
            lottery_numbers = new int[1000];
            /*
            lottery_numbers[0] =1;
            lottery_numbers[1] =2;
            lottery_numbers[2] =3;
            lottery_numbers[3] =4;
            */

            // press tab after typing for shortcut 
            for (int i = 0; i != (lottery_numbers.Length); i++)
            {
                // this assigns values to our array ints
                lottery_numbers[i] = i + 1;
                listBox1.Items.Add(lottery_numbers[i]);
            }

        }

        private void btnSetArraySize_Click(object sender, EventArgs e)
        {
            int aNumber = int.Parse(textBox1.Text);

            int[] arraySize;

            arraySize = new int[aNumber];

            for (int i = 0; i != (arraySize.Length); i++)
            {
                arraySize[i] = i + 1;

                listBox1.Items.Add(arraySize[i]);
            }
        }

        private void btnTimesTables_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] aryTimes;
            aryTimes = new int[10];

            int times = int.Parse(textBox1.Text);

            for (int i = 0; i != (aryTimes.Length); i++)
            {
                aryTimes[i] = i * times;
                listBox1.Items.Add(times + " X " + i + " = " + aryTimes[i]);
            }
        }
    }
}
