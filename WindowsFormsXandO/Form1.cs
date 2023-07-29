using AI2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsXandO
{
    public partial class TicTacToe : Form
    {
        List<Button> buttons = new List<Button>();
        string[] gameBoard = new string[9];
        Controller c = new Controller();

        public TicTacToe()
        {
            InitializeComponent();
            InitializeComboboxes();
            InitialeButtons();
            InitBoard();
            label3.Text = " ";
            button10.Text = "Start new game";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        public void InitBoard()
        {
            c.mySeed = "o";
            c.oppSeed = "x";
            for (int i = 0; i < 9; i++)
            {
                c.gameBoard[i] = " ";
            }
        }


        public void MakeMove(int position)
        {
            if (comboBox2.SelectedItem.ToString() == "MiniMax")
            {
                DoMiniMaxJob(position);
            }
            else if (comboBox2.SelectedItem.ToString() == "Alpha-Beta")
            {
                DoAlphaBetaJob(position);
            }

        }

        public void DoAlphaBetaJob(int position)
        {

            if (comboBox1.SelectedItem.ToString() == "Computer starts")
            {
                c.gameBoard[position] = c.oppSeed;
                int opp = c.AlphaBeta(c.mySeed, 8, int.MinValue, int.MaxValue)[1];
                c.gameBoard[opp] = c.mySeed;
                buttons.ElementAt(opp).Text = "0";
                buttons.ElementAt(opp).Enabled = false;
                if ((!c.HasWon(c.mySeed) && !c.HasWon(c.oppSeed)) && !c.areSomeSpacesLeft())
                {
                    label3.Text = "Draw";
                    DisableAllButtons();
                }

                else
                {
                    if (c.HasWon(c.mySeed))
                    {
                        label3.Text = "Computer has won";
                        DisableAllButtons();
                    }
                    else if (c.HasWon(c.oppSeed))
                    {
                        label3.Text = "Human has won";
                        DisableAllButtons();
                    }

                }

            }
            else
            {

                c.gameBoard[position] = c.mySeed;
                if ((!c.HasWon(c.mySeed) && !c.HasWon(c.oppSeed)) && c.areSomeSpacesLeft())
                {
                    int opp = c.AlphaBeta(c.oppSeed, 8, int.MinValue, int.MaxValue)[1];
                    c.gameBoard[opp] = c.oppSeed;
                    buttons.ElementAt(opp).Text = "0";
                    buttons.ElementAt(opp).Enabled = false;
                    if (c.HasWon(c.mySeed))
                    {
                        label3.Text = "Human has won";
                        DisableAllButtons();
                    }
                    else if (c.HasWon(c.oppSeed))
                    {
                        label3.Text = "Computer has won";
                        DisableAllButtons();
                    }
                }
                else if ((!c.HasWon(c.mySeed) && !c.HasWon(c.oppSeed)) && !c.areSomeSpacesLeft())
                {
                    label3.Text = "Draw";
                    DisableAllButtons();
                }
                else
                {
                    if (c.HasWon(c.mySeed))
                    {
                        label3.Text = "Human has won";
                        DisableAllButtons();
                    }

                    else if (c.HasWon(c.oppSeed))
                    {
                        label3.Text = "Computer has won";
                        DisableAllButtons();
                    }

                }
            }
        }
        public void DoMiniMaxJob(int position)
        {
            if (comboBox1.SelectedItem.ToString() == "Computer starts")
            {
                c.gameBoard[position] = c.oppSeed;
                int opp = c.MiniMax(c.mySeed, 8)[1];
                c.gameBoard[opp] = c.mySeed;
                buttons.ElementAt(opp).Text = "0";
                buttons.ElementAt(opp).Enabled = false;
                if ((!c.HasWon(c.mySeed) && !c.HasWon(c.oppSeed)) && !c.areSomeSpacesLeft())
                {
                    label3.Text = "Draw";
                    DisableAllButtons();
                }

                else
                {
                    if (c.HasWon(c.mySeed))
                    {
                        label3.Text = "Computer has won";
                        DisableAllButtons();
                    }
                    else if (c.HasWon(c.oppSeed))
                    {
                        label3.Text = "Human has won";
                        DisableAllButtons();
                    }
                }

            }
            else
            {

                c.gameBoard[position] = c.mySeed;
                if ((!c.HasWon(c.mySeed) && !c.HasWon(c.oppSeed)) && c.areSomeSpacesLeft())
                {
                    int opp = c.MiniMax(c.oppSeed, 8)[1];
                    c.gameBoard[opp] = c.oppSeed;
                    buttons.ElementAt(opp).Text = "0";
                    buttons.ElementAt(opp).Enabled = false;
                    if (c.HasWon(c.mySeed))
                    {
                        label3.Text = "Human has won";
                        DisableAllButtons();
                    }
                    else if (c.HasWon(c.oppSeed))
                    {
                        label3.Text = "Computer has won";
                        DisableAllButtons();
                    }
                }
                else if ((!c.HasWon(c.mySeed) && !c.HasWon(c.oppSeed)) && !c.areSomeSpacesLeft())
                {
                    label3.Text = "Draw";
                    DisableAllButtons();
                }
                else
                {
                    if (c.HasWon(c.mySeed))
                    {
                        label3.Text = "Computer has won";
                        DisableAllButtons();
                    }
                    else if (c.HasWon(c.oppSeed))
                    {
                        label3.Text = "Human has won";
                        DisableAllButtons();
                    }
                }
            }
        }
        public void InitialeButtons()
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);

            foreach (var x in buttons)
            {
                x.Text = " ";
            }
            HideButtons();

        }
        public void EnableAllButtons()
        {
            foreach (var x in buttons)
            {
                x.Enabled = true;
            }
        }
        public void DisableAllButtons()
        {
            foreach (var x in buttons)
            {
                x.Enabled = false;
            }
        }
        public void InitializeComboboxes()
        {
            comboBox1.Items.Add(new Item("Player starts", 0));
            comboBox1.Items.Add(new Item("Computer starts", 1));

            comboBox2.Items.Add(new Item("MiniMax", 0));
            comboBox2.Items.Add(new Item("Alpha-Beta", 1));
        }
        public void HideButtons()
        {
            foreach (var x in buttons)
            {
                x.Hide();
            }
        }
        public void ShowButtons()
        {
            foreach (var x in buttons)
            {
                x.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "Replay";
            label3.Text = " ";
            ShowButtons();
            EnableAllButtons();
            for (int i = 0; i < 9; i++)
            {
                c.gameBoard[i] = " ";
                buttons.ElementAt(i).Text = " ";
            }

            if (comboBox2.SelectedItem.ToString() == "MiniMax")
            {
                if (comboBox1.SelectedItem.ToString() == "Computer starts")
                {
                    int opp = c.MiniMax(c.mySeed, 8)[1];
                    c.gameBoard[opp] = c.mySeed;
                    buttons.ElementAt(opp).Text = "0";
                    buttons.ElementAt(opp).Enabled = false;
                }
                //if (comboBox1.SelectedItem.ToString() == "Computer starts")
                //c.gameBoard[Int32.Parse(input)] = c.mySeed;            //jei zaidejas pirmas
                //c.gameBoard[c.MiniMax(c.oppSeed, 8)[1]] = c.oppSeed;
            }
            else if (comboBox2.SelectedItem.ToString() == "Alpha-Beta")
            {
                if (comboBox1.SelectedItem.ToString() == "Computer starts")
                {
                    int opp = c.AlphaBeta(c.mySeed, 8, int.MinValue, int.MaxValue)[1];
                    c.gameBoard[opp] = c.mySeed;
                    buttons.ElementAt(opp).Text = "0";
                    buttons.ElementAt(opp).Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            gameBoard[0] = "x";
            MakeMove(0);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            gameBoard[1] = "x";
            MakeMove(1);
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            gameBoard[2] = "x";
            MakeMove(2);
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            gameBoard[3] = "x";
            MakeMove(3);
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            gameBoard[4] = "x";
            MakeMove(4);
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            gameBoard[5] = "x";
            MakeMove(5);
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            gameBoard[6] = "x";
            MakeMove(6);
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "X";
            gameBoard[7] = "x";
            MakeMove(7);
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            gameBoard[8] = "x";
            MakeMove(8);
            button9.Enabled = false;
        }
    }
    }

