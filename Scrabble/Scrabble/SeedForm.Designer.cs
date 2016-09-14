namespace Ksu.Cis300.Scrabble
{
    partial class SeedForm
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
            this.uxSeedLabel = new System.Windows.Forms.Label();
            this.uxSeed = new System.Windows.Forms.NumericUpDown();
            this.uxOK = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSeedLabel
            // 
            this.uxSeedLabel.AutoSize = true;
            this.uxSeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSeedLabel.Location = new System.Drawing.Point(12, 14);
            this.uxSeedLabel.Name = "uxSeedLabel";
            this.uxSeedLabel.Size = new System.Drawing.Size(110, 24);
            this.uxSeedLabel.TabIndex = 0;
            this.uxSeedLabel.Text = "Enter Seed:";
            // 
            // uxSeed
            // 
            this.uxSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSeed.Location = new System.Drawing.Point(128, 12);
            this.uxSeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.uxSeed.Name = "uxSeed";
            this.uxSeed.Size = new System.Drawing.Size(124, 29);
            this.uxSeed.TabIndex = 1;
            this.uxSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOK.Location = new System.Drawing.Point(12, 47);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(117, 40);
            this.uxOK.TabIndex = 2;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            // 
            // uxCancel
            // 
            this.uxCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancel.Location = new System.Drawing.Point(135, 47);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(117, 40);
            this.uxCancel.TabIndex = 3;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // SeedForm
            // 
            this.AcceptButton = this.uxOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 99);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxSeed);
            this.Controls.Add(this.uxSeedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SeedForm";
            this.Text = "Get Seed";
            ((System.ComponentModel.ISupportInitialize)(this.uxSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxSeedLabel;
        private System.Windows.Forms.NumericUpDown uxSeed;
        private System.Windows.Forms.Button uxOK;
        private System.Windows.Forms.Button uxCancel;
    }
}