using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace LTWD
{
    public partial class Form13 : Form
    {
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox();
        PictureBox pbBomb = new PictureBox();

        Timer tmEgg = new Timer();
        Timer tmChicken = new Timer();
        Timer tmBomb = new Timer();
        Timer tmGameTime = new Timer();

        int xBasket = 300;
        int yBasket = 550;
        int xDeltaBasket = 30;

        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 5;

        int xEgg;
        int yEgg = 10;
        int yDeltaEgg = 3;

        int xBomb;
        int yBomb = 10;
        int yDeltaBomb = 5;

        Random rand = new Random();

        bool isEggBroken = false;
        bool isDroppingBomb = false;

        int diem = 0;
        int thoigian = 60;
        int eggCount = 0;

        private int currentLevel = 1;
        private int targetScore = 1;
        private int bombCooldown = 0;
        private bool hasHitBomb = false;

        private string playerName;
        private int highScore = 0;
        private string highScorePlayer = "N/A";

        SoundPlayer backgroundMusic;

        public Form13()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            backgroundMusic = new SoundPlayer("../../Music/nennhac.wav");
            backgroundMusic.PlayLooping();
        }

        private void Form13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDeltaBasket;
            if (e.KeyCode == Keys.Left && xBasket > 0)
                xBasket -= xDeltaBasket;
            pbBasket.Location = new Point(xBasket, yBasket);
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            playerName = Prompt.ShowDialog("Nhập tên của bạn:", "Tên người chơi");
            if (string.IsNullOrEmpty(playerName))
            {
                playerName = "Người chơi";
            }

            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            tmChicken.Interval = 10;
            tmChicken.Tick += tmChicken_Tick;
            tmChicken.Start();

            tmBomb.Interval = 10;
            tmBomb.Tick += tmBomb_Tick;

            tmGameTime.Interval = 1000;
            tmGameTime.Tick += tmGameTime_Tick;
            tmGameTime.Start();

            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(70, 70);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            pbBasket.Image = Image.FromFile("../../Images/gio.png");

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50, 50);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            pbEgg.Image = Image.FromFile("../../Images/trung1.png");

            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(100, 100);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add(pbChicken);
            pbChicken.Image = Image.FromFile("../../Images/ga2.png");

            pbBomb.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBomb.Size = new Size(50, 50);
            pbBomb.BackColor = Color.Transparent;
            this.Controls.Add(pbBomb);
            pbBomb.Image = Image.FromFile("../../Images/bom.png");
            pbBomb.Visible = false;

            ResetGame();
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDeltaEgg;

            if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                pbEgg.Image = Image.FromFile("../../Images/trung2.png");
                tmEgg.Stop();

                if (MessageBox.Show("Bạn đã bỏ lỡ trứng! Trò chơi sẽ bắt đầu lại.", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    this.Close();
                }

                return;
            }

            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (!unionRect.IsEmpty)
            {
                diem++;
                lblDiem.Text = "" + diem;
                yEgg = 30;
                xEgg = pbChicken.Location.X + pbChicken.Width / 2 - pbEgg.Width / 2;
                pbEgg.Image = Image.FromFile("../../Images/trung1.png");
                eggCount++;

                if (diem >= targetScore)
                {
                    // Stop the timers and prompt the user
                    tmEgg.Stop();
                    tmChicken.Stop();

                    DialogResult result = MessageBox.Show("Chúc mừng! Bạn đã đạt " + diem + " điểm. Bạn có muốn chơi tiếp không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Reset for the next level
                        currentLevel++;
                        targetScore += 5; // Increase the target score for the next level

                        pbChicken.Size = new Size(pbChicken.Width + 50, pbChicken.Height + 50);
                        yDeltaEgg += 2;
                        ResetGame();
                    }
                    else
                    {
                        this.Close(); // Close the game
                    }

                    return;
                }

                if (eggCount >= 3 && bombCooldown == 0)
                {
                    eggCount = 0;
                    DropBomb();
                    bombCooldown = 30;
                }
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void tmChicken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
            {
                xDeltaChicken = -xDeltaChicken;
            }
            pbChicken.Location = new Point(xChicken, yChicken);
        }

        private void tmBomb_Tick(object sender, EventArgs e)
        {
            if (isDroppingBomb)
            {
                yBomb += yDeltaBomb;

                if (yBomb > this.ClientSize.Height - pbBomb.Height)
                {
                    yBomb = 10;
                    xBomb = rand.Next(0, this.ClientSize.Width - pbBomb.Width);
                    pbBomb.Location = new Point(xBomb, yBomb);
                }

                Rectangle unionRectBomb = Rectangle.Intersect(pbBomb.Bounds, pbBasket.Bounds);
                if (!unionRectBomb.IsEmpty && !hasHitBomb)
                {
                    hasHitBomb = true;
                    if (MessageBox.Show("Bạn đã hứng trúng bom! Bạn có muốn chơi lại?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ResetGame();
                    }
                    else
                    {
                        this.Close();
                    }
                    return;
                }

                pbBomb.Location = new Point(xBomb, yBomb);
            }
        }

        private void DropBomb()
        {
            isDroppingBomb = true;
            yBomb = 10;
            xBomb = rand.Next(0, this.ClientSize.Width - pbBomb.Width);
            pbBomb.Location = new Point(xBomb, yBomb);
            pbBomb.Visible = true;
            tmBomb.Start();
        }

        private void ResetGame()
        {
            switch (currentLevel)
            {
                case 1:
                    this.BackgroundImage = Image.FromFile("../../Images/nen.png");
                    break;
                case 2:
                    this.BackgroundImage = Image.FromFile("../../Images/nen1.jpg");
                    break;
                case 3:
                    this.BackgroundImage = Image.FromFile("../../Images/nen3.jpg");
                    break;
                default:
                    this.BackgroundImage = Image.FromFile("../../Images/nen4.png");
                    break;
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;

            xBasket = 300;
            yBasket = 550;
            pbBasket.Location = new Point(xBasket, yBasket);

            xChicken = 300;
            pbChicken.Location = new Point(xChicken, yChicken);

            yEgg = 10;
            xEgg = pbChicken.Location.X + pbChicken.Width / 2 - pbEgg.Width / 2;
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.Image = Image.FromFile("../../Images/trung1.png");

            pbBomb.Visible = false;
            isDroppingBomb = false;
            hasHitBomb = false;
            bombCooldown = 0;

            diem = 0;
            lblDiem.Text = "0";

            thoigian = 60;
            lblDisplay.Text = "60";

            tmEgg.Stop();
            tmChicken.Stop();
            tmBomb.Stop();
            tmGameTime.Stop();

            tmEgg.Start();
            tmChicken.Start();
            tmBomb.Start();
            tmGameTime.Start();
        }

        private void tmGameTime_Tick(object sender, EventArgs e)
        {
            thoigian--;
            lblDisplay.Text = thoigian.ToString();

            if (thoigian <= 0)
            {
                MessageBox.Show("Hết thời gian! Bạn đã đạt " + diem + " điểm.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetGame();
            }
        }

        private void Form13_FormClosed(object sender, FormClosedEventArgs e)
        {
            backgroundMusic.Stop();
            if (diem > highScore)
            {
                highScore = diem;
                highScorePlayer = playerName;
                System.IO.File.WriteAllText(@"D:\highscores.txt", $"{highScorePlayer}: {highScore}");
            }
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 250 };
            Button confirmation = new Button() { Text = "OK", Left = 200, Width = 70, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
