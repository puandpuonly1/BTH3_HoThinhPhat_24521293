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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ThemCapnhatButton_Click(object sender, EventArgs e)
        {
            ListViewItem l = new ListViewItem((listView1.Items.Count + 1).ToString());
            if (STKTextBox.Text.Length == 0 || TKHTextBox.Text.Length == 0 || DCKHTextBox.Text.Length == 0 || STTTKTextBox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            for (int i = 0; i < listView1.Items.Count; i++)
                    if (STKTextBox.Text == listView1.Items[i].SubItems[1].Text)
                    {
                        listView1.Items[i].SubItems[2].Text = TKHTextBox.Text;
                        listView1.Items[i].SubItems[3].Text = DCKHTextBox.Text;
                        listView1.Items[i].SubItems[4].Text = STTTKTextBox.Text;
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                        return;
                    }
            l.SubItems.Add(STKTextBox.Text);
            l.SubItems.Add(TKHTextBox.Text);
            l.SubItems.Add(DCKHTextBox.Text);
            l.SubItems.Add(STTTKTextBox.Text);
            listView1.Items.Add(l);
            MessageBox.Show("Thêm mới dữ liệu thành công!");
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            if (STKTextBox.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập số tài khoản");
                return;
            }
            for (int i = 0; i < listView1.Items.Count; i++)
                if (STKTextBox.Text == listView1.Items[i].SubItems[1].Text)
                {
                    DialogResult result = MessageBox.Show("Chắc chắn chưa?", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        listView1.Items[i].Remove();
                        MessageBox.Show("Xóa tài khoản thành công");
                        return;
                    }
                    else
                        return;
                }
            MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                STKTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                TKHTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                DCKHTextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
                STTTKTextBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
