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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void bài01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            bai01.MdiParent = this;
            bai01.Show();
        }

        private void bài02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai02 bai02 = new Bai02();
            bai02.MdiParent = this;
            bai02.Show();
        }

        private void bài03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai03 bai03 = new Bai03();
            bai03.MdiParent = this;
            bai03.Show();
        }
        private void bài04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai04 bai04 = new Bai04();
            bai04.MdiParent = this;
            bai04.Show();
        }

        private void bài05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai05 bai05 = new Bai05();
            bai05.MdiParent = this;
            bai05.Show();
        }

        private void bài06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai06 bai06 = new Bai06();
            bai06.MdiParent = this;
            bai06.Show();
        }

        private void bài07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai07 bai07 = new Bai07();
            bai07.MdiParent = this;
            bai07.Show();
        }

        private void bài08ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai08 bai08 = new Bai08();
            bai08.MdiParent = this;
            bai08.Show();
        }

        private void bài09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai09 bai09 = new Bai09();
            bai09.MdiParent = this;
            bai09.Show();
        }
    }
}
