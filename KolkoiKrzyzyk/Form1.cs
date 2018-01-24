using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoiKrzyzyk
{
    public partial class Form1 : Form
    {

        bool turn = true; //true=X, false=0
        int count=0;

        private void Mbox()
        {
            if (MessageBox.Show("Czy chcesz zagrać jeszcze raz?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                ng();
            }
        }

        private void ng()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                turn = true;
                count = 0;
                button.Enabled = true;
                button.Text = "";
                PlayerName.Text = "PLAYER X";
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by jimmii\n");
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is Tic Tac Toe\n HAVE FUN!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
           

            Button b = (Button)sender;
            if (turn == true)
            {
                b.Text = "X";
                PlayerName.Text = "PLAYER O";
            }

            else
            {
                b.Text = "0";
                PlayerName.Text = "PLAYER X";
            }
            turn = !turn;

            b.Enabled = false;//blokada buttonow    

            //rozgrywka

            winner();


            count++;

            //nowa gra || koniec
            if(count==9)
            {
                PlayerName.Text = "Remis";
                Mbox();//messagebox YN
                
            }
            
        }

        private void winner()
        {
            bool win = false;
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text)&&!button1.Enabled)
                win = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text)&&!button4.Enabled)
                win = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text)&&!button7.Enabled)
                win = true;
           else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && !button1.Enabled)
                win = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && !button2.Enabled)
                win = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && !button3.Enabled)
                win = true;
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && !button1.Enabled)
                win = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && !button3.Enabled)
                win = true;


            if (win==true)
            {
                PlayerName.Text = "Zwycięstwo!";
                Mbox();
            }
            

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe Game");
        }

       

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ng();
           
           
        }
    }
}
