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
    public partial class Bai09 : Form
    {
        public Bai09()
        {
            InitializeComponent();
        }
        int STT = 0;
        private void LuuthongtinButton_Click(object sender, EventArgs e)
        {
            ListViewItem l = new ListViewItem((STT+1).ToString());
            if (MasinhvienTextBox.Text.Length == 0 || HotenTextBox.Text.Length == 0 || ChuyennganhComboBox.Text.Length == 0 || (NamCheckBox.Checked == false && NuCheckBox.Checked == false))
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin!");
                return;
            }
            for(int i = 0; i < LV.Items.Count; i++)
                if(MasinhvienTextBox.Text ==  LV.Items[i].SubItems[1].Text)
                {
                    LV.Items[i].SubItems[5].Text = (listBox2.Items.Count).ToString();
                    MessageBox.Show("Đã cập nhật thành công!");
                    return;
                }
            l.SubItems.Add(MasinhvienTextBox.Text);
            l.SubItems.Add(HotenTextBox.Text);
            l.SubItems.Add(ChuyennganhComboBox.Text);
            if (NamCheckBox.Checked)
                l.SubItems.Add("Nam");
            else
                l.SubItems.Add("Nu");
            l.SubItems.Add((listBox2.Items.Count).ToString());
            LV.Items.Add(l);
            STT++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object o in listBox1.SelectedItems)
                listBox2.Items.Add(o);
            foreach (object o in listBox2.Items)
                listBox1.Items.Remove(o);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object o in listBox2.SelectedItems)
                listBox1.Items.Add(o);
            foreach (object o in listBox1.Items)
                listBox2.Items.Remove(o);
        }

        private void NamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(NamCheckBox.Checked)
                NuCheckBox.Checked = false;
        }

        private void NuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(NuCheckBox.Checked)
                NamCheckBox.Checked = false;
        }

        private void XoachonButton_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
        }
    }
}
