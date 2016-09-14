namespace Ksu.Cis300.WordLadder
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
            this.uxOpenButton = new System.Windows.Forms.Button();
            this.uxFindWordLadder = new System.Windows.Forms.Button();
            this.uxStartLabel = new System.Windows.Forms.Label();
            this.uxEndLabel = new System.Windows.Forms.Label();
            this.uxStartWord = new System.Windows.Forms.TextBox();
            this.uxEndWord = new System.Windows.Forms.TextBox();
            this.uxListBox = new System.Windows.Forms.ListBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxOpenButton
            // 
            this.uxOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpenButton.Location = new System.Drawing.Point(12, 12);
            this.uxOpenButton.Name = "uxOpenButton";
            this.uxOpenButton.Size = new System.Drawing.Size(286, 39);
            this.uxOpenButton.TabIndex = 0;
            this.uxOpenButton.Text = "Open Dictionary";
            this.uxOpenButton.UseVisualStyleBackColor = true;
            this.uxOpenButton.Click += new System.EventHandler(this.uxOpenButton_Click);
            // 
            // uxFindWordLadder
            // 
            this.uxFindWordLadder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFindWordLadder.Location = new System.Drawing.Point(12, 178);
            this.uxFindWordLadder.Name = "uxFindWordLadder";
            this.uxFindWordLadder.Size = new System.Drawing.Size(286, 42);
            this.uxFindWordLadder.TabIndex = 1;
            this.uxFindWordLadder.Text = "Find Word Ladder";
            this.uxFindWordLadder.UseVisualStyleBackColor = true;
            this.uxFindWordLadder.Click += new System.EventHandler(this.uxFindWordLadder_Click);
            // 
            // uxStartLabel
            // 
            this.uxStartLabel.AutoSize = true;
            this.uxStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartLabel.Location = new System.Drawing.Point(12, 59);
            this.uxStartLabel.Name = "uxStartLabel";
            this.uxStartLabel.Size = new System.Drawing.Size(128, 24);
            this.uxStartLabel.TabIndex = 2;
            this.uxStartLabel.Text = "Starting Word:";
            // 
            // uxEndLabel
            // 
            this.uxEndLabel.AutoSize = true;
            this.uxEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndLabel.Location = new System.Drawing.Point(15, 116);
            this.uxEndLabel.Name = "uxEndLabel";
            this.uxEndLabel.Size = new System.Drawing.Size(127, 24);
            this.uxEndLabel.TabIndex = 3;
            this.uxEndLabel.Text = "Ending Word:";
            // 
            // uxStartWord
            // 
            this.uxStartWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartWord.Location = new System.Drawing.Point(14, 86);
            this.uxStartWord.MaxLength = 24;
            this.uxStartWord.Multiline = true;
            this.uxStartWord.Name = "uxStartWord";
            this.uxStartWord.Size = new System.Drawing.Size(284, 28);
            this.uxStartWord.TabIndex = 4;
            // 
            // uxEndWord
            // 
            this.uxEndWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndWord.Location = new System.Drawing.Point(14, 143);
            this.uxEndWord.MaxLength = 24;
            this.uxEndWord.Multiline = true;
            this.uxEndWord.Name = "uxEndWord";
            this.uxEndWord.Size = new System.Drawing.Size(284, 29);
            this.uxEndWord.TabIndex = 5;
            // 
            // uxListBox
            // 
            this.uxListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxListBox.FormattingEnabled = true;
            this.uxListBox.ItemHeight = 24;
            this.uxListBox.Location = new System.Drawing.Point(12, 226);
            this.uxListBox.Name = "uxListBox";
            this.uxListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.uxListBox.Size = new System.Drawing.Size(286, 196);
            this.uxListBox.TabIndex = 6;
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "uxOpenFileDialog";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 469);
            this.Controls.Add(this.uxListBox);
            this.Controls.Add(this.uxEndWord);
            this.Controls.Add(this.uxStartWord);
            this.Controls.Add(this.uxEndLabel);
            this.Controls.Add(this.uxStartLabel);
            this.Controls.Add(this.uxFindWordLadder);
            this.Controls.Add(this.uxOpenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Word Ladder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxOpenButton;
        private System.Windows.Forms.Button uxFindWordLadder;
        private System.Windows.Forms.Label uxStartLabel;
        private System.Windows.Forms.Label uxEndLabel;
        private System.Windows.Forms.TextBox uxStartWord;
        private System.Windows.Forms.TextBox uxEndWord;
        private System.Windows.Forms.ListBox uxListBox;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
    }
}

