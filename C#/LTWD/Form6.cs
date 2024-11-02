using System;
using System.Windows.Forms;

namespace LTWD
{
    public partial class Form6 : Form
    {
        decimal workingMemory = 0;
        string opr = "";

        public Form6()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbKetQua.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbKetQua.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbKetQua.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbKetQua.Text += bt3.Text;
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKetQua.Text))
            {
                workingMemory = decimal.Parse(tbKetQua.Text);
                opr = "+";
                tbKetQua.Clear();
            }
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKetQua.Text))
            {
                workingMemory = decimal.Parse(tbKetQua.Text);
                opr = "*";
                tbKetQua.Clear();
            }
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKetQua.Text))
            {
                decimal currentNumber = decimal.Parse(tbKetQua.Text);

                switch (opr)
                {
                    case "+":
                        tbKetQua.Text = (workingMemory + currentNumber).ToString();
                        break;
                    case "*":
                        tbKetQua.Text = (workingMemory * currentNumber).ToString();
                        break;
                    default:
                        tbKetQua.Text = currentNumber.ToString();
                        break;
                }
                opr = ""; // Reset toán tử sau khi tính toán
            }
        }

        private void btCham_Click(object sender, EventArgs e)
        {
            if (!tbKetQua.Text.Contains("."))
            {
                tbKetQua.Text += ".";
            }
        }
    }
}
