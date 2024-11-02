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
    public partial class Form10 : Form
    {
        
        PictureBox pb = new PictureBox();
        Timer tmGame = new Timer();
        int xBall = 0;
        int yBall = 0;
        int xDeltal = 5;
        int yDeltal = 5;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            tmGame.Interval = 10;
            tmGame.Tick += TmGame_Tick;
            tmGame.Start();
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Location = new Point(xBall, yBall);
            pb.Size = new Size(100, 100);
            this.Controls.Add(pb);
            pb.ImageLocation = @"D:\bong.jpg";

        }

        private void TmGame_Tick(object sender, EventArgs e)
        {
            xBall += xDeltal;
            yBall += yDeltal;
            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
                xDeltal = -xDeltal;
            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
                yDeltal = -yDeltal;
            pb.Location = new Point(xBall, yBall);

        }
    }
}
