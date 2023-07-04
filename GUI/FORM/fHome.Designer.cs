﻿namespace GUI
{
    partial class fHome
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
            this.container = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.butTraCuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butTTTK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.errorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.container.SuspendLayout();
            this.siticoneGradientPanel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.container.Controls.Add(this.siticoneGradientPanel1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 58);
            this.container.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1012, 582);
            this.container.TabIndex = 7;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Controls.Add(this.butTraCuu);
            this.siticoneGradientPanel1.Controls.Add(this.butTTTK);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1012, 64);
            this.siticoneGradientPanel1.TabIndex = 4;
            // 
            // butTraCuu
            // 
            this.butTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.butTraCuu.BorderColor = System.Drawing.Color.Transparent;
            this.butTraCuu.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTraCuu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTraCuu.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butTraCuu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTraCuu.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butTraCuu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTraCuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTraCuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTraCuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTraCuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTraCuu.FillColor = System.Drawing.Color.Transparent;
            this.butTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTraCuu.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butTraCuu.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTraCuu.Location = new System.Drawing.Point(274, 0);
            this.butTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butTraCuu.Name = "butTraCuu";
            this.butTraCuu.Size = new System.Drawing.Size(274, 64);
            this.butTraCuu.TabIndex = 1;
            this.butTraCuu.Text = "Tra cứu sách";
            this.butTraCuu.Click += new System.EventHandler(this.butTraCuu_Click);
            // 
            // butTTTK
            // 
            this.butTTTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.butTTTK.BorderColor = System.Drawing.Color.Transparent;
            this.butTTTK.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTTTK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTTTK.CheckedState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.butTTTK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTTTK.CheckedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.butTTTK.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTTTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTTTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTTTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTTTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTTTK.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTTTK.FillColor = System.Drawing.Color.Transparent;
            this.butTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTTTK.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.butTTTK.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTTTK.Location = new System.Drawing.Point(0, 0);
            this.butTTTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butTTTK.Name = "butTTTK";
            this.butTTTK.Size = new System.Drawing.Size(274, 64);
            this.butTTTK.TabIndex = 0;
            this.butTTTK.Text = "Thông tin tài khoản";
            this.butTTTK.Click += new System.EventHandler(this.butTTTK_Click);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.topPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.exitControlBox);
            this.topPanel.Controls.Add(this.siticoneControlBox1);
            this.topPanel.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.topPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.FillColor = System.Drawing.Color.SlateBlue;
            this.topPanel.ForeColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1012, 58);
            this.topPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "UIT LIBRARY";
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.FillColor = System.Drawing.Color.Transparent;
            this.exitControlBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(948, 0);
            this.exitControlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.Size = new System.Drawing.Size(62, 54);
            this.exitControlBox.TabIndex = 0;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(890, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(59, 54);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // errorDia
            // 
            this.errorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.errorDia.Caption = null;
            this.errorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.errorDia.Parent = null;
            this.errorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.errorDia.Text = null;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 640);
            this.Controls.Add(this.container);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHome";
            this.container.ResumeLayout(false);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel container;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog errorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTraCuu;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTTTK;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exitControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}