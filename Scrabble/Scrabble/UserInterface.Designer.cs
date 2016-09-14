namespace Ksu.Cis300.Scrabble
{
    partial class UserInterface
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
            this.components = new System.ComponentModel.Container();
            this.uxPlayerALabel = new System.Windows.Forms.Label();
            this.uxScoreA = new System.Windows.Forms.TextBox();
            this.uxTrayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uxPlayerBLabel = new System.Windows.Forms.Label();
            this.uxScoreB = new System.Windows.Forms.TextBox();
            this.uxBoardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uxToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxPlay = new System.Windows.Forms.Button();
            this.uxCheck = new System.Windows.Forms.Button();
            this.uxTrade = new System.Windows.Forms.Button();
            this.uxRemainingLabel = new System.Windows.Forms.Label();
            this.uxRemaining = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxPlayerALabel
            // 
            this.uxPlayerALabel.AutoSize = true;
            this.uxPlayerALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlayerALabel.Location = new System.Drawing.Point(12, 15);
            this.uxPlayerALabel.Name = "uxPlayerALabel";
            this.uxPlayerALabel.Size = new System.Drawing.Size(77, 24);
            this.uxPlayerALabel.TabIndex = 0;
            this.uxPlayerALabel.Text = "Human:";
            // 
            // uxScoreA
            // 
            this.uxScoreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxScoreA.Location = new System.Drawing.Point(100, 12);
            this.uxScoreA.Name = "uxScoreA";
            this.uxScoreA.ReadOnly = true;
            this.uxScoreA.Size = new System.Drawing.Size(50, 29);
            this.uxScoreA.TabIndex = 1;
            this.uxScoreA.Text = "0";
            this.uxScoreA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxTrayPanel
            // 
            this.uxTrayPanel.Location = new System.Drawing.Point(167, 6);
            this.uxTrayPanel.Name = "uxTrayPanel";
            this.uxTrayPanel.Size = new System.Drawing.Size(269, 35);
            this.uxTrayPanel.TabIndex = 2;
            // 
            // uxPlayerBLabel
            // 
            this.uxPlayerBLabel.AutoSize = true;
            this.uxPlayerBLabel.Enabled = false;
            this.uxPlayerBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlayerBLabel.Location = new System.Drawing.Point(442, 15);
            this.uxPlayerBLabel.Name = "uxPlayerBLabel";
            this.uxPlayerBLabel.Size = new System.Drawing.Size(98, 24);
            this.uxPlayerBLabel.TabIndex = 3;
            this.uxPlayerBLabel.Text = "Computer:";
            // 
            // uxScoreB
            // 
            this.uxScoreB.Enabled = false;
            this.uxScoreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxScoreB.Location = new System.Drawing.Point(532, 12);
            this.uxScoreB.Name = "uxScoreB";
            this.uxScoreB.ReadOnly = true;
            this.uxScoreB.Size = new System.Drawing.Size(50, 29);
            this.uxScoreB.TabIndex = 4;
            this.uxScoreB.Text = "0";
            this.uxScoreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxBoardPanel
            // 
            this.uxBoardPanel.Location = new System.Drawing.Point(12, 103);
            this.uxBoardPanel.Name = "uxBoardPanel";
            this.uxBoardPanel.Size = new System.Drawing.Size(576, 576);
            this.uxBoardPanel.TabIndex = 5;
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Title = "Open Dictionary";
            // 
            // uxPlay
            // 
            this.uxPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlay.Location = new System.Drawing.Point(244, 47);
            this.uxPlay.Name = "uxPlay";
            this.uxPlay.Size = new System.Drawing.Size(63, 50);
            this.uxPlay.TabIndex = 6;
            this.uxPlay.Text = "Play";
            this.uxPlay.UseVisualStyleBackColor = true;
            this.uxPlay.Click += new System.EventHandler(this.uxPlay_Click);
            // 
            // uxCheck
            // 
            this.uxCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCheck.Location = new System.Drawing.Point(313, 47);
            this.uxCheck.Name = "uxCheck";
            this.uxCheck.Size = new System.Drawing.Size(127, 50);
            this.uxCheck.TabIndex = 7;
            this.uxCheck.Text = "Check Value";
            this.uxCheck.UseVisualStyleBackColor = true;
            this.uxCheck.Click += new System.EventHandler(this.uxCheck_Click);
            // 
            // uxTrade
            // 
            this.uxTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTrade.Location = new System.Drawing.Point(446, 47);
            this.uxTrade.Name = "uxTrade";
            this.uxTrade.Size = new System.Drawing.Size(136, 50);
            this.uxTrade.TabIndex = 8;
            this.uxTrade.Text = "Trade Tiles";
            this.uxTrade.UseVisualStyleBackColor = true;
            this.uxTrade.Click += new System.EventHandler(this.uxTrade_Click);
            // 
            // uxRemainingLabel
            // 
            this.uxRemainingLabel.AutoSize = true;
            this.uxRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemainingLabel.Location = new System.Drawing.Point(12, 60);
            this.uxRemainingLabel.Name = "uxRemainingLabel";
            this.uxRemainingLabel.Size = new System.Drawing.Size(166, 24);
            this.uxRemainingLabel.TabIndex = 9;
            this.uxRemainingLabel.Text = "Letters Remaining:";
            // 
            // uxRemaining
            // 
            this.uxRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemaining.Location = new System.Drawing.Point(184, 57);
            this.uxRemaining.Name = "uxRemaining";
            this.uxRemaining.ReadOnly = true;
            this.uxRemaining.Size = new System.Drawing.Size(54, 29);
            this.uxRemaining.TabIndex = 10;
            this.uxRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 686);
            this.Controls.Add(this.uxRemaining);
            this.Controls.Add(this.uxRemainingLabel);
            this.Controls.Add(this.uxTrade);
            this.Controls.Add(this.uxCheck);
            this.Controls.Add(this.uxPlay);
            this.Controls.Add(this.uxBoardPanel);
            this.Controls.Add(this.uxScoreB);
            this.Controls.Add(this.uxPlayerBLabel);
            this.Controls.Add(this.uxTrayPanel);
            this.Controls.Add(this.uxScoreA);
            this.Controls.Add(this.uxPlayerALabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Scrabble";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxPlayerALabel;
        private System.Windows.Forms.TextBox uxScoreA;
        private System.Windows.Forms.FlowLayoutPanel uxTrayPanel;
        private System.Windows.Forms.Label uxPlayerBLabel;
        private System.Windows.Forms.TextBox uxScoreB;
        private System.Windows.Forms.FlowLayoutPanel uxBoardPanel;
        private System.Windows.Forms.ToolTip uxToolTips;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.Button uxPlay;
        private System.Windows.Forms.Button uxCheck;
        private System.Windows.Forms.Button uxTrade;
        private System.Windows.Forms.Label uxRemainingLabel;
        private System.Windows.Forms.TextBox uxRemaining;
    }
}

