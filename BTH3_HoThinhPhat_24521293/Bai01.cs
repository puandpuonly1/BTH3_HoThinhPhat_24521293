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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Activated(object sender, EventArgs e)
        {
            Label.Text += "Bai01 activated\n";
        }

        private void Bai01_Load(object sender, EventArgs e)
        {
            Label.Text += "Bai01 load\n";
        }

        private void Bai01_Shown(object sender, EventArgs e)
        {
            Label.Text += "Bai01 shown\n";
        }

        private void MoButton_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Label.Text += "Mở thêm form con\n";
            f.Show();
        }

        private void DongButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bai01_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chắc chắn không?", "Tắt form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
