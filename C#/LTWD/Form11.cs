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
    public partial class Form11 : Form
    {
        PictureBox pbEgg = new PictureBox();
        Timer tmEgg = new Timer();
        int xEgg = 300;
        int yEgg = 0;
        int xDelta = 3;
        int yDelta = 3;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_tick;
            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            pbEgg.Image = Image.FromFile("../../Images/trung1.png");
        }
        private void tmEgg_tick(object sender, EventArgs e)
        {
            yEgg += yDelta;
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
                pbEgg.Image = Image.FromFile("../../Images/trung2.png");
            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}
