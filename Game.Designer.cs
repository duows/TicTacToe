namespace TicTacToe
{
    partial class Game
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
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            radioButtonSolo = new RadioButton();
            radioButtonMulti = new RadioButton();
            radioButtonEasy = new RadioButton();
            radioButtonHard = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button1.Location = new Point(35, 127);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button2.Location = new Point(141, 127);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button3.Location = new Point(247, 127);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button4.Location = new Point(35, 233);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button5.Location = new Point(141, 233);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button6.Location = new Point(247, 233);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button7.Location = new Point(35, 339);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button8.Location = new Point(141, 339);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            button9.Location = new Point(247, 339);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // radioButtonSolo
            // 
            radioButtonSolo.AutoSize = true;
            radioButtonSolo.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonSolo.Location = new Point(55, 22);
            radioButtonSolo.Name = "radioButtonSolo";
            radioButtonSolo.Size = new Size(121, 27);
            radioButtonSolo.TabIndex = 9;
            radioButtonSolo.TabStop = true;
            radioButtonSolo.Text = "Singleplayer";
            radioButtonSolo.UseVisualStyleBackColor = true;
            radioButtonSolo.CheckedChanged += radioButtonSolo_CheckedChanged;
            // 
            // radioButtonMulti
            // 
            radioButtonMulti.AutoSize = true;
            radioButtonMulti.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonMulti.Location = new Point(203, 22);
            radioButtonMulti.Name = "radioButtonMulti";
            radioButtonMulti.Size = new Size(114, 27);
            radioButtonMulti.TabIndex = 10;
            radioButtonMulti.TabStop = true;
            radioButtonMulti.Text = "Multiplayer";
            radioButtonMulti.UseVisualStyleBackColor = true;
            radioButtonMulti.CheckedChanged += radioButtonMulti_CheckedChanged;
            // 
            // radioButtonEasy
            // 
            radioButtonEasy.AutoSize = true;
            radioButtonEasy.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            radioButtonEasy.Location = new Point(32, 22);
            radioButtonEasy.Name = "radioButtonEasy";
            radioButtonEasy.Size = new Size(64, 27);
            radioButtonEasy.TabIndex = 11;
            radioButtonEasy.TabStop = true;
            radioButtonEasy.Text = "Easy";
            radioButtonEasy.UseVisualStyleBackColor = true;
            radioButtonEasy.CheckedChanged += radioButtonEasy_CheckedChanged;
            // 
            // radioButtonHard
            // 
            radioButtonHard.AutoSize = true;
            radioButtonHard.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonHard.Location = new Point(30, 55);
            radioButtonHard.Name = "radioButtonHard";
            radioButtonHard.Size = new Size(66, 27);
            radioButtonHard.TabIndex = 12;
            radioButtonHard.TabStop = true;
            radioButtonHard.Text = "Hard";
            radioButtonHard.UseVisualStyleBackColor = true;
            radioButtonHard.CheckedChanged += radioButtonHard_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonEasy);
            groupBox1.Controls.Add(radioButtonHard);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 460);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 100);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Difficulty";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonSolo);
            groupBox2.Controls.Add(radioButtonMulti);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 57);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "GameMode";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 563);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Game_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private RadioButton radioButtonSolo;
        private RadioButton radioButtonMulti;
        private RadioButton radioButtonEasy;
        private RadioButton radioButtonHard;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}