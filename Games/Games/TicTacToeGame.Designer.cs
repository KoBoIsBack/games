using System;
using System.Windows.Forms;

namespace TicTacToe
{
    partial class TicTacToeGame
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            round_no = new Label();
            score_O = new Label();
            score_X = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.Cursor = Cursors.Cross;
            btn1.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(17, 15);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 85);
            btn1.TabIndex = 0;
            btn1.TabStop = false;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.Cursor = Cursors.Cross;
            btn2.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.ButtonFace;
            btn2.Location = new Point(110, 15);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 85);
            btn2.TabIndex = 1;
            btn2.TabStop = false;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.Cursor = Cursors.Cross;
            btn3.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.ButtonFace;
            btn3.Location = new Point(203, 15);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(85, 85);
            btn3.TabIndex = 2;
            btn3.TabStop = false;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.Cursor = Cursors.Cross;
            btn4.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.ButtonFace;
            btn4.Location = new Point(17, 108);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(85, 85);
            btn4.TabIndex = 3;
            btn4.TabStop = false;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.Cursor = Cursors.Cross;
            btn5.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.ButtonFace;
            btn5.Location = new Point(111, 108);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(85, 85);
            btn5.TabIndex = 4;
            btn5.TabStop = false;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.Cursor = Cursors.Cross;
            btn6.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.ButtonFace;
            btn6.Location = new Point(204, 108);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(85, 85);
            btn6.TabIndex = 5;
            btn6.TabStop = false;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.Cursor = Cursors.Cross;
            btn7.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.ButtonFace;
            btn7.Location = new Point(17, 201);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(85, 85);
            btn7.TabIndex = 6;
            btn7.TabStop = false;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.Cursor = Cursors.Cross;
            btn8.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.ButtonFace;
            btn8.Location = new Point(110, 201);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(85, 85);
            btn8.TabIndex = 7;
            btn8.TabStop = false;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.Cursor = Cursors.Cross;
            btn9.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(204, 201);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(85, 85);
            btn9.TabIndex = 8;
            btn9.TabStop = false;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(321, 141);
            label2.Name = "label2";
            label2.Size = new Size(53, 56);
            label2.TabIndex = 12;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(388, 141);
            label3.Name = "label3";
            label3.Size = new Size(60, 56);
            label3.TabIndex = 13;
            label3.Text = "O";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(300, 15);
            label4.Name = "label4";
            label4.Size = new Size(176, 46);
            label4.TabIndex = 16;
            label4.Text = "ROUND :";
            // 
            // round_no
            // 
            round_no.AutoSize = true;
            round_no.BackColor = Color.Transparent;
            round_no.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            round_no.ForeColor = Color.White;
            round_no.Location = new Point(418, 15);
            round_no.Name = "round_no";
            round_no.Size = new Size(41, 46);
            round_no.TabIndex = 17;
            round_no.Text = "1";
            // 
            // score_O
            // 
            score_O.AutoSize = true;
            score_O.BackColor = Color.Transparent;
            score_O.Font = new Font("Microsoft JhengHei", 29.25F, FontStyle.Bold, GraphicsUnit.Point);
            score_O.ForeColor = Color.White;
            score_O.Location = new Point(386, 201);
            score_O.Name = "score_O";
            score_O.Size = new Size(67, 75);
            score_O.TabIndex = 18;
            score_O.Text = "0";
            // 
            // score_X
            // 
            score_X.AutoSize = true;
            score_X.BackColor = Color.Transparent;
            score_X.Font = new Font("Microsoft JhengHei", 29.25F, FontStyle.Bold, GraphicsUnit.Point);
            score_X.ForeColor = Color.White;
            score_X.Location = new Point(313, 201);
            score_X.Name = "score_X";
            score_X.Size = new Size(67, 75);
            score_X.TabIndex = 19;
            score_X.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(305, 91);
            label1.Name = "label1";
            label1.Size = new Size(154, 50);
            label1.TabIndex = 22;
            label1.Text = "SCORE";
            // 
            // TicTacToeGame
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Indigo;
            ClientSize = new Size(494, 310);
            Controls.Add(label1);
            Controls.Add(score_X);
            Controls.Add(score_O);
            Controls.Add(round_no);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            DoubleBuffered = true;
            Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "TicTacToeGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TIC TAC TOE";
            TransparencyKey = SystemColors.Control;
            Load += TicTacToe_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label round_no;
        private Label score_O;
        private Label score_X;
        private Label label1;
    }
}
