namespace Hangman
{
    partial class Hangman
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.txtHnagman = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(40, 54);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(354, 13);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Welcome to the Hangman Game \\nPress <Start Game> to play the game.";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(108, 158);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(65, 13);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "The word is:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guess a letter >>";
            // 
            // txtLetter
            // 
            this.txtLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetter.Enabled = false;
            this.txtLetter.Location = new System.Drawing.Point(205, 199);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(28, 20);
            this.txtLetter.TabIndex = 3;
            this.txtLetter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetter_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(80, 252);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "&Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(262, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(54, 110);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(97, 13);
            this.lblIncorrect.TabIndex = 6;
            this.lblIncorrect.Text = "Incorrect Gueses:  ";
            this.lblIncorrect.Visible = false;
            // 
            // txtHnagman
            // 
            this.txtHnagman.Location = new System.Drawing.Point(307, 92);
            this.txtHnagman.Multiline = true;
            this.txtHnagman.Name = "txtHnagman";
            this.txtHnagman.ReadOnly = true;
            this.txtHnagman.Size = new System.Drawing.Size(87, 142);
            this.txtHnagman.TabIndex = 8;
            // 
            // Hangman
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(432, 322);
            this.Controls.Add(this.txtHnagman);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.TextBox txtHnagman;
    }
}

