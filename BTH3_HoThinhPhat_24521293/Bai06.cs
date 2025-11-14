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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }
        string s = "";
        private void button22_Click(object sender, EventArgs e)
        {
            s += 0;
            Default.Text = s;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 1;
            else
                if (Convert.ToInt32(s) == 0)
                s = 1.ToString();
                else
                    s += 1;
            Default.Text = s;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 2;
            else
                if (Convert.ToInt32(s) == 0)
                                s = 2.ToString();
                else
                    s += 2;
            Default.Text = s;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 3;
            else
                if (Convert.ToInt32(s) == 0)
                    s = 3.ToString();
                else
                    s += 3;
                Default.Text = s;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 4;
            else
                if (Convert.ToInt32(s) == 0)
                                s = 4.ToString();
                else
                    s += 4;
            Default.Text = s;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 5;
            else
                if (Convert.ToInt32(s) == 0)
                                s = 5.ToString();
                else
                    s += 5;
            Default.Text = s;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 6;
            else
                if (Convert.ToInt32(s) == 0)
                                s = 6.ToString();
                else
                    s += 6;
            Default.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 7;
            else
                if (Convert.ToInt32(s) == 0)
                    s = 7.ToString();
                else
                    s += 7;
            Default.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 8;
            else
                if (Convert.ToInt32(s) == 0)
                                s = 8.ToString();
                else
                    s += 8;
            Default.Text = s;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (s == "")
                s += 9;
            else
                if (Convert.ToInt32(s) == 0)
                                s = 9.ToString();
                else
                    s += 9;
            Default.Text = s;
        }
        string dau = "";
        int ans = 0;
        bool check = false;
        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == true)
                {
                    if (dau == "+")
                        ans += Convert.ToInt32(Default.Text);
                    else if (dau == "-")
                        ans -= Convert.ToInt32(Default.Text);
                    else if (dau == "*")
                        ans *= Convert.ToInt32(Default.Text);
                    else if (dau == "/")
                        ans /= Convert.ToInt32(Default.Text);
                }
                else
                    ans = Convert.ToInt32(Default.Text);
                s = "";
                dau = "+";
                check = true;
            }
            catch
            {
                return;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == true)
                {
                    if (dau == "+")
                        ans += Convert.ToInt32(Default.Text);
                    else if (dau == "-")
                        ans -= Convert.ToInt32(Default.Text);
                    else if (dau == "*")
                        ans *= Convert.ToInt32(Default.Text);
                    else if (dau == "/")
                        ans /= Convert.ToInt32(Default.Text);
                }
                else
                    ans = Convert.ToInt32(Default.Text);
                s = "";
                dau = "-";
                check = true;
            }
            catch
            {
                return;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == true)
                {
                    if (dau == "+")
                        ans += Convert.ToInt32(Default.Text);
                    else if (dau == "-")
                        ans -= Convert.ToInt32(Default.Text);
                    else if (dau == "*")
                        ans *= Convert.ToInt32(Default.Text);
                    else if (dau == "/")
                        ans /= Convert.ToInt32(Default.Text);
                }
                else
                    ans = Convert.ToInt32(Default.Text);
                s = "";
                dau = "*";
                check = true;
            }
            catch
            {
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == true)
                {
                    if (dau == "+")
                        ans += Convert.ToInt32(Default.Text);
                    else if (dau == "-")
                        ans -= Convert.ToInt32(Default.Text);
                    else if (dau == "*")
                        ans *= Convert.ToInt32(Default.Text);
                    else if (dau == "/")
                        ans /= Convert.ToInt32(Default.Text);
                }
                else
                    ans = Convert.ToInt32(Default.Text);
                s = "";
                dau = "/";
                check = true;
            }
            catch
            {
                return;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                if (Default.Text == "+" || Default.Text == "-" || Default.Text == "*" || Default.Text == "/")
                    return;
                if (Default.Text == "0.")
                    return;
                if (dau == "")
                    ans = Convert.ToInt32(Default.Text);
                if (dau == "+")
                    ans += Convert.ToInt32(Default.Text);
                else if (dau == "-")
                    ans -= Convert.ToInt32(Default.Text);
                else if (dau == "*")
                    ans *= Convert.ToInt32(Default.Text);
                else if (dau == "/")
                    ans /= Convert.ToInt32(Default.Text);
            }
            catch
            {
                MessageBox.Show("Sai cach nhap");
            }
            Default.Text = ans.ToString();
            s = "";
            dau = "";
            check = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Default.Text = "0.";
            ans = 0;
            s = "";
            dau = "";
            check = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Default.Text = "0.";
            s = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s == "")
                return;
            s = (Convert.ToInt32(Default.Text) / 10).ToString();
            Default.Text = s;
        }
    }
}
