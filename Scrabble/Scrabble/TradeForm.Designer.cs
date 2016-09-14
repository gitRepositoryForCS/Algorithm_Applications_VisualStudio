namespace Ksu.Cis300.Scrabble
{
    partial class TradeForm
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
            this.uxChooseLabel = new System.Windows.Forms.Label();
            this.uxTiles = new System.Windows.Forms.CheckedListBox();
            this.uxOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxChooseLabel
            // 
            this.uxChooseLabel.AutoSize = true;
            this.uxChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxChooseLabel.Location = new System.Drawing.Point(12, 9);
            this.uxChooseLabel.Name = "uxChooseLabel";
            this.uxChooseLabel.Size = new System.Drawing.Size(216, 24);
            this.uxChooseLabel.TabIndex = 0;
            this.uxChooseLabel.Text = "Choose the tiles to trade:";
            // 
            // uxTiles
            // 
            this.uxTiles.CheckOnClick = true;
            this.uxTiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTiles.FormattingEnabled = true;
            this.uxTiles.Location = new System.Drawing.Point(16, 36);
            this.uxTiles.Name = "uxTiles";
            this.uxTiles.Size = new System.Drawing.Size(212, 172);
            this.uxTiles.TabIndex = 1;
            // 
            // uxOk
            // 
            this.uxOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOk.Location = new System.Drawing.Point(16, 214);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(212, 42);
            this.uxOk.TabIndex = 2;
            this.uxOk.Text = "OK";
            this.uxOk.UseVisualStyleBackColor = true;
            // 
            // TradeForm
            // 
            this.AcceptButton = this.uxOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 269);
            this.Controls.Add(this.uxOk);
            this.Controls.Add(this.uxTiles);
            this.Controls.Add(this.uxChooseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TradeForm";
            this.Text = "Trade Tiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxChooseLabel;
        private System.Windows.Forms.CheckedListBox uxTiles;
        private System.Windows.Forms.Button uxOk;
    }
}