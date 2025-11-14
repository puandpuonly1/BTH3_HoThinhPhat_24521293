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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void Cong_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerTextBox.Text = (Convert.ToInt32(Number1TextBox.Text) + Convert.ToInt32(Number2TextBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerTextBox.Text = (Convert.ToInt32(Number1TextBox.Text) - Convert.ToInt32(Number2TextBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void Nhan_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerTextBox.Text = (Convert.ToInt32(Number1TextBox.Text) * Convert.ToInt32(Number2TextBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Number2TextBox.Text) != 0)
                    AnswerTextBox.Text = (1.0*Convert.ToInt32(Number1TextBox.Text) / Convert.ToInt32(Number2TextBox.Text)).ToString();
                else
                    MessageBox.Show("E là không thể chia cho 0");
            }
            catch
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void Number1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                if (Number1TextBox.SelectionStart != 0 || Number1TextBox.Text.Contains("-"))
                    e.Handled = true;
                return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && Number1TextBox.Text.Contains("."))
                e.Handled = true;
        }

        private void Number2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                if (Number2TextBox.SelectionStart != 0 || Number2TextBox.Text.Contains("-"))
                    e.Handled = true;
                return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && Number2TextBox.Text.Contains("."))
                e.Handled = true;
        }
    }
}
