namespace Ksu.Cis300.Scrabble
{
    partial class BlankTileForm
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
            this.uxPrompt = new System.Windows.Forms.Label();
            this.uxLetters = new System.Windows.Forms.ComboBox();
            this.uxOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxPrompt
            // 
            this.uxPrompt.AutoSize = true;
            this.uxPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrompt.Location = new System.Drawing.Point(12, 15);
            this.uxPrompt.Name = "uxPrompt";
            this.uxPrompt.Size = new System.Drawing.Size(118, 24);
            this.uxPrompt.TabIndex = 0;
            this.uxPrompt.Text = "Select Letter:";
            // 
            // uxLetters
            // 
            this.uxLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLetters.FormattingEnabled = true;
            this.uxLetters.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.uxLetters.Location = new System.Drawing.Point(136, 12);
            this.uxLetters.Name = "uxLetters";
            this.uxLetters.Size = new System.Drawing.Size(55, 32);
            this.uxLetters.TabIndex = 1;
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOK.Location = new System.Drawing.Point(12, 56);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(178, 45);
            this.uxOK.TabIndex = 2;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            // 
            // BlankTileForm
            // 
            this.AcceptButton = this.uxOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 119);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxLetters);
            this.Controls.Add(this.uxPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BlankTileForm";
            this.Text = "Blank Tile Placed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxPrompt;
        private System.Windows.Forms.ComboBox uxLetters;
        private System.Windows.Forms.Button uxOK;
    }
}