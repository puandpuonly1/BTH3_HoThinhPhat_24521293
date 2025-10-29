using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3_HoThinhPhat_24521293
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }
        int sum = 0;
        void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                if (sender == button1 || sender == button2 || sender == button3 || sender == button4 || sender == button5)
                    sum += 5000;
                else if (sender == button6 || sender == button7 || sender == button8 || sender == button9 || sender == button10)
                    sum += 6500;
                else
                    sum += 8000;
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Yellow)
                MessageBox.Show("Ve o vi tri nay da duoc ban");
            else
            {
                if (sender == button1 || sender == button2 || sender == button3 || sender == button4 || sender == button5)
                    sum -= 5000;
                else if (sender == button6 || sender == button7 || sender == button8 || sender == button9 || sender == button10)
                    sum -= 6500;
                else
                    sum -= 8000;   
                btn.BackColor = Color.White;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void ChonButton_Click(object sender, EventArgs e)
        {
            Button[] btns = {button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15 };
            ThanhtienTextBox.Text = sum.ToString();
            for (int i = 0; i < btns.Length; i++)
                if (btns[i].BackColor == Color.Blue)
                    btns[i].BackColor = Color.Yellow;
            sum = 0;
        }

        private void HuyboButton_Click(object sender, EventArgs e)
        {
            Button[] btns = {button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15 };
            sum = 0;
            ThanhtienTextBox.Text = sum.ToString();
            for (int i = 0; i < btns.Length; i++)
                if (btns[i].BackColor == Color.Blue)
                    btns[i].BackColor = Color.White;
        }

        private void KetthucButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
