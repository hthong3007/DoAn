using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWD
{
    public partial class Form8 : Form
    {
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10;
            pb.Location = new Point(x, y);
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100 , 100);
            pb.Location = new Point(x , y);
            this.Controls.Add(pb);
            pb.ImageLocation = @"D:\abc.jpg";
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10;
            pb.Location = new Point(x ,y);
        }
    }
}
