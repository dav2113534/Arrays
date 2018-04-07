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
            listBox1.Items.Clear();

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

            // created 
            int[] aryTimes;
            aryTimes = new int[11];

            int times = int.Parse(textBox1.Text);

            for (int i = 0; i != (aryTimes.Length); i++)
            {
                aryTimes[i] = i * times;
                listBox1.Items.Add(times + " X " + i + " = " + aryTimes[i]);
            }
        }

        private void btn2DimensionalArray_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int arrayRows = int.Parse(textBox1.Text);
            int arrayCols = 3;

            int[,] arrayTimes;
            arrayTimes = new int[arrayRows, arrayCols];

            int mult = 0;

            for (int i = 0; i != arrayRows; i++)
            {
                mult = mult + 10;

                for (int j = 0; j != arrayCols; j++)
                {
                    arrayTimes[i, j] = mult;
                    mult = mult * 10;

                    // This will display array position and values
                    listBox1.Items.Add("arrayPos = " + i + "." + j +
                            " " + " Val = " + arrayTimes[i, j]);
                } 

                mult = mult / 1000;
            }
        }

        private void btnStringArrays_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 

            string[] arrayStrings;
            arrayStrings = new string[5];

            arrayStrings[0] = "This";
            arrayStrings[1] = "is";
            arrayStrings[2] = "a";
            arrayStrings[3] = "string";
            arrayStrings[4] = "array";

            // foreach loops don't need to use index #'s like for loops
            foreach (string arrayElement in arrayStrings)
            {
                listBox1.Items.Add(arrayElement);
            }
        }
    }
}
