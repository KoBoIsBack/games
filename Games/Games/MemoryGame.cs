using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Games
{
    public partial class MemoryGame : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };
        PictureBox[] pictureBoxs;

        public MemoryGame()
        {
            InitializeComponent();
            pictureBoxs = Controls.OfType<PictureBox>().ToArray();
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Game.Properties.Resources.cat1,
                    Game.Properties.Resources.cat2,
                    Game.Properties.Resources.cat3,
                    Game.Properties.Resources.cat4,
                    Game.Properties.Resources.cat5,
                    Game.Properties.Resources.cat6,
                    Game.Properties.Resources.cat7,
                    Game.Properties.Resources.cat8
                };
            }
        }

        private void startGameTimer()
        {
            timer.Start();
            timer.Elapsed += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Out of time");
                    ResetImages();
                }

                var ssTime = TimeSpan.FromSeconds(time);

                label1.Invoke((MethodInvoker)(() =>
                {
                    label1.Text = $"{time / 60:00}:{time % 60:00}";
                }));


            };
        }

        private void ResetImages()
        {
            foreach (var pic in pictureBoxs)
            {
                pic.Tag = null;
                pic.Visible = true;
            }

            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }

        private void HideImages()
        {
            foreach (var pic in pictureBoxs)
            {
                pic.Image = Game.Properties.Resources.question;
            }
        }
        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxs.Count());
            }
            while (pictureBoxs[num].Tag != null);
            return pictureBoxs[num];
        }
        private void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();

            allowClick = true;
            clickTimer.Stop();
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;

            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            pic.Image = (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }

            firstGuess = null;
            if (pictureBoxs.Any(p => p.Visible)) return;
            MessageBox.Show("You Win Now Try Again");
            ResetImages();
        }

        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Elapsed += CLICKTIMER_TICK;
            buttonStart.Enabled = false;
        }
    }
}
