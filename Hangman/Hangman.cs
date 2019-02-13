using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        CWordMgr wordMgr;
        static bool isRun;

        public Hangman()
        {
            InitializeComponent();
            wordMgr = new CWordMgr();
            Makehangman();
            MyInitializing();
        }
        void MyInitializing()
        {
            lblMsg.Text = "Welcome to the Hangman Game \\nPress <Start Game> to play the game.";
            lblWord.Text = "The word is:";
            label2.Text = "Guess a letter >>";
            btnStart.Text = "&Start Game";
            lblIncorrect.Text = "Incorrect Gueses:  ";
            lblIncorrect.Visible = false;
            txtLetter.Enabled = false;
            isRun = false;
            
            txtHnagman.Text = hangmanList[7];
        }

        List<string> hangmanList = new List<string>();

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRun)
            {
                txtLetter.Enabled = true;
                lblMsg.Text = "";
                lblIncorrect.Visible = true;

                DisplayWord(wordMgr.GetWord());
                btnStart.Text = "Submit";
                txtLetter.Focus();
                isRun = true;
            }
            else
            {
                char[] res = wordMgr.CheckLetter(txtLetter.Text[0]);
                if (res != null)
                {
                    DisplayWord(res);
                    bool complete = true;
                    for (int i = 0; i < res.Length; i++)
                    {
                        if (res[i] == '*') complete = false;
                    }
                    if (complete)
                    {
                        isRun = false;
                        MessageBox.Show("Congratulations");
                        MyInitializing();
                    }
                }
                else
                {
                    int k = wordMgr.getMissCount();
                    lblIncorrect.Text += txtLetter.Text[0] + " ";

                    txtHnagman.Text = hangmanList[k];
                    lblMsg.Text = "There is no '" + txtLetter.Text[0] + "' in the word";
                    lblMsg.Visible = true;


                    if (k >= 7)
                    {
                        isRun = false;
                        MessageBox.Show("Failure");
                        MyInitializing();
                    }
                }
                txtLetter.Text = "";
                txtLetter.Focus();
            }
        }

        private bool DisplayWord(char[] word)
        {
            bool res;            
            lblWord.Text = "The word is  ";
            try {
                for (int i = 0; i < word.Length; i++)
                {
                    lblWord.Text += word[i] + " ";
                }
                res = true;
            }
            catch
            {
                res = false;
            }
            return res;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void txtLetter_KeyDown(object sender, KeyEventArgs e)
        {
            txtLetter.Text = "";
        }

        void Makehangman()
        {
            hangmanList.Clear();

            string hang;
            hang = "";
            hangmanList.Add(hang);
            #region Draw hangman

            hang = @"  
   
   
   
   
   
  
  
__|__";
            hangmanList.Add(hang);

            hang = @"  
    |   
    |   
    |   
    |   
    |   
    |
    |
__|__";
            hangmanList.Add(hang);


            hang = @"  _______
    |      |
    |   
    |   
    |   
    |   
    |
    |
__|__";
            hangmanList.Add(hang);

            hang = @"  _______
    |      |
    |     O
    |  
    |  
    |  
    |
    |
__|__";
            hangmanList.Add(hang);

            hang = @"  _______
    |      |
    |     O
    |    /|\
    |   
    |   
    |
    |
__|__";
            hangmanList.Add(hang);

            hang = @"  _______
    |      |
    |     O
    |    /|\
    |      |
    |   
    |
    |
__|__";
            hangmanList.Add(hang);

            hang = @"  _______
    |      |
    |     O
    |    /|\
    |      |
    |    / \
    |
    |
__|__";
            hangmanList.Add(hang);
            #endregion
        }
    }
}