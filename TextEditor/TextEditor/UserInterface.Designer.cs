﻿namespace Ksu.Cis300.TextEditor
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
            this.uxMenuBar = new System.Windows.Forms.MenuStrip();
            this.uxFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptWithString = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptWithStringBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.uxRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.uxDisplay = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxKill = new System.Windows.Forms.ToolStripMenuItem();
            this.uxCopyAsKill = new System.Windows.Forms.ToolStripMenuItem();
            this.uxYank = new System.Windows.Forms.ToolStripMenuItem();
            this.uxYankPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuBar
            // 
            this.uxMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileMenu,
            this.uxEncryptMenu,
            this.uxEditMenu});
            this.uxMenuBar.Location = new System.Drawing.Point(0, 0);
            this.uxMenuBar.Name = "uxMenuBar";
            this.uxMenuBar.Size = new System.Drawing.Size(547, 24);
            this.uxMenuBar.TabIndex = 0;
            this.uxMenuBar.Text = "menuStrip1";
            // 
            // uxFileMenu
            // 
            this.uxFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxSaveAs});
            this.uxFileMenu.Name = "uxFileMenu";
            this.uxFileMenu.Size = new System.Drawing.Size(37, 20);
            this.uxFileMenu.Text = "File";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(132, 22);
            this.uxOpen.Text = "Open . . .";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxSaveAs
            // 
            this.uxSaveAs.Name = "uxSaveAs";
            this.uxSaveAs.Size = new System.Drawing.Size(132, 22);
            this.uxSaveAs.Text = "Save As . . .";
            this.uxSaveAs.Click += new System.EventHandler(this.uxSaveAs_Click);
            // 
            // uxEncryptMenu
            // 
            this.uxEncryptMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxEncryptWithString,
            this.uxEncryptWithStringBuilder});
            this.uxEncryptMenu.Name = "uxEncryptMenu";
            this.uxEncryptMenu.Size = new System.Drawing.Size(59, 20);
            this.uxEncryptMenu.Text = "Encrypt";
            // 
            // uxEncryptWithString
            // 
            this.uxEncryptWithString.Name = "uxEncryptWithString";
            this.uxEncryptWithString.Size = new System.Drawing.Size(170, 22);
            this.uxEncryptWithString.Text = "With String";
            this.uxEncryptWithString.Click += new System.EventHandler(this.uxEncryptWithString_Click);
            // 
            // uxEncryptWithStringBuilder
            // 
            this.uxEncryptWithStringBuilder.Name = "uxEncryptWithStringBuilder";
            this.uxEncryptWithStringBuilder.Size = new System.Drawing.Size(170, 22);
            this.uxEncryptWithStringBuilder.Text = "With StringBuilder";
            this.uxEncryptWithStringBuilder.Click += new System.EventHandler(this.uxEncryptWithStringBuilder_Click);
            // 
            // uxEditMenu
            // 
            this.uxEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxUndo,
            this.uxRedo,
            this.uxKill,
            this.uxCopyAsKill,
            this.uxYank,
            this.uxYankPrevious});
            this.uxEditMenu.Name = "uxEditMenu";
            this.uxEditMenu.Size = new System.Drawing.Size(39, 20);
            this.uxEditMenu.Text = "Edit";
            // 
            // uxUndo
            // 
            this.uxUndo.Enabled = false;
            this.uxUndo.Name = "uxUndo";
            this.uxUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.uxUndo.Size = new System.Drawing.Size(152, 22);
            this.uxUndo.Text = "Undo";
            this.uxUndo.Click += new System.EventHandler(this.uxUndo_Click);
            // 
            // uxRedo
            // 
            this.uxRedo.Enabled = false;
            this.uxRedo.Name = "uxRedo";
            this.uxRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.uxRedo.Size = new System.Drawing.Size(152, 22);
            this.uxRedo.Text = "Redo";
            this.uxRedo.Click += new System.EventHandler(this.uxRedo_Click);
            // 
            // uxDisplay
            // 
            this.uxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDisplay.Location = new System.Drawing.Point(12, 27);
            this.uxDisplay.Multiline = true;
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxDisplay.Size = new System.Drawing.Size(523, 315);
            this.uxDisplay.TabIndex = 1;
            this.uxDisplay.TextChanged += new System.EventHandler(this.uxDisplay_TextChanged);
            // 
            // uxKill
            // 
            this.uxKill.Name = "uxKill";
            this.uxKill.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.uxKill.Size = new System.Drawing.Size(187, 22);
            this.uxKill.Text = "Kill";
            this.uxKill.Click += new System.EventHandler(this.uxKill_Click);
            // 
            // uxCopyAsKill
            // 
            this.uxCopyAsKill.Name = "uxCopyAsKill";
            this.uxCopyAsKill.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.uxCopyAsKill.Size = new System.Drawing.Size(187, 22);
            this.uxCopyAsKill.Text = "Copy as Kill";
            this.uxCopyAsKill.Click += new System.EventHandler(this.uxCopyAsKill_Click);
            // 
            // uxYank
            // 
            this.uxYank.Enabled = false;
            this.uxYank.Name = "uxYank";
            this.uxYank.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uxYank.Size = new System.Drawing.Size(187, 22);
            this.uxYank.Text = "Yank";
            this.uxYank.Click += new System.EventHandler(this.uxYank_Click);
            // 
            // uxYankPrevious
            // 
            this.uxYankPrevious.Enabled = false;
            this.uxYankPrevious.Name = "uxYankPrevious";
            this.uxYankPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.uxYankPrevious.Size = new System.Drawing.Size(187, 22);
            this.uxYankPrevious.Text = "Yank Previous";
            this.uxYankPrevious.Click += new System.EventHandler(this.uxYankPrevious_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 354);
            this.Controls.Add(this.uxDisplay);
            this.Controls.Add(this.uxMenuBar);
            this.MainMenuStrip = this.uxMenuBar;
            this.Name = "UserInterface";
            this.Text = "Text Editor";
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuBar;
        private System.Windows.Forms.ToolStripMenuItem uxFileMenu;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAs;
        private System.Windows.Forms.TextBox uxDisplay;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptMenu;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptWithString;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptWithStringBuilder;
        private System.Windows.Forms.ToolStripMenuItem uxEditMenu;
        private System.Windows.Forms.ToolStripMenuItem uxUndo;
        private System.Windows.Forms.ToolStripMenuItem uxRedo;
        private System.Windows.Forms.ToolStripMenuItem uxKill;
        private System.Windows.Forms.ToolStripMenuItem uxCopyAsKill;
        private System.Windows.Forms.ToolStripMenuItem uxYank;
        private System.Windows.Forms.ToolStripMenuItem uxYankPrevious;
    }
}

