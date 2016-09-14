namespace Ksu.Cis300.Calculator
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
            this.uxDisplay = new System.Windows.Forms.TextBox();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxOpeningParenthesis = new System.Windows.Forms.Button();
            this.uxClosingParenthesis = new System.Windows.Forms.Button();
            this.uxDivide = new System.Windows.Forms.Button();
            this.uxSeven = new System.Windows.Forms.Button();
            this.uxEight = new System.Windows.Forms.Button();
            this.uxNine = new System.Windows.Forms.Button();
            this.uxMultiply = new System.Windows.Forms.Button();
            this.uxFour = new System.Windows.Forms.Button();
            this.uxFive = new System.Windows.Forms.Button();
            this.uxSix = new System.Windows.Forms.Button();
            this.uxSubtract = new System.Windows.Forms.Button();
            this.uxOne = new System.Windows.Forms.Button();
            this.uxTwo = new System.Windows.Forms.Button();
            this.uxThree = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxZero = new System.Windows.Forms.Button();
            this.uxDecimalPoint = new System.Windows.Forms.Button();
            this.uxChangeSigns = new System.Windows.Forms.Button();
            this.uxEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDisplay
            // 
            this.uxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDisplay.Location = new System.Drawing.Point(14, 14);
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.ReadOnly = true;
            this.uxDisplay.Size = new System.Drawing.Size(274, 29);
            this.uxDisplay.TabIndex = 0;
            this.uxDisplay.Text = "0";
            this.uxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxClear
            // 
            this.uxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClear.Location = new System.Drawing.Point(14, 49);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(64, 35);
            this.uxClear.TabIndex = 1;
            this.uxClear.Text = "C/CE";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxOpeningParenthesis
            // 
            this.uxOpeningParenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpeningParenthesis.Location = new System.Drawing.Point(84, 49);
            this.uxOpeningParenthesis.Name = "uxOpeningParenthesis";
            this.uxOpeningParenthesis.Size = new System.Drawing.Size(64, 35);
            this.uxOpeningParenthesis.TabIndex = 2;
            this.uxOpeningParenthesis.Text = "(";
            this.uxOpeningParenthesis.UseVisualStyleBackColor = true;
            this.uxOpeningParenthesis.Click += new System.EventHandler(this.uxOpeningParenthesis_Click);
            // 
            // uxClosingParenthesis
            // 
            this.uxClosingParenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClosingParenthesis.Location = new System.Drawing.Point(154, 49);
            this.uxClosingParenthesis.Name = "uxClosingParenthesis";
            this.uxClosingParenthesis.Size = new System.Drawing.Size(64, 35);
            this.uxClosingParenthesis.TabIndex = 3;
            this.uxClosingParenthesis.Text = ")";
            this.uxClosingParenthesis.UseVisualStyleBackColor = true;
            this.uxClosingParenthesis.Click += new System.EventHandler(this.uxClosingParenthesis_Click);
            // 
            // uxDivide
            // 
            this.uxDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDivide.Location = new System.Drawing.Point(224, 49);
            this.uxDivide.Name = "uxDivide";
            this.uxDivide.Size = new System.Drawing.Size(64, 35);
            this.uxDivide.TabIndex = 4;
            this.uxDivide.Text = "/";
            this.uxDivide.UseVisualStyleBackColor = true;
            this.uxDivide.Click += new System.EventHandler(this.uxClosingParenthesis_Click);
            // 
            // uxSeven
            // 
            this.uxSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSeven.Location = new System.Drawing.Point(14, 90);
            this.uxSeven.Name = "uxSeven";
            this.uxSeven.Size = new System.Drawing.Size(64, 35);
            this.uxSeven.TabIndex = 5;
            this.uxSeven.Text = "7";
            this.uxSeven.UseVisualStyleBackColor = true;
            this.uxSeven.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxEight
            // 
            this.uxEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEight.Location = new System.Drawing.Point(84, 90);
            this.uxEight.Name = "uxEight";
            this.uxEight.Size = new System.Drawing.Size(64, 35);
            this.uxEight.TabIndex = 6;
            this.uxEight.Text = "8";
            this.uxEight.UseVisualStyleBackColor = true;
            this.uxEight.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxNine
            // 
            this.uxNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNine.Location = new System.Drawing.Point(154, 90);
            this.uxNine.Name = "uxNine";
            this.uxNine.Size = new System.Drawing.Size(64, 35);
            this.uxNine.TabIndex = 7;
            this.uxNine.Text = "9";
            this.uxNine.UseVisualStyleBackColor = true;
            this.uxNine.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxMultiply
            // 
            this.uxMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMultiply.Location = new System.Drawing.Point(224, 90);
            this.uxMultiply.Name = "uxMultiply";
            this.uxMultiply.Size = new System.Drawing.Size(64, 35);
            this.uxMultiply.TabIndex = 8;
            this.uxMultiply.Text = "X";
            this.uxMultiply.UseVisualStyleBackColor = true;
            this.uxMultiply.Click += new System.EventHandler(this.uxClosingParenthesis_Click);
            // 
            // uxFour
            // 
            this.uxFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFour.Location = new System.Drawing.Point(14, 131);
            this.uxFour.Name = "uxFour";
            this.uxFour.Size = new System.Drawing.Size(64, 35);
            this.uxFour.TabIndex = 9;
            this.uxFour.Text = "4";
            this.uxFour.UseVisualStyleBackColor = true;
            this.uxFour.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxFive
            // 
            this.uxFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFive.Location = new System.Drawing.Point(84, 131);
            this.uxFive.Name = "uxFive";
            this.uxFive.Size = new System.Drawing.Size(64, 35);
            this.uxFive.TabIndex = 10;
            this.uxFive.Text = "5";
            this.uxFive.UseVisualStyleBackColor = true;
            this.uxFive.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxSix
            // 
            this.uxSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSix.Location = new System.Drawing.Point(154, 131);
            this.uxSix.Name = "uxSix";
            this.uxSix.Size = new System.Drawing.Size(64, 35);
            this.uxSix.TabIndex = 11;
            this.uxSix.Text = "6";
            this.uxSix.UseVisualStyleBackColor = true;
            this.uxSix.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxSubtract
            // 
            this.uxSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubtract.Location = new System.Drawing.Point(224, 131);
            this.uxSubtract.Name = "uxSubtract";
            this.uxSubtract.Size = new System.Drawing.Size(64, 35);
            this.uxSubtract.TabIndex = 12;
            this.uxSubtract.Text = "-";
            this.uxSubtract.UseVisualStyleBackColor = true;
            this.uxSubtract.Click += new System.EventHandler(this.uxClosingParenthesis_Click);
            // 
            // uxOne
            // 
            this.uxOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOne.Location = new System.Drawing.Point(14, 172);
            this.uxOne.Name = "uxOne";
            this.uxOne.Size = new System.Drawing.Size(64, 35);
            this.uxOne.TabIndex = 13;
            this.uxOne.Text = "1";
            this.uxOne.UseVisualStyleBackColor = true;
            this.uxOne.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxTwo
            // 
            this.uxTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTwo.Location = new System.Drawing.Point(84, 172);
            this.uxTwo.Name = "uxTwo";
            this.uxTwo.Size = new System.Drawing.Size(64, 35);
            this.uxTwo.TabIndex = 14;
            this.uxTwo.Text = "2";
            this.uxTwo.UseVisualStyleBackColor = true;
            this.uxTwo.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxThree
            // 
            this.uxThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxThree.Location = new System.Drawing.Point(154, 172);
            this.uxThree.Name = "uxThree";
            this.uxThree.Size = new System.Drawing.Size(64, 35);
            this.uxThree.TabIndex = 15;
            this.uxThree.Text = "3";
            this.uxThree.UseVisualStyleBackColor = true;
            this.uxThree.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(224, 172);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(64, 35);
            this.uxAdd.TabIndex = 16;
            this.uxAdd.Text = "+";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxClosingParenthesis_Click);
            // 
            // uxZero
            // 
            this.uxZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxZero.Location = new System.Drawing.Point(14, 213);
            this.uxZero.Name = "uxZero";
            this.uxZero.Size = new System.Drawing.Size(64, 35);
            this.uxZero.TabIndex = 17;
            this.uxZero.Text = "0";
            this.uxZero.UseVisualStyleBackColor = true;
            this.uxZero.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxDecimalPoint
            // 
            this.uxDecimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDecimalPoint.Location = new System.Drawing.Point(84, 213);
            this.uxDecimalPoint.Name = "uxDecimalPoint";
            this.uxDecimalPoint.Size = new System.Drawing.Size(64, 35);
            this.uxDecimalPoint.TabIndex = 18;
            this.uxDecimalPoint.Text = ".";
            this.uxDecimalPoint.UseVisualStyleBackColor = true;
            this.uxDecimalPoint.Click += new System.EventHandler(this.uxDecimalPoint_Click);
            // 
            // uxChangeSigns
            // 
            this.uxChangeSigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxChangeSigns.Location = new System.Drawing.Point(154, 213);
            this.uxChangeSigns.Name = "uxChangeSigns";
            this.uxChangeSigns.Size = new System.Drawing.Size(64, 35);
            this.uxChangeSigns.TabIndex = 19;
            this.uxChangeSigns.Text = "+/-";
            this.uxChangeSigns.UseVisualStyleBackColor = true;
            this.uxChangeSigns.Click += new System.EventHandler(this.uxChangeSigns_Click);
            // 
            // uxEquals
            // 
            this.uxEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEquals.Location = new System.Drawing.Point(224, 213);
            this.uxEquals.Name = "uxEquals";
            this.uxEquals.Size = new System.Drawing.Size(64, 35);
            this.uxEquals.TabIndex = 20;
            this.uxEquals.Text = "=";
            this.uxEquals.UseVisualStyleBackColor = true;
            this.uxEquals.Click += new System.EventHandler(this.uxClosingParenthesis_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 272);
            this.Controls.Add(this.uxEquals);
            this.Controls.Add(this.uxChangeSigns);
            this.Controls.Add(this.uxDecimalPoint);
            this.Controls.Add(this.uxZero);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxThree);
            this.Controls.Add(this.uxTwo);
            this.Controls.Add(this.uxOne);
            this.Controls.Add(this.uxSubtract);
            this.Controls.Add(this.uxSix);
            this.Controls.Add(this.uxFive);
            this.Controls.Add(this.uxFour);
            this.Controls.Add(this.uxMultiply);
            this.Controls.Add(this.uxNine);
            this.Controls.Add(this.uxEight);
            this.Controls.Add(this.uxSeven);
            this.Controls.Add(this.uxDivide);
            this.Controls.Add(this.uxClosingParenthesis);
            this.Controls.Add(this.uxOpeningParenthesis);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserInterface";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxDisplay;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.Button uxOpeningParenthesis;
        private System.Windows.Forms.Button uxClosingParenthesis;
        private System.Windows.Forms.Button uxDivide;
        private System.Windows.Forms.Button uxSeven;
        private System.Windows.Forms.Button uxEight;
        private System.Windows.Forms.Button uxNine;
        private System.Windows.Forms.Button uxMultiply;
        private System.Windows.Forms.Button uxFour;
        private System.Windows.Forms.Button uxFive;
        private System.Windows.Forms.Button uxSix;
        private System.Windows.Forms.Button uxSubtract;
        private System.Windows.Forms.Button uxOne;
        private System.Windows.Forms.Button uxTwo;
        private System.Windows.Forms.Button uxThree;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxZero;
        private System.Windows.Forms.Button uxDecimalPoint;
        private System.Windows.Forms.Button uxChangeSigns;
        private System.Windows.Forms.Button uxEquals;
    }
}

