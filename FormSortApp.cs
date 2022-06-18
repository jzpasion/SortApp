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
    public partial class formSort : Form
    {
        public formSort()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;


            if (!input.ToCharArray().Any(char.IsDigit))
            {
                if (input.Length <= 1)
                {
                    MessageBox.Show("Please input atlease 2 letters!");
                    txtInput.Text = "";
                }
                else
                {
                    if (radioMergeSort.Checked)
                    {
                        lblAnswer.Text = Logic.MergeSort(input.Replace(" ", "").ToLower());
                    }
                    else if (radioBubbleSort.Checked)
                    {
                        lblAnswer.Text = Logic.BubleSort(input.Replace(" ", "").ToLower());
                    }
                    else
                    {
                        MessageBox.Show("Please choose a Algorithm!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No numbers allowed!");
                txtInput.Text = "";
            }
        }
    }
}
