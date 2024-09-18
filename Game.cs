using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Game : MaterialForm
    {

        private bool turn = true;
        private bool isSinglePlayer = true;
        private bool isEasy = true;

        public Game()
        {
            InitializeComponent();
        }

        private void SetButton(Button button)
        {
            if (string.IsNullOrEmpty(button.Text))
            {
                if (turn)
                {
                    button.Text = "X";
                    turn = false;
                }
                else
                {
                    button.Text = "O";
                    turn = true;
                }

                button.BackColor = Color.LightGray;
                button.ForeColor = Color.Black;

                CheckWinner();

                if (isSinglePlayer && !turn)
                {
                    ComputerPlay();
                }
            }
        }

        private void ComputerPlay()
        {
            if (!radioButtonHard.Checked)
            {
                Random rnd = new Random();
                Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
                Button randomButton = buttons.Where(b => string.IsNullOrEmpty(b.Text)).OrderBy(x => rnd.Next()).FirstOrDefault();

                if (randomButton != null)
                {
                    randomButton.Text = "O";
                    randomButton.BackColor = Color.LightGray;
                    randomButton.ForeColor = Color.Black;
                    turn = true;
                    CheckWinner();
                }
            }
            else
            {
                Button bestMove = GetBestMove();
                if (bestMove != null)
                {
                    bestMove.Text = "O";
                    bestMove.BackColor = Color.LightGray;
                    bestMove.ForeColor = Color.Black;
                    turn = true;
                    CheckWinner();
                }
            }
        }

        #region Minimax Algorithm

        private Button GetBestMove()
        {
            Button bestMove = null;
            int bestValue = int.MinValue;

            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button button in buttons.Where(b => string.IsNullOrEmpty(b.Text)))
            {
                button.Text = "O";
                int moveValue = Minimax(buttons, false);
                button.Text = "";

                if (moveValue > bestValue)
                {
                    bestValue = moveValue;
                    bestMove = button;
                }
            }

            return bestMove;
        }

        private int Minimax(Button[] buttons, bool isMaximizing)
        {
            if (CheckWinner("O"))
                return 10;
            if (CheckWinner("X"))
                return -10;
            if (AllButtonsClicked())
                return 0;

            int bestValue = isMaximizing ? int.MinValue : int.MaxValue;

            foreach (Button button in buttons.Where(b => string.IsNullOrEmpty(b.Text)))
            {
                button.Text = isMaximizing ? "O" : "X";
                int moveValue = Minimax(buttons, !isMaximizing);
                button.Text = "";

                if (isMaximizing)
                    bestValue = Math.Max(bestValue, moveValue);
                else
                    bestValue = Math.Min(bestValue, moveValue);
            }

            return bestValue;
        }

        private bool CheckWinner(string player)
        {
            return (button1.Text == player && button2.Text == player && button3.Text == player) ||
                   (button4.Text == player && button5.Text == player && button6.Text == player) ||
                   (button7.Text == player && button8.Text == player && button9.Text == player) ||
                   (button1.Text == player && button4.Text == player && button7.Text == player) ||
                   (button2.Text == player && button5.Text == player && button8.Text == player) ||
                   (button3.Text == player && button6.Text == player && button9.Text == player) ||
                   (button1.Text == player && button5.Text == player && button9.Text == player) ||
                   (button3.Text == player && button5.Text == player && button7.Text == player);
        }

        #endregion

        private void CheckWinner()
        {
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != ""))
            {
                DeclareWinner();
                return;
            }

            if ((button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != ""))
            {
                DeclareWinner();
                return;
            }

            if ((button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))
            {
                DeclareWinner();
                return;
            }

            if (AllButtonsClicked())
            {
                MessageBox.Show("Empate!");
                ResetGame();
            }
        }

        private void DeclareWinner()
        {
            string winner = turn ? "O" : "X";
            MessageBox.Show(winner + " venceu o jogo!");
            ResetGame();
        }

        private bool AllButtonsClicked()
        {
            return button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                   button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                   button7.Text != "" && button8.Text != "" && button9.Text != "";
        }

        private void Game_Load(object sender, EventArgs e)
        {
            radioButtonSolo.Checked = true;
            radioButtonEasy.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetButton(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetButton(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetButton(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetButton(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetButton(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetButton(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetButton(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetButton(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetButton(button9);
        }

        private void ResetGame()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button && button.Name.StartsWith("button"))
                {
                    button.Text = "";
                    button.BackColor = SystemColors.Control;
                    button.ForeColor = SystemColors.ControlText;
                }
            }

            turn = true;
        }

        private void radioButtonSolo_CheckedChanged(object sender, EventArgs e)
        {
            isSinglePlayer = radioButtonSolo.Checked;

            radioButtonEasy.Enabled = isSinglePlayer;
            radioButtonHard.Enabled = isSinglePlayer;

            ResetGame();
        }

        private void radioButtonMulti_CheckedChanged(object sender, EventArgs e)
        {
            isSinglePlayer = !radioButtonMulti.Checked;

            radioButtonEasy.Enabled = isSinglePlayer;
            radioButtonHard.Enabled = isSinglePlayer;

            ResetGame();
        }

        private void radioButtonEasy_CheckedChanged(object sender, EventArgs e)
        {
            isEasy = radioButtonEasy.Checked;
            isEasy = true;

            ResetGame();
        }

        private void radioButtonHard_CheckedChanged(object sender, EventArgs e)
        {
            isEasy = !radioButtonHard.Checked;
            isEasy = false;

            ResetGame();
        }
    }
}
