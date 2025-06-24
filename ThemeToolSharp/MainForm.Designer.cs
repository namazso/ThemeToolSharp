namespace ThemeToolSharp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxThemes = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.checkIgnoreBackground = new System.Windows.Forms.CheckBox();
            this.checkIgnoreCursor = new System.Windows.Forms.CheckBox();
            this.checkIgnoreDesktopIcons = new System.Windows.Forms.CheckBox();
            this.checkIgnoreColor = new System.Windows.Forms.CheckBox();
            this.checkIgnoreSound = new System.Windows.Forms.CheckBox();
            this.checkIgnoreScreensaver = new System.Windows.Forms.CheckBox();
            this.checkUnknown1 = new System.Windows.Forms.CheckBox();
            this.checkUnknown2 = new System.Windows.Forms.CheckBox();
            this.btnReInitialize = new System.Windows.Forms.Button();
            this.checkUnknownInit1 = new System.Windows.Forms.CheckBox();
            this.checkUnknownInit2 = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.checkLogonUI = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxThemes
            // 
            this.listBoxThemes.FormattingEnabled = true;
            this.listBoxThemes.Location = new System.Drawing.Point(12, 12);
            this.listBoxThemes.Name = "listBoxThemes";
            this.listBoxThemes.Size = new System.Drawing.Size(245, 329);
            this.listBoxThemes.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(263, 314);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 27);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkIgnoreBackground
            // 
            this.checkIgnoreBackground.Location = new System.Drawing.Point(263, 10);
            this.checkIgnoreBackground.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkIgnoreBackground.Name = "checkIgnoreBackground";
            this.checkIgnoreBackground.Size = new System.Drawing.Size(160, 18);
            this.checkIgnoreBackground.TabIndex = 1;
            this.checkIgnoreBackground.Text = "Ignore background";
            this.checkIgnoreBackground.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreCursor
            // 
            this.checkIgnoreCursor.Location = new System.Drawing.Point(263, 28);
            this.checkIgnoreCursor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkIgnoreCursor.Name = "checkIgnoreCursor";
            this.checkIgnoreCursor.Size = new System.Drawing.Size(160, 18);
            this.checkIgnoreCursor.TabIndex = 2;
            this.checkIgnoreCursor.Text = "Ignore cursor";
            this.checkIgnoreCursor.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreDesktopIcons
            // 
            this.checkIgnoreDesktopIcons.Location = new System.Drawing.Point(263, 46);
            this.checkIgnoreDesktopIcons.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkIgnoreDesktopIcons.Name = "checkIgnoreDesktopIcons";
            this.checkIgnoreDesktopIcons.Size = new System.Drawing.Size(160, 18);
            this.checkIgnoreDesktopIcons.TabIndex = 3;
            this.checkIgnoreDesktopIcons.Text = "Ignore desktop icons";
            this.checkIgnoreDesktopIcons.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreColor
            // 
            this.checkIgnoreColor.Location = new System.Drawing.Point(263, 64);
            this.checkIgnoreColor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkIgnoreColor.Name = "checkIgnoreColor";
            this.checkIgnoreColor.Size = new System.Drawing.Size(160, 18);
            this.checkIgnoreColor.TabIndex = 4;
            this.checkIgnoreColor.Text = "Ignore color";
            this.checkIgnoreColor.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreSound
            // 
            this.checkIgnoreSound.Location = new System.Drawing.Point(263, 82);
            this.checkIgnoreSound.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkIgnoreSound.Name = "checkIgnoreSound";
            this.checkIgnoreSound.Size = new System.Drawing.Size(160, 18);
            this.checkIgnoreSound.TabIndex = 5;
            this.checkIgnoreSound.Text = "Ignore sound";
            this.checkIgnoreSound.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreScreensaver
            // 
            this.checkIgnoreScreensaver.Location = new System.Drawing.Point(263, 100);
            this.checkIgnoreScreensaver.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkIgnoreScreensaver.Name = "checkIgnoreScreensaver";
            this.checkIgnoreScreensaver.Size = new System.Drawing.Size(160, 18);
            this.checkIgnoreScreensaver.TabIndex = 6;
            this.checkIgnoreScreensaver.Text = "Ignore screensaver";
            this.checkIgnoreScreensaver.UseVisualStyleBackColor = true;
            // 
            // checkUnknown1
            // 
            this.checkUnknown1.Location = new System.Drawing.Point(263, 118);
            this.checkUnknown1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkUnknown1.Name = "checkUnknown1";
            this.checkUnknown1.Size = new System.Drawing.Size(160, 18);
            this.checkUnknown1.TabIndex = 7;
            this.checkUnknown1.Text = "Unknown flag 1";
            this.checkUnknown1.UseVisualStyleBackColor = true;
            // 
            // checkUnknown2
            // 
            this.checkUnknown2.Location = new System.Drawing.Point(263, 136);
            this.checkUnknown2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkUnknown2.Name = "checkUnknown2";
            this.checkUnknown2.Size = new System.Drawing.Size(160, 18);
            this.checkUnknown2.TabIndex = 8;
            this.checkUnknown2.Text = "Unknown flag 2";
            this.checkUnknown2.UseVisualStyleBackColor = true;
            // 
            // btnReInitialize
            // 
            this.btnReInitialize.Location = new System.Drawing.Point(263, 281);
            this.btnReInitialize.Name = "btnReInitialize";
            this.btnReInitialize.Size = new System.Drawing.Size(160, 27);
            this.btnReInitialize.TabIndex = 13;
            this.btnReInitialize.Text = "Reinitialize";
            this.btnReInitialize.UseVisualStyleBackColor = true;
            this.btnReInitialize.Click += new System.EventHandler(this.btnReInitialize_Click);
            // 
            // checkUnknownInit1
            // 
            this.checkUnknownInit1.Location = new System.Drawing.Point(263, 242);
            this.checkUnknownInit1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkUnknownInit1.Name = "checkUnknownInit1";
            this.checkUnknownInit1.Size = new System.Drawing.Size(160, 18);
            this.checkUnknownInit1.TabIndex = 11;
            this.checkUnknownInit1.Text = "Unknown initialization flag 1";
            this.checkUnknownInit1.UseVisualStyleBackColor = true;
            // 
            // checkUnknownInit2
            // 
            this.checkUnknownInit2.Location = new System.Drawing.Point(263, 260);
            this.checkUnknownInit2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkUnknownInit2.Name = "checkUnknownInit2";
            this.checkUnknownInit2.Size = new System.Drawing.Size(160, 18);
            this.checkUnknownInit2.TabIndex = 12;
            this.checkUnknownInit2.Text = "Unknown initialization flag 2";
            this.checkUnknownInit2.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(263, 175);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(160, 27);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // checkLogonUI
            // 
            this.checkLogonUI.Location = new System.Drawing.Point(263, 154);
            this.checkLogonUI.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkLogonUI.Name = "checkLogonUI";
            this.checkLogonUI.Size = new System.Drawing.Size(160, 18);
            this.checkLogonUI.TabIndex = 9;
            this.checkLogonUI.Text = "Do not set LogonUI colors";
            this.checkLogonUI.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 353);
            this.Controls.Add(this.checkLogonUI);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.checkUnknownInit2);
            this.Controls.Add(this.checkUnknownInit1);
            this.Controls.Add(this.btnReInitialize);
            this.Controls.Add(this.checkUnknown2);
            this.Controls.Add(this.checkUnknown1);
            this.Controls.Add(this.checkIgnoreScreensaver);
            this.Controls.Add(this.checkIgnoreSound);
            this.Controls.Add(this.checkIgnoreColor);
            this.Controls.Add(this.checkIgnoreDesktopIcons);
            this.Controls.Add(this.checkIgnoreCursor);
            this.Controls.Add(this.checkIgnoreBackground);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listBoxThemes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ThemeToolSharp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox checkLogonUI;

        private System.Windows.Forms.Button btnReInitialize;
        private System.Windows.Forms.CheckBox checkUnknownInit1;
        private System.Windows.Forms.CheckBox checkUnknownInit2;

        private System.Windows.Forms.CheckBox checkUnknown1;
        private System.Windows.Forms.CheckBox checkUnknown2;

        private System.Windows.Forms.CheckBox checkIgnoreScreensaver;

        private System.Windows.Forms.CheckBox checkIgnoreSound;

        private System.Windows.Forms.CheckBox checkIgnoreColor;

        private System.Windows.Forms.CheckBox checkIgnoreDesktopIcons;

        private System.Windows.Forms.CheckBox checkIgnoreCursor;

        private System.Windows.Forms.CheckBox checkIgnoreBackground;

        private System.Windows.Forms.ListBox listBoxThemes;
        private System.Windows.Forms.Button btnRefresh;

        #endregion
    }
}