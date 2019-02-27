using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        public void NewGame()
        {
            button00.Text = ""; button01.Text = ""; button02.Text = "";
            button10.Text = ""; button11.Text = ""; button12.Text = "";
            button20.Text = ""; button21.Text = ""; button22.Text = "";
            button00.Enabled = button01.Enabled = button02.Enabled = button10.Enabled = button11.Enabled
            = button12.Enabled = button20.Enabled = button21.Enabled = button22.Enabled = true;
            turns = 0;
            

        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            Xwin.Text = "X: " + s1;
            Owin.Text = "O: " + s2;
            Drow.Text = "Drow: " + sd;
        }

        private void NGbutton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        bool CheckDraw()
        {
            if (turns == 9)
            {

                return true;
                
            }
            else
            {
                return false;
            }
            
        }
        bool CheckWinner()
        {
            if ((button00.Text == button01.Text) && (button01.Text == button02.Text) && (button00.Text != ""))
            {
                return true;
            }
            else if ((button10.Text == button11.Text) && (button11.Text == button12.Text) && (button10.Text != ""))
            {
                return true;
            }
            else if ((button20.Text == button21.Text) && (button21.Text == button22.Text) && (button20.Text != ""))
            {
                return true;
            }
            else if ((button00.Text == button10.Text) && (button10.Text == button20.Text) && (button00.Text != ""))
            {
                return true;
            }
            else if ((button01.Text == button11.Text) && (button11.Text == button21.Text) && (button01.Text != ""))
            {
                return true;
            }
            else if ((button02.Text == button12.Text) && (button12.Text == button22.Text) && (button02.Text != ""))
            {
                return true;
            }
            else if ((button00.Text == button11.Text) && (button11.Text == button22.Text) && (button00.Text != ""))
            {
                return true;
            }
            else if ((button02.Text == button11.Text) && (button11.Text == button20.Text) && (button02.Text != ""))
            {
                return true;
            }
            else
                return false;
        }

        private void button00_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);


        }

        private void button01_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);

        }

        private void button02_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
            button.Enabled = false;
            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show(") Won!");
                    s2++;
                    NewGame();
                }
            }
            Form1_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1 = 0;
            s2 = 0;
            sd = 0;
            turns = 0;
            Form1_Load(null, null);
        }
    }
}