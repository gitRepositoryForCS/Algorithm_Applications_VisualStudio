namespace Ksu.Cis300.MazeSolver
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
            this.uxMaze = new Ksu.Cis300.MazeSolver.Maze();
            this.uxNewMaze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxMaze
            // 
            this.uxMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMaze.Location = new System.Drawing.Point(5, 6);
            this.uxMaze.Name = "uxMaze";
            this.uxMaze.PathColor = System.Drawing.SystemColors.Highlight;
            this.uxMaze.Size = new System.Drawing.Size(557, 409);
            this.uxMaze.TabIndex = 0;
            this.uxMaze.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uxMaze_MouseClick);
            // 
            // uxNewMaze
            // 
            this.uxNewMaze.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxNewMaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewMaze.Location = new System.Drawing.Point(213, 421);
            this.uxNewMaze.Name = "uxNewMaze";
            this.uxNewMaze.Size = new System.Drawing.Size(137, 38);
            this.uxNewMaze.TabIndex = 2;
            this.uxNewMaze.Text = "New Maze";
            this.uxNewMaze.UseVisualStyleBackColor = true;
            this.uxNewMaze.Click += new System.EventHandler(this.uxNewMaze_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 471);
            this.Controls.Add(this.uxNewMaze);
            this.Controls.Add(this.uxMaze);
            this.Name = "UserInterface";
            this.Text = "Maze Solver";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Maze uxMaze;
        private System.Windows.Forms.Button uxNewMaze;
    }
}

