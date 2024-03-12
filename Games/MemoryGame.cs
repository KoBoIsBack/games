using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Games
{
    public partial class MemoryGame : Form
    {
        bool allowClick = false;
        PictureBox? firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        Timer revealTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };
        PictureBox[] pictureBoxs;

        public MemoryGame()
        {
            InitializeComponent();
            pictureBoxs = Controls.OfType<PictureBox>().ToArray();
            revealTimer.Interval = 3000; // Show images for 5 seconds at the start
            revealTimer.Elapsed += revealTimer_Tick;
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

        private void StopGame()
        {
            timer.Stop();
            clickTimer.Stop();
            revealTimer.Stop();
            buttonStart.Enabled = true;
            allowClick = false;
        }

        private void ResetImages()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ResetImages));
                return;
            }

            foreach (var pic in pictureBoxs)
            {
                pic.Tag = null;
                pic.BorderStyle = BorderStyle.None;
                pic.BackColor = default(Color); // Reset color to default
                pic.Image = Game.Properties.Resources.question;
            }

            HideImages();
        }


        private void HideImages()
        {
            foreach (var pic in pictureBoxs)
            {
                // Check if the PictureBox is not part of a matched pair
                if (pic.BackColor != Color.LimeGreen)
                {
                    pic.Image = Game.Properties.Resources.question;
                }
            }
        }


        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxs.Length);
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
            if (firstGuess != null && firstGuess == sender) return;

            var pic = (PictureBox)sender;
            if (pic != null && pic.BorderStyle == BorderStyle.FixedSingle) return;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            pic.Image = (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                // Instead of making the PictureBoxes invisible, indicate a match by changing the border
                pic.BorderStyle = BorderStyle.FixedSingle;
                firstGuess.BorderStyle = BorderStyle.FixedSingle;
                pic.BackColor = Color.LimeGreen; // Indicate a match
                firstGuess.BackColor = Color.LimeGreen; // Indicate a match

                firstGuess = null;
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }

            firstGuess = null;
            if (pictureBoxs.Any(p => p.Visible && p.BorderStyle != BorderStyle.FixedSingle)) return;
            StopGame();
            MessageBox.Show("You Win! Now Try Again");
            ResetImages();
        }


        private void startGame(object sender, EventArgs e)
        {
            setRandomImages();
            foreach (var pic in pictureBoxs)
            {
                pic.Image = (Image)pic.Tag; // Reveal the image
            }

            time = 10; // Reset the timer
            allowClick = false; // Prevent interaction during memorization phase
            revealTimer.Start(); // Start the timer to hide the images after the interval

            clickTimer.Interval = 1000;
            clickTimer.Elapsed += CLICKTIMER_TICK;
            buttonStart.Enabled = false;
        }

        private void revealTimer_Tick(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            revealTimer.Stop();
            startGameTimer();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            timer.Stop();
            timer.Dispose();
            clickTimer.Stop();
            clickTimer.Dispose();
            revealTimer.Stop();
            revealTimer.Dispose();

            // Show the main form
            new Main().Show();
            
        }


    }
}
