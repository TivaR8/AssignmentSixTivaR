﻿namespace AssignmentSixTivaR
{
    partial class frmAssignmentSix
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
            this.grbUserAction = new System.Windows.Forms.GroupBox();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblComputerTag = new System.Windows.Forms.Label();
            this.lblUserTag = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblComputerOverallScore = new System.Windows.Forms.Label();
            this.lblUserOverallScore = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblCompCardTotal = new System.Windows.Forms.Label();
            this.lblUserCardTotal = new System.Windows.Forms.Label();
            this.grbRoundsInfo = new System.Windows.Forms.GroupBox();
            this.grbAceElevenOrOne = new System.Windows.Forms.GroupBox();
            this.btnAceEleven = new System.Windows.Forms.Button();
            this.btnAceOne = new System.Windows.Forms.Button();
            this.grbUserAction.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.grbRoundsInfo.SuspendLayout();
            this.grbAceElevenOrOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUserAction
            // 
            this.grbUserAction.Controls.Add(this.btnStay);
            this.grbUserAction.Controls.Add(this.btnHit);
            this.grbUserAction.Location = new System.Drawing.Point(12, 336);
            this.grbUserAction.Name = "grbUserAction";
            this.grbUserAction.Size = new System.Drawing.Size(200, 100);
            this.grbUserAction.TabIndex = 0;
            this.grbUserAction.TabStop = false;
            this.grbUserAction.Text = "Would you like another card or are you happy with the cards you have?";
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(102, 57);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(75, 23);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(21, 57);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lblComputerTag
            // 
            this.lblComputerTag.AutoSize = true;
            this.lblComputerTag.Location = new System.Drawing.Point(254, 55);
            this.lblComputerTag.Name = "lblComputerTag";
            this.lblComputerTag.Size = new System.Drawing.Size(52, 13);
            this.lblComputerTag.TabIndex = 1;
            this.lblComputerTag.Text = "Computer";
            // 
            // lblUserTag
            // 
            this.lblUserTag.AutoSize = true;
            this.lblUserTag.Location = new System.Drawing.Point(254, 259);
            this.lblUserTag.Name = "lblUserTag";
            this.lblUserTag.Size = new System.Drawing.Size(26, 13);
            this.lblUserTag.TabIndex = 2;
            this.lblUserTag.Text = "You";
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(853, 24);
            this.mnuMenu.TabIndex = 3;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniReset,
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(132, 22);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.mniNewGame_Click);
            // 
            // mniReset
            // 
            this.mniReset.Name = "mniReset";
            this.mniReset.Size = new System.Drawing.Size(132, 22);
            this.mniReset.Text = "Reset";
            this.mniReset.Click += new System.EventHandler(this.mniReset_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(132, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblComputerOverallScore
            // 
            this.lblComputerOverallScore.AutoSize = true;
            this.lblComputerOverallScore.Location = new System.Drawing.Point(15, 39);
            this.lblComputerOverallScore.Name = "lblComputerOverallScore";
            this.lblComputerOverallScore.Size = new System.Drawing.Size(102, 13);
            this.lblComputerOverallScore.TabIndex = 4;
            this.lblComputerOverallScore.Text = "Computer\'s Score: 0";
            // 
            // lblUserOverallScore
            // 
            this.lblUserOverallScore.AutoSize = true;
            this.lblUserOverallScore.Location = new System.Drawing.Point(15, 68);
            this.lblUserOverallScore.Name = "lblUserOverallScore";
            this.lblUserOverallScore.Size = new System.Drawing.Size(72, 13);
            this.lblUserOverallScore.TabIndex = 5;
            this.lblUserOverallScore.Text = "Your Score: 0";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(15, 12);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(48, 13);
            this.lblRounds.TabIndex = 6;
            this.lblRounds.Text = "Round 1";
            // 
            // lblCompCardTotal
            // 
            this.lblCompCardTotal.AutoSize = true;
            this.lblCompCardTotal.Location = new System.Drawing.Point(360, 55);
            this.lblCompCardTotal.Name = "lblCompCardTotal";
            this.lblCompCardTotal.Size = new System.Drawing.Size(74, 13);
            this.lblCompCardTotal.TabIndex = 7;
            this.lblCompCardTotal.Text = "Card Total = 0";
            // 
            // lblUserCardTotal
            // 
            this.lblUserCardTotal.AutoSize = true;
            this.lblUserCardTotal.Location = new System.Drawing.Point(357, 259);
            this.lblUserCardTotal.Name = "lblUserCardTotal";
            this.lblUserCardTotal.Size = new System.Drawing.Size(74, 13);
            this.lblUserCardTotal.TabIndex = 8;
            this.lblUserCardTotal.Text = "Card Total = 0";
            // 
            // grbRoundsInfo
            // 
            this.grbRoundsInfo.Controls.Add(this.lblRounds);
            this.grbRoundsInfo.Controls.Add(this.lblComputerOverallScore);
            this.grbRoundsInfo.Controls.Add(this.lblUserOverallScore);
            this.grbRoundsInfo.Location = new System.Drawing.Point(33, 199);
            this.grbRoundsInfo.Name = "grbRoundsInfo";
            this.grbRoundsInfo.Padding = new System.Windows.Forms.Padding(0);
            this.grbRoundsInfo.Size = new System.Drawing.Size(132, 100);
            this.grbRoundsInfo.TabIndex = 10;
            this.grbRoundsInfo.TabStop = false;
            // 
            // grbAceElevenOrOne
            // 
            this.grbAceElevenOrOne.Controls.Add(this.btnAceEleven);
            this.grbAceElevenOrOne.Controls.Add(this.btnAceOne);
            this.grbAceElevenOrOne.Location = new System.Drawing.Point(12, 64);
            this.grbAceElevenOrOne.Name = "grbAceElevenOrOne";
            this.grbAceElevenOrOne.Size = new System.Drawing.Size(200, 100);
            this.grbAceElevenOrOne.TabIndex = 2;
            this.grbAceElevenOrOne.TabStop = false;
            this.grbAceElevenOrOne.Text = "Would you like the ace to count as an eleven or a one";
            // 
            // btnAceEleven
            // 
            this.btnAceEleven.Location = new System.Drawing.Point(102, 57);
            this.btnAceEleven.Name = "btnAceEleven";
            this.btnAceEleven.Size = new System.Drawing.Size(75, 23);
            this.btnAceEleven.TabIndex = 1;
            this.btnAceEleven.Text = "Eleven";
            this.btnAceEleven.UseVisualStyleBackColor = true;
            this.btnAceEleven.Click += new System.EventHandler(this.btnAceEleven_Click);
            // 
            // btnAceOne
            // 
            this.btnAceOne.Location = new System.Drawing.Point(21, 57);
            this.btnAceOne.Name = "btnAceOne";
            this.btnAceOne.Size = new System.Drawing.Size(75, 23);
            this.btnAceOne.TabIndex = 0;
            this.btnAceOne.Text = "One";
            this.btnAceOne.UseVisualStyleBackColor = true;
            this.btnAceOne.Click += new System.EventHandler(this.btnAceOne_Click);
            // 
            // frmAssignmentSix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 509);
            this.Controls.Add(this.grbAceElevenOrOne);
            this.Controls.Add(this.grbRoundsInfo);
            this.Controls.Add(this.lblUserCardTotal);
            this.Controls.Add(this.lblCompCardTotal);
            this.Controls.Add(this.lblUserTag);
            this.Controls.Add(this.lblComputerTag);
            this.Controls.Add(this.grbUserAction);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmAssignmentSix";
            this.Text = "A Better Game of 21 By Tiva Rait";
            this.grbUserAction.ResumeLayout(false);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.grbRoundsInfo.ResumeLayout(false);
            this.grbRoundsInfo.PerformLayout();
            this.grbAceElevenOrOne.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserAction;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblComputerTag;
        private System.Windows.Forms.Label lblUserTag;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniReset;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblComputerOverallScore;
        private System.Windows.Forms.Label lblUserOverallScore;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblCompCardTotal;
        private System.Windows.Forms.Label lblUserCardTotal;
        private System.Windows.Forms.GroupBox grbRoundsInfo;
        private System.Windows.Forms.GroupBox grbAceElevenOrOne;
        private System.Windows.Forms.Button btnAceEleven;
        private System.Windows.Forms.Button btnAceOne;
    }
}

