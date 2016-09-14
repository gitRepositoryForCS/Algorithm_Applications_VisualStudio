namespace Ksu.Cis300.MatrixMultiplier
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
      

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxOpenA = new System.Windows.Forms.Button();
            this.uxOpenB = new System.Windows.Forms.Button();
            this.uxOutput = new System.Windows.Forms.Button();
            this.uxDisplayA = new System.Windows.Forms.TextBox();
            this.uxDisplayB = new System.Windows.Forms.TextBox();
            this.uxSave = new System.Windows.Forms.TextBox();
            this.uxCompute = new System.Windows.Forms.Button();
            this.uxOpenDialogA = new System.Windows.Forms.OpenFileDialog();
            this.uxOpenDialogB = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxMatrixA = new System.Windows.Forms.Button();
            this.uxMatrixB = new System.Windows.Forms.Button();
            this.uxOutputMatrix = new System.Windows.Forms.Button();
            this.uxSaveMatrix = new System.Windows.Forms.Button();
            this.uxTextBoxA = new System.Windows.Forms.TextBox();
            this.uxTextBoxB = new System.Windows.Forms.TextBox();
            this.uxTextBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxOpenA
            // 
            this.uxOpenA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpenA.Location = new System.Drawing.Point(12, 27);
            this.uxOpenA.Name = "uxOpenA";
            this.uxOpenA.Size = new System.Drawing.Size(118, 45);
            this.uxOpenA.TabIndex = 0;
            this.uxOpenA.Text = "Matrix A:";
            this.uxOpenA.UseVisualStyleBackColor = true;
            // 
            // uxOpenB
            // 
            this.uxOpenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpenB.Location = new System.Drawing.Point(12, 87);
            this.uxOpenB.Name = "uxOpenB";
            this.uxOpenB.Size = new System.Drawing.Size(118, 45);
            this.uxOpenB.TabIndex = 1;
            this.uxOpenB.Text = "Matrix B:";
            this.uxOpenB.UseVisualStyleBackColor = true;
            // 
            // uxOutput
            // 
            this.uxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOutput.Location = new System.Drawing.Point(12, 149);
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.Size = new System.Drawing.Size(123, 42);
            this.uxOutput.TabIndex = 2;
            this.uxOutput.Text = "Output:";
            this.uxOutput.UseVisualStyleBackColor = true;
            // 
            // uxDisplayA
            // 
            this.uxDisplayA.Location = new System.Drawing.Point(146, 27);
            this.uxDisplayA.Multiline = true;
            this.uxDisplayA.Name = "uxDisplayA";
            this.uxDisplayA.Size = new System.Drawing.Size(455, 45);
            this.uxDisplayA.TabIndex = 3;
            // 
            // uxDisplayB
            // 
            this.uxDisplayB.Location = new System.Drawing.Point(146, 87);
            this.uxDisplayB.Multiline = true;
            this.uxDisplayB.Name = "uxDisplayB";
            this.uxDisplayB.Size = new System.Drawing.Size(455, 45);
            this.uxDisplayB.TabIndex = 4;
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(146, 149);
            this.uxSave.Multiline = true;
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(455, 42);
            this.uxSave.TabIndex = 5;
            // 
            // uxCompute
            // 
            this.uxCompute.Enabled = false;
            this.uxCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCompute.Location = new System.Drawing.Point(12, 210);
            this.uxCompute.Name = "uxCompute";
            this.uxCompute.Size = new System.Drawing.Size(589, 46);
            this.uxCompute.TabIndex = 6;
            this.uxCompute.Text = "Compute Matrix Product";
            this.uxCompute.UseVisualStyleBackColor = true;
            // 
            // uxOpenDialogA
            // 
            this.uxOpenDialogA.FileName = "uxOpenDialogA";
            // 
            // uxOpenDialogB
            // 
            this.uxOpenDialogB.FileName = "uxOpenDialogB";
            // 
            // uxMatrixA
            // 
            this.uxMatrixA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMatrixA.Location = new System.Drawing.Point(12, 12);
            this.uxMatrixA.Name = "uxMatrixA";
            this.uxMatrixA.Size = new System.Drawing.Size(117, 38);
            this.uxMatrixA.TabIndex = 0;
            this.uxMatrixA.Text = "MatrixA:";
            this.uxMatrixA.UseVisualStyleBackColor = true;
            this.uxMatrixA.Click += new System.EventHandler(this.uxMatrixA_Click);
            // 
            // uxMatrixB
            // 
            this.uxMatrixB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMatrixB.Location = new System.Drawing.Point(12, 56);
            this.uxMatrixB.Name = "uxMatrixB";
            this.uxMatrixB.Size = new System.Drawing.Size(117, 38);
            this.uxMatrixB.TabIndex = 1;
            this.uxMatrixB.Text = "MatrixB";
            this.uxMatrixB.UseVisualStyleBackColor = true;
            this.uxMatrixB.Click += new System.EventHandler(this.uxMatrixB_Click);
            // 
            // uxOutputMatrix
            // 
            this.uxOutputMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOutputMatrix.Location = new System.Drawing.Point(12, 102);
            this.uxOutputMatrix.Name = "uxOutputMatrix";
            this.uxOutputMatrix.Size = new System.Drawing.Size(117, 38);
            this.uxOutputMatrix.TabIndex = 2;
            this.uxOutputMatrix.Text = "Output:";
            this.uxOutputMatrix.UseVisualStyleBackColor = true;
            this.uxOutputMatrix.Click += new System.EventHandler(this.uxOutputMatrix_Click);
            // 
            // uxSaveMatrix
            // 
            this.uxSaveMatrix.Enabled = false;
            this.uxSaveMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveMatrix.Location = new System.Drawing.Point(12, 147);
            this.uxSaveMatrix.Name = "uxSaveMatrix";
            this.uxSaveMatrix.Size = new System.Drawing.Size(597, 38);
            this.uxSaveMatrix.TabIndex = 3;
            this.uxSaveMatrix.Text = "Compute Matrix Product";
            this.uxSaveMatrix.UseVisualStyleBackColor = true;
            this.uxSaveMatrix.Click += new System.EventHandler(this.uxSaveMatrix_Click);
            // 
            // uxTextBoxA
            // 
            this.uxTextBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxA.Location = new System.Drawing.Point(135, 12);
            this.uxTextBoxA.Multiline = true;
            this.uxTextBoxA.Name = "uxTextBoxA";
            this.uxTextBoxA.ReadOnly = true;
            this.uxTextBoxA.Size = new System.Drawing.Size(474, 39);
            this.uxTextBoxA.TabIndex = 4;
         
            // 
            // uxTextBoxB
            // 
            this.uxTextBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxB.Location = new System.Drawing.Point(135, 57);
            this.uxTextBoxB.Multiline = true;
            this.uxTextBoxB.Name = "uxTextBoxB";
            this.uxTextBoxB.ReadOnly = true;
            this.uxTextBoxB.Size = new System.Drawing.Size(474, 38);
            this.uxTextBoxB.TabIndex = 5;
            // 
            // uxTextBoxOutput
            // 
            this.uxTextBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxOutput.Location = new System.Drawing.Point(135, 102);
            this.uxTextBoxOutput.Multiline = true;
            this.uxTextBoxOutput.Name = "uxTextBoxOutput";
            this.uxTextBoxOutput.ReadOnly = true;
            this.uxTextBoxOutput.Size = new System.Drawing.Size(474, 39);
            this.uxTextBoxOutput.TabIndex = 6;
            // 
            // UserInterface
            // 
            this.ClientSize = new System.Drawing.Size(621, 194);
            this.Controls.Add(this.uxTextBoxOutput);
            this.Controls.Add(this.uxTextBoxB);
            this.Controls.Add(this.uxTextBoxA);
            this.Controls.Add(this.uxSaveMatrix);
            this.Controls.Add(this.uxOutputMatrix);
            this.Controls.Add(this.uxMatrixB);
            this.Controls.Add(this.uxMatrixA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxOpenA;
        private System.Windows.Forms.Button uxOpenB;
        private System.Windows.Forms.Button uxOutput;
        private System.Windows.Forms.TextBox uxDisplayA;
        private System.Windows.Forms.TextBox uxDisplayB;
        private System.Windows.Forms.TextBox uxSave;
        private System.Windows.Forms.Button uxCompute;
        private System.Windows.Forms.OpenFileDialog uxOpenDialogA;
        private System.Windows.Forms.OpenFileDialog uxOpenDialogB;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
        private System.Windows.Forms.Button uxMatrixA;
        private System.Windows.Forms.Button uxMatrixB;
        private System.Windows.Forms.Button uxOutputMatrix;
        private System.Windows.Forms.Button uxSaveMatrix;
        private System.Windows.Forms.TextBox uxTextBoxA;
        private System.Windows.Forms.TextBox uxTextBoxB;
        private System.Windows.Forms.TextBox uxTextBoxOutput;
    }
}

