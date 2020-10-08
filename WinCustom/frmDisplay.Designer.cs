﻿namespace WinCustom
{
    partial class frmDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplay));
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTitle = new System.Windows.Forms.Label();
            this.bottom = new System.Windows.Forms.Panel();
            this.mainPrevious = new System.Windows.Forms.Button();
            this.mainNext = new System.Windows.Forms.Button();
            this.mainCheckBox = new CustomCheckBox();
            this.mainSubtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Image = global::WinCustom.Properties.Resources.context;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 39);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(800, 266);
            this.mainPictureBox.TabIndex = 7;
            this.mainPictureBox.TabStop = false;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoEllipsis = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(0, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(800, 36);
            this.mainTitle.TabIndex = 9;
            this.mainTitle.Text = "Copy directory path";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bottom.Controls.Add(this.mainPrevious);
            this.bottom.Controls.Add(this.mainNext);
            this.bottom.Controls.Add(this.mainCheckBox);
            this.bottom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom.Location = new System.Drawing.Point(0, 340);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(800, 80);
            this.bottom.TabIndex = 10;
            // 
            // mainPrevious
            // 
            this.mainPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainPrevious.BackgroundImage = global::WinCustom.Properties.Resources.next_button1;
            this.mainPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainPrevious.FlatAppearance.BorderSize = 0;
            this.mainPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPrevious.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainPrevious.ForeColor = System.Drawing.Color.White;
            this.mainPrevious.Location = new System.Drawing.Point(242, 19);
            this.mainPrevious.Name = "mainPrevious";
            this.mainPrevious.Size = new System.Drawing.Size(38, 38);
            this.mainPrevious.TabIndex = 11;
            this.mainPrevious.UseVisualStyleBackColor = false;
            this.mainPrevious.Click += new System.EventHandler(this.mainPrevious_Click);
            this.mainPrevious.MouseEnter += new System.EventHandler(this.mainPrevious_MouseEnter);
            this.mainPrevious.MouseLeave += new System.EventHandler(this.mainPrevious_MouseLeave);
            // 
            // mainNext
            // 
            this.mainNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainNext.BackgroundImage")));
            this.mainNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainNext.FlatAppearance.BorderSize = 0;
            this.mainNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainNext.ForeColor = System.Drawing.Color.White;
            this.mainNext.Location = new System.Drawing.Point(513, 19);
            this.mainNext.Name = "mainNext";
            this.mainNext.Size = new System.Drawing.Size(38, 38);
            this.mainNext.TabIndex = 10;
            this.mainNext.UseVisualStyleBackColor = false;
            this.mainNext.Click += new System.EventHandler(this.mainNext_Click);
            this.mainNext.MouseEnter += new System.EventHandler(this.mainNext_MouseEnter);
            this.mainNext.MouseLeave += new System.EventHandler(this.mainNext_MouseLeave);
            // 
            // mainCheckBox
            // 
            this.mainCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainCheckBox.Location = new System.Drawing.Point(362, 19);
            this.mainCheckBox.Name = "mainCheckBox";
            this.mainCheckBox.Padding = new System.Windows.Forms.Padding(6);
            this.mainCheckBox.Size = new System.Drawing.Size(77, 38);
            this.mainCheckBox.TabIndex = 9;
            this.mainCheckBox.UseVisualStyleBackColor = true;
            this.mainCheckBox.CheckedChanged += new System.EventHandler(this.mainCheckBox_CheckedChanged);
            // 
            // mainSubtitle
            // 
            this.mainSubtitle.AutoEllipsis = true;
            this.mainSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.mainSubtitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainSubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSubtitle.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSubtitle.ForeColor = System.Drawing.Color.White;
            this.mainSubtitle.Location = new System.Drawing.Point(1, 310);
            this.mainSubtitle.Name = "mainSubtitle";
            this.mainSubtitle.Size = new System.Drawing.Size(800, 26);
            this.mainSubtitle.TabIndex = 12;
            this.mainSubtitle.Text = "Adds the option to copy directory path in file context menu";
            this.mainSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.mainSubtitle);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.bottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bottom;
        public CustomCheckBox mainCheckBox;
        public System.Windows.Forms.Button mainPrevious;
        public System.Windows.Forms.Label mainTitle;
        public System.Windows.Forms.Label mainSubtitle;
        public System.Windows.Forms.PictureBox mainPictureBox;
        public System.Windows.Forms.Button mainNext;
    }
}