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

namespace SortApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (radioQuickSort.Checked)
            {

               

            }
            else if(radioBubbleSort.Checked)
            {
                lblAnswer.Text = "Output: " + BubleSort(input);
            }
            else
            {
                MessageBox.Show("Please choose a Algorithm!");
            }
            

        }

        public string BubleSort(string input)
        {

            char[] toSort = input.ToCharArray();
            char tempLastValue;
            string result = "";

            for (int characterPos = 0; characterPos < toSort.Length; characterPos++)
            {
                for (int valueToCompare = 0; valueToCompare < toSort.Length - 1; valueToCompare++)
                {
                    if (toSort[valueToCompare].CompareTo(toSort[valueToCompare + 1]) > 0)
                    {
                        tempLastValue = toSort[valueToCompare];
                        toSort[valueToCompare] = toSort[valueToCompare + 1];
                        toSort[valueToCompare + 1] = tempLastValue;

                    }

                }
            }

            for(int x = 0; x< toSort.Length; x++)
            {
                result += toSort[x];
            }

            return result;
        }
    }
}
