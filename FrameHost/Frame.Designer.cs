namespace FrameHost
{
    partial class Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.HotBar = new System.Windows.Forms.ToolStrip();
            this.ExitSystemButton = new System.Windows.Forms.ToolStripButton();
            this.FileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotBar
            // 
            this.HotBar.AutoSize = false;
            this.HotBar.BackColor = System.Drawing.Color.Black;
            this.HotBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HotBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HotBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitSystemButton,
            this.FileButton});
            this.HotBar.Location = new System.Drawing.Point(0, 0);
            this.HotBar.Name = "HotBar";
            this.HotBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.HotBar.Size = new System.Drawing.Size(640, 35);
            this.HotBar.TabIndex = 0;
            // 
            // ExitSystemButton
            // 
            this.ExitSystemButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitSystemButton.AutoToolTip = false;
            this.ExitSystemButton.BackColor = System.Drawing.Color.Maroon;
            this.ExitSystemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitSystemButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.ExitSystemButton.ForeColor = System.Drawing.Color.DimGray;
            this.ExitSystemButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitSystemButton.Image")));
            this.ExitSystemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitSystemButton.Name = "ExitSystemButton";
            this.ExitSystemButton.Size = new System.Drawing.Size(30, 32);
            this.ExitSystemButton.Text = "X";
            this.ExitSystemButton.Click += new System.EventHandler(this.ExitSystemButton_Click);
            // 
            // FileButton
            // 
            this.FileButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.FileButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileButton.Image = ((System.Drawing.Image)(resources.GetObject("FileButton.Image")));
            this.FileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(104, 32);
            this.FileButton.Text = "   File   ";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.HotBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frame";
            this.ShowIcon = false;
            this.Text = "FloppyFrame";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frame_Paint);
            this.HotBar.ResumeLayout(false);
            this.HotBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip HotBar;
        private System.Windows.Forms.ToolStripButton ExitSystemButton;
        private System.Windows.Forms.ToolStripDropDownButton FileButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

