namespace Ksu.Cis300.WebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxMenuBar = new System.Windows.Forms.ToolStrip();
            this.uxForward = new System.Windows.Forms.ToolStripButton();
            this.uxHome2 = new System.Windows.Forms.ToolStripButton();
            this.uxAddress = new System.Windows.Forms.ToolStripTextBox();
            this.uxGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.uxBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uxHome = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.uxMenuBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuBar
            // 
            this.uxMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxForward,
            this.uxHome2,
            this.uxAddress,
            this.uxGo,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripButton3});
            this.uxMenuBar.Location = new System.Drawing.Point(0, 0);
            this.uxMenuBar.Name = "uxMenuBar";
            this.uxMenuBar.Size = new System.Drawing.Size(766, 25);
            this.uxMenuBar.TabIndex = 0;
            this.uxMenuBar.Text = "toolStrip1";
            // 
            // uxForward
            // 
            this.uxForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxForward.Image = ((System.Drawing.Image)(resources.GetObject("uxForward.Image")));
            this.uxForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxForward.Name = "uxForward";
            this.uxForward.Size = new System.Drawing.Size(54, 22);
            this.uxForward.Text = "Forward";
            this.uxForward.Click += new System.EventHandler(this.uxForward_Click);
            // 
            // uxHome2
            // 
            this.uxHome2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxHome2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxHome2.Name = "uxHome2";
            this.uxHome2.Size = new System.Drawing.Size(44, 22);
            this.uxHome2.Text = "Home";
            this.uxHome2.Click += new System.EventHandler(this.uxHome_Click);
            // 
            // uxAddress
            // 
            this.uxAddress.Name = "uxAddress";
            this.uxAddress.Size = new System.Drawing.Size(300, 25);
            // 
            // uxGo
            // 
            this.uxGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxGo.Image = ((System.Drawing.Image)(resources.GetObject("uxGo.Image")));
            this.uxGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxGo.Name = "uxGo";
            this.uxGo.Size = new System.Drawing.Size(31, 22);
            this.uxGo.Text = "GO!";
            this.uxGo.Click += new System.EventHandler(this.uxGo_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton3.Text = "Home";
            // 
            // uxBrowser
            // 
            this.uxBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxBrowser.Location = new System.Drawing.Point(0, 25);
            this.uxBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.uxBrowser.Name = "uxBrowser";
            this.uxBrowser.Size = new System.Drawing.Size(766, 741);
            this.uxBrowser.TabIndex = 1;
            this.uxBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.uxBrowser_DocumentCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.uxHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // uxHome
            // 
            this.uxHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxHome.Image = ((System.Drawing.Image)(resources.GetObject("uxHome.Image")));
            this.uxHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxHome.Name = "uxHome";
            this.uxHome.Size = new System.Drawing.Size(44, 22);
            this.uxHome.Text = "Home";
            this.uxHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripTextBox2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 50);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(766, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 75);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(766, 691);
            this.webBrowser1.TabIndex = 4;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 766);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uxBrowser);
            this.Controls.Add(this.uxMenuBar);
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip uxMenuBar;
        private System.Windows.Forms.ToolStripButton uxForward;
        private System.Windows.Forms.ToolStripButton uxHome2;
        private System.Windows.Forms.ToolStripTextBox uxAddress;
        private System.Windows.Forms.ToolStripButton uxGo;
        private System.Windows.Forms.WebBrowser uxBrowser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton uxHome;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

