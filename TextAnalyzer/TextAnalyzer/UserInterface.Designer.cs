namespace Ksu.Cis300.TextAnalyzer
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
            this.uxButton1 = new System.Windows.Forms.Button();
            this.uxButton2 = new System.Windows.Forms.Button();
            this.uxAnalyze = new System.Windows.Forms.Button();
            this.uxFile1 = new System.Windows.Forms.TextBox();
            this.uxFile2 = new System.Windows.Forms.TextBox();
            this.uxOpenFile1 = new System.Windows.Forms.OpenFileDialog();
            this.uxOpenFile2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxButton1
            // 
            this.uxButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton1.Location = new System.Drawing.Point(13, 12);
            this.uxButton1.Name = "uxButton1";
            this.uxButton1.Size = new System.Drawing.Size(84, 46);
            this.uxButton1.TabIndex = 0;
            this.uxButton1.Text = "Text 1:";
            this.uxButton1.UseVisualStyleBackColor = true;
            this.uxButton1.Click += new System.EventHandler(this.uxButton1_Click);
            // 
            // uxButton2
            // 
            this.uxButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton2.Location = new System.Drawing.Point(13, 66);
            this.uxButton2.Name = "uxButton2";
            this.uxButton2.Size = new System.Drawing.Size(84, 46);
            this.uxButton2.TabIndex = 1;
            this.uxButton2.Text = "Text 2:";
            this.uxButton2.UseVisualStyleBackColor = true;
            this.uxButton2.Click += new System.EventHandler(this.uxButton2_Click);
            // 
            // uxAnalyze
            // 
            this.uxAnalyze.Enabled = false;
            this.uxAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAnalyze.Location = new System.Drawing.Point(12, 129);
            this.uxAnalyze.Name = "uxAnalyze";
            this.uxAnalyze.Size = new System.Drawing.Size(539, 46);
            this.uxAnalyze.TabIndex = 2;
            this.uxAnalyze.Text = "Analyze Texts";
            this.uxAnalyze.UseVisualStyleBackColor = true;
            this.uxAnalyze.Click += new System.EventHandler(this.uxAnalyze_Click);
            // 
            // uxFile1
            // 
            this.uxFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFile1.Location = new System.Drawing.Point(103, 20);
            this.uxFile1.Name = "uxFile1";
            this.uxFile1.ReadOnly = true;
            this.uxFile1.Size = new System.Drawing.Size(448, 29);
            this.uxFile1.TabIndex = 3;
            // 
            // uxFile2
            // 
            this.uxFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFile2.Location = new System.Drawing.Point(103, 74);
            this.uxFile2.Name = "uxFile2";
            this.uxFile2.ReadOnly = true;
            this.uxFile2.Size = new System.Drawing.Size(448, 29);
            this.uxFile2.TabIndex = 4;
            this.uxFile2.TextChanged += new System.EventHandler(this.uxFile2_TextChanged);
            // 
            // uxOpenFile1
            // 
            this.uxOpenFile1.FileName = "openFile1";
            // 
            // uxOpenFile2
            // 
            this.uxOpenFile2.FileName = "openFile2";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 185);
            this.Controls.Add(this.uxFile2);
            this.Controls.Add(this.uxFile1);
            this.Controls.Add(this.uxAnalyze);
            this.Controls.Add(this.uxButton2);
            this.Controls.Add(this.uxButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Text Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxButton1;
        private System.Windows.Forms.Button uxButton2;
        private System.Windows.Forms.Button uxAnalyze;
        private System.Windows.Forms.TextBox uxFile1;
        private System.Windows.Forms.TextBox uxFile2;
        private System.Windows.Forms.OpenFileDialog uxOpenFile1;
        private System.Windows.Forms.OpenFileDialog uxOpenFile2;
    }
}

