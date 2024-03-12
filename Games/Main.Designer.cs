namespace Games
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Game.Properties.Resources.memorygame;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(11, 100);
            button1.Name = "button1";
            button1.Size = new Size(250, 250);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += MemoryGameBtn_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Game.Properties.Resources.snakegame;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(267, 100);
            button2.Name = "button2";
            button2.Size = new Size(250, 250);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += SnakeGameBtn_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Game.Properties.Resources.tictactoe;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(523, 100);
            button3.Name = "button3";
            button3.Size = new Size(250, 250);
            button3.TabIndex = 2;
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += TicTacToeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(202, 23);
            label1.Name = "label1";
            label1.Size = new Size(354, 74);
            label1.TabIndex = 3;
            label1.Text = "Select Game";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 364);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Main";
            Text = "Games";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}