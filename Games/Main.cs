using Classic_Snakes_Game;
using TicTacToe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MemoryGameBtn_Click(object sender, EventArgs e)
        {
            // Open the game form
            MemoryGame game = new MemoryGame();
            game.Show();
            // Hide the main form
            this.Hide();
        }

        private void SnakeGameBtn_Click(object sender, EventArgs e)
        {
            // Open snake game
            SnakeGame snake = new SnakeGame();
            snake.Show();
            // Hide the main form
            this.Hide();
        }

        private void TicTacToeBtn_Click(object sender, EventArgs e)
        {
            // Open tic tac toe game
            TicTacToeGame tiktoe = new TicTacToeGame();
            tiktoe.Show();
            // Hide the main form
            this.Hide();
        }
    }
}
