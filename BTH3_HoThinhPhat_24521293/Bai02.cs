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
    public partial class Bai02 : Form
    {
        private int x, y;
        Random rd = new Random();
        private Color color;
        private SizeF textsize;
        private float xRatio, yRatio;
        public Bai02()
        {
            InitializeComponent();
            textsize = new SizeF(200, 100);
            UpdatePos();
            UpdateClr();

        }
        private void UpdatePos()
        {
            x = rd.Next(this.ClientSize.Width - (int)textsize.Width);
            y = rd.Next(this.ClientSize.Height - (int)textsize.Height);
            xRatio = (float)x / this.ClientSize.Width;
            yRatio = (float)y / this.ClientSize.Height;
        }

        private void PaintButton_Click(object sender, EventArgs e)
        {
            UpdatePos();
            UpdateClr();
            this.Invalidate();
        }

        private void Bai02_Resize(object sender, EventArgs e)
        {
            x = (int)(this.ClientSize.Width * xRatio);
            y = (int)(this.ClientSize.Height * yRatio);
            this.Invalidate();
        }

        private void UpdateClr()
        {
            color = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Times New Roman", 30);
            Brush brush = new SolidBrush(color);
            textsize = g.MeasureString("24521293", font);
            g.DrawString("24521293", font, brush, new Point(x, y));
        }
    }
}
