namespace vKeyLogger
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitVKeyLoggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVKeyLoggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideVKeyLoggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.TextBox();
            this.trayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Monitoring System...";
            this.trayIcon.Visible = true;
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitVKeyLoggerToolStripMenuItem,
            this.showVKeyLoggerToolStripMenuItem,
            this.hideVKeyLoggerToolStripMenuItem});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(169, 70);
            // 
            // exitVKeyLoggerToolStripMenuItem
            // 
            this.exitVKeyLoggerToolStripMenuItem.Name = "exitVKeyLoggerToolStripMenuItem";
            this.exitVKeyLoggerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitVKeyLoggerToolStripMenuItem.Text = "Exit vKeyLogger";
            this.exitVKeyLoggerToolStripMenuItem.Click += new System.EventHandler(this.exitVKeyLoggerToolStripMenuItem_Click);
            // 
            // showVKeyLoggerToolStripMenuItem
            // 
            this.showVKeyLoggerToolStripMenuItem.Name = "showVKeyLoggerToolStripMenuItem";
            this.showVKeyLoggerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.showVKeyLoggerToolStripMenuItem.Text = "Show vKeyLogger";
            this.showVKeyLoggerToolStripMenuItem.Click += new System.EventHandler(this.showVKeyLoggerToolStripMenuItem_Click);
            // 
            // hideVKeyLoggerToolStripMenuItem
            // 
            this.hideVKeyLoggerToolStripMenuItem.Name = "hideVKeyLoggerToolStripMenuItem";
            this.hideVKeyLoggerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.hideVKeyLoggerToolStripMenuItem.Text = "Hide vKeyLogger";
            this.hideVKeyLoggerToolStripMenuItem.Click += new System.EventHandler(this.hideVKeyLoggerToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "vKeyLogger is monitoring your system!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.Size = new System.Drawing.Size(260, 91);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "vKL";
            this.trayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitVKeyLoggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVKeyLoggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideVKeyLoggerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox label1;
    }
}

