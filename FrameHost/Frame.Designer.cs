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
            this.openToolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFLOPStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddKeyToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteKeyToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftPane = new System.Windows.Forms.Panel();
            this.KeyBox = new System.Windows.Forms.ListBox();
            this.RightPane = new System.Windows.Forms.Panel();
            this.ValueBox = new System.Windows.Forms.ListBox();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.HotBar.SuspendLayout();
            this.LeftPane.SuspendLayout();
            this.RightPane.SuspendLayout();
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
            this.FileButton,
            this.EditFLOPStrip});
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
            this.NewToolStripButton,
            this.openToolStripOpen,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.FileButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileButton.Image = ((System.Drawing.Image)(resources.GetObject("FileButton.Image")));
            this.FileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(104, 32);
            this.FileButton.Text = "   File   ";
            // 
            // openToolStripOpen
            // 
            this.openToolStripOpen.Name = "openToolStripOpen";
            this.openToolStripOpen.Size = new System.Drawing.Size(181, 30);
            this.openToolStripOpen.Text = "Open";
            this.openToolStripOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // EditFLOPStrip
            // 
            this.EditFLOPStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditFLOPStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditFLOPStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddKeyToolButton,
            this.deleteKeyToolButton});
            this.EditFLOPStrip.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFLOPStrip.Image = ((System.Drawing.Image)(resources.GetObject("EditFLOPStrip.Image")));
            this.EditFLOPStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditFLOPStrip.Name = "EditFLOPStrip";
            this.EditFLOPStrip.Size = new System.Drawing.Size(107, 32);
            this.EditFLOPStrip.Text = "   Edit   ";
            this.EditFLOPStrip.Visible = false;
            // 
            // AddKeyToolButton
            // 
            this.AddKeyToolButton.Name = "AddKeyToolButton";
            this.AddKeyToolButton.Size = new System.Drawing.Size(200, 30);
            this.AddKeyToolButton.Text = "Add Key";
            this.AddKeyToolButton.Click += new System.EventHandler(this.AddKeyToolButton_Click);
            // 
            // deleteKeyToolButton
            // 
            this.deleteKeyToolButton.Name = "deleteKeyToolButton";
            this.deleteKeyToolButton.Size = new System.Drawing.Size(200, 30);
            this.deleteKeyToolButton.Text = "Delete Key";
            this.deleteKeyToolButton.Click += new System.EventHandler(this.deleteKeyToolButton_Click);
            // 
            // LeftPane
            // 
            this.LeftPane.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LeftPane.Controls.Add(this.KeyBox);
            this.LeftPane.Location = new System.Drawing.Point(12, 58);
            this.LeftPane.Name = "LeftPane";
            this.LeftPane.Size = new System.Drawing.Size(306, 410);
            this.LeftPane.TabIndex = 1;
            this.LeftPane.Visible = false;
            // 
            // KeyBox
            // 
            this.KeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.KeyBox.FormattingEnabled = true;
            this.KeyBox.IntegralHeight = false;
            this.KeyBox.ItemHeight = 31;
            this.KeyBox.Location = new System.Drawing.Point(18, 28);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.ScrollAlwaysVisible = true;
            this.KeyBox.Size = new System.Drawing.Size(267, 356);
            this.KeyBox.TabIndex = 2;
            this.KeyBox.SelectedIndexChanged += new System.EventHandler(this.KeyBox_SelectedIndexChanged);
            this.KeyBox.DoubleClick += new System.EventHandler(this.KeyBox_DoubleClick);
            this.KeyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBox_KeyPress);
            // 
            // RightPane
            // 
            this.RightPane.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RightPane.Controls.Add(this.ValueBox);
            this.RightPane.Location = new System.Drawing.Point(324, 58);
            this.RightPane.Name = "RightPane";
            this.RightPane.Size = new System.Drawing.Size(306, 410);
            this.RightPane.TabIndex = 3;
            this.RightPane.Visible = false;
            // 
            // ValueBox
            // 
            this.ValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ValueBox.FormattingEnabled = true;
            this.ValueBox.IntegralHeight = false;
            this.ValueBox.ItemHeight = 31;
            this.ValueBox.Location = new System.Drawing.Point(18, 28);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.ScrollAlwaysVisible = true;
            this.ValueBox.Size = new System.Drawing.Size(267, 356);
            this.ValueBox.TabIndex = 2;
            this.ValueBox.SelectedIndexChanged += new System.EventHandler(this.ValueBox_SelectedIndexChanged);
            this.ValueBox.DoubleClick += new System.EventHandler(this.ValueBox_DoubleClick);
            this.ValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBox_KeyPress);
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(181, 30);
            this.NewToolStripButton.Text = "New";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.RightPane);
            this.Controls.Add(this.LeftPane);
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
            this.LeftPane.ResumeLayout(false);
            this.RightPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip HotBar;
        private System.Windows.Forms.ToolStripButton ExitSystemButton;
        private System.Windows.Forms.ToolStripDropDownButton FileButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel LeftPane;
        private System.Windows.Forms.ListBox KeyBox;
        private System.Windows.Forms.Panel RightPane;
        private System.Windows.Forms.ListBox ValueBox;
        private System.Windows.Forms.ToolStripDropDownButton EditFLOPStrip;
        private System.Windows.Forms.ToolStripMenuItem AddKeyToolButton;
        private System.Windows.Forms.ToolStripMenuItem deleteKeyToolButton;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripButton;
    }
}

