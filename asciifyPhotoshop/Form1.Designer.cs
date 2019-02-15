namespace asciifyPhotoshop
{
    partial class asciify_Form
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
            this.lblRange1 = new System.Windows.Forms.Label();
            this.picNormal = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.picGray = new System.Windows.Forms.PictureBox();
            this.rtxShowAscii = new System.Windows.Forms.RichTextBox();
            this.lblRange6 = new System.Windows.Forms.Label();
            this.lblRange5 = new System.Windows.Forms.Label();
            this.lblRange4 = new System.Windows.Forms.Label();
            this.lblRange3 = new System.Windows.Forms.Label();
            this.lblRange2 = new System.Windows.Forms.Label();
            this.txtRange1_Char = new System.Windows.Forms.TextBox();
            this.txtRange6_Char = new System.Windows.Forms.TextBox();
            this.txtRange5_Char = new System.Windows.Forms.TextBox();
            this.txtRange4_Char = new System.Windows.Forms.TextBox();
            this.txtRange3_Char = new System.Windows.Forms.TextBox();
            this.txtRange2_Char = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numWidth_dec = new System.Windows.Forms.NumericUpDown();
            this.numHeight_dec = new System.Windows.Forms.NumericUpDown();
            this.btnAsciify = new System.Windows.Forms.Button();
            this.diaImportFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth_dec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight_dec)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRange1
            // 
            this.lblRange1.AutoSize = true;
            this.lblRange1.Location = new System.Drawing.Point(270, 31);
            this.lblRange1.Name = "lblRange1";
            this.lblRange1.Size = new System.Drawing.Size(133, 15);
            this.lblRange1.TabIndex = 1;
            this.lblRange1.Text = "Range 1 Character:";
            // 
            // picNormal
            // 
            this.picNormal.Location = new System.Drawing.Point(14, 31);
            this.picNormal.MaximumSize = new System.Drawing.Size(250, 300);
            this.picNormal.MinimumSize = new System.Drawing.Size(250, 250);
            this.picNormal.Name = "picNormal";
            this.picNormal.Size = new System.Drawing.Size(250, 300);
            this.picNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNormal.TabIndex = 6;
            this.picNormal.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImport});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuImport
            // 
            this.menuImport.Name = "menuImport";
            this.menuImport.Size = new System.Drawing.Size(110, 22);
            this.menuImport.Text = "Import";
            this.menuImport.Click += new System.EventHandler(this.menuImport_Click);
            // 
            // picGray
            // 
            this.picGray.Location = new System.Drawing.Point(12, 549);
            this.picGray.MaximumSize = new System.Drawing.Size(250, 300);
            this.picGray.MinimumSize = new System.Drawing.Size(250, 250);
            this.picGray.Name = "picGray";
            this.picGray.Size = new System.Drawing.Size(250, 300);
            this.picGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGray.TabIndex = 9;
            this.picGray.TabStop = false;
            // 
            // rtxShowAscii
            // 
            this.rtxShowAscii.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxShowAscii.Location = new System.Drawing.Point(409, 31);
            this.rtxShowAscii.Name = "rtxShowAscii";
            this.rtxShowAscii.Size = new System.Drawing.Size(563, 818);
            this.rtxShowAscii.TabIndex = 10;
            this.rtxShowAscii.Text = "";
            this.rtxShowAscii.WordWrap = false;
            // 
            // lblRange6
            // 
            this.lblRange6.AutoSize = true;
            this.lblRange6.Location = new System.Drawing.Point(267, 251);
            this.lblRange6.Name = "lblRange6";
            this.lblRange6.Size = new System.Drawing.Size(133, 15);
            this.lblRange6.TabIndex = 11;
            this.lblRange6.Text = "Range 6 Character:";
            // 
            // lblRange5
            // 
            this.lblRange5.AutoSize = true;
            this.lblRange5.Location = new System.Drawing.Point(267, 207);
            this.lblRange5.Name = "lblRange5";
            this.lblRange5.Size = new System.Drawing.Size(133, 15);
            this.lblRange5.TabIndex = 12;
            this.lblRange5.Text = "Range 5 Character:";
            // 
            // lblRange4
            // 
            this.lblRange4.AutoSize = true;
            this.lblRange4.Location = new System.Drawing.Point(270, 163);
            this.lblRange4.Name = "lblRange4";
            this.lblRange4.Size = new System.Drawing.Size(133, 15);
            this.lblRange4.TabIndex = 13;
            this.lblRange4.Text = "Range 4 Character:";
            // 
            // lblRange3
            // 
            this.lblRange3.AutoSize = true;
            this.lblRange3.Location = new System.Drawing.Point(270, 119);
            this.lblRange3.Name = "lblRange3";
            this.lblRange3.Size = new System.Drawing.Size(133, 15);
            this.lblRange3.TabIndex = 14;
            this.lblRange3.Text = "Range 3 Character:";
            // 
            // lblRange2
            // 
            this.lblRange2.AutoSize = true;
            this.lblRange2.Location = new System.Drawing.Point(270, 75);
            this.lblRange2.Name = "lblRange2";
            this.lblRange2.Size = new System.Drawing.Size(133, 15);
            this.lblRange2.TabIndex = 15;
            this.lblRange2.Text = "Range 2 Character:";
            // 
            // txtRange1_Char
            // 
            this.txtRange1_Char.Location = new System.Drawing.Point(283, 49);
            this.txtRange1_Char.MaxLength = 1;
            this.txtRange1_Char.Name = "txtRange1_Char";
            this.txtRange1_Char.Size = new System.Drawing.Size(120, 23);
            this.txtRange1_Char.TabIndex = 16;
            this.txtRange1_Char.Text = "#";
            // 
            // txtRange6_Char
            // 
            this.txtRange6_Char.Location = new System.Drawing.Point(283, 269);
            this.txtRange6_Char.MaxLength = 1;
            this.txtRange6_Char.Name = "txtRange6_Char";
            this.txtRange6_Char.Size = new System.Drawing.Size(120, 23);
            this.txtRange6_Char.TabIndex = 18;
            this.txtRange6_Char.Text = ".";
            // 
            // txtRange5_Char
            // 
            this.txtRange5_Char.Location = new System.Drawing.Point(283, 225);
            this.txtRange5_Char.MaxLength = 1;
            this.txtRange5_Char.Name = "txtRange5_Char";
            this.txtRange5_Char.Size = new System.Drawing.Size(120, 23);
            this.txtRange5_Char.TabIndex = 19;
            this.txtRange5_Char.Text = "*";
            // 
            // txtRange4_Char
            // 
            this.txtRange4_Char.Location = new System.Drawing.Point(283, 181);
            this.txtRange4_Char.MaxLength = 1;
            this.txtRange4_Char.Name = "txtRange4_Char";
            this.txtRange4_Char.Size = new System.Drawing.Size(120, 23);
            this.txtRange4_Char.TabIndex = 20;
            this.txtRange4_Char.Text = "~";
            // 
            // txtRange3_Char
            // 
            this.txtRange3_Char.Location = new System.Drawing.Point(283, 137);
            this.txtRange3_Char.MaxLength = 1;
            this.txtRange3_Char.Name = "txtRange3_Char";
            this.txtRange3_Char.Size = new System.Drawing.Size(120, 23);
            this.txtRange3_Char.TabIndex = 21;
            this.txtRange3_Char.Text = "!";
            // 
            // txtRange2_Char
            // 
            this.txtRange2_Char.Location = new System.Drawing.Point(283, 93);
            this.txtRange2_Char.MaxLength = 1;
            this.txtRange2_Char.Name = "txtRange2_Char";
            this.txtRange2_Char.Size = new System.Drawing.Size(120, 23);
            this.txtRange2_Char.TabIndex = 22;
            this.txtRange2_Char.Text = "+";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(267, 295);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(98, 15);
            this.lblWidth.TabIndex = 23;
            this.lblWidth.Text = "Kernel Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kernel Height:";
            // 
            // numWidth_dec
            // 
            this.numWidth_dec.Location = new System.Drawing.Point(283, 313);
            this.numWidth_dec.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numWidth_dec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth_dec.Name = "numWidth_dec";
            this.numWidth_dec.Size = new System.Drawing.Size(120, 23);
            this.numWidth_dec.TabIndex = 27;
            this.numWidth_dec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHeight_dec
            // 
            this.numHeight_dec.Location = new System.Drawing.Point(280, 357);
            this.numHeight_dec.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numHeight_dec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight_dec.Name = "numHeight_dec";
            this.numHeight_dec.Size = new System.Drawing.Size(120, 23);
            this.numHeight_dec.TabIndex = 28;
            this.numHeight_dec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAsciify
            // 
            this.btnAsciify.BackColor = System.Drawing.Color.Black;
            this.btnAsciify.ForeColor = System.Drawing.Color.Silver;
            this.btnAsciify.Location = new System.Drawing.Point(270, 619);
            this.btnAsciify.Name = "btnAsciify";
            this.btnAsciify.Size = new System.Drawing.Size(133, 30);
            this.btnAsciify.TabIndex = 29;
            this.btnAsciify.Text = "Asciify";
            this.btnAsciify.UseVisualStyleBackColor = false;
            this.btnAsciify.Click += new System.EventHandler(this.btnAsciify_Click);
            // 
            // diaImportFile
            // 
            this.diaImportFile.Filter = "Image files (*.jpg, *.tiff, *.gif, *.bmp, *.png) | *.jpg; *.tiff; *.gif; *.bmp; *" +
    ".png";
            this.diaImportFile.InitialDirectory = "C:\\\\";
            this.diaImportFile.RestoreDirectory = true;
            // 
            // asciify_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.btnAsciify);
            this.Controls.Add(this.numHeight_dec);
            this.Controls.Add(this.numWidth_dec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtRange2_Char);
            this.Controls.Add(this.txtRange3_Char);
            this.Controls.Add(this.txtRange4_Char);
            this.Controls.Add(this.txtRange5_Char);
            this.Controls.Add(this.txtRange6_Char);
            this.Controls.Add(this.txtRange1_Char);
            this.Controls.Add(this.lblRange2);
            this.Controls.Add(this.lblRange3);
            this.Controls.Add(this.lblRange4);
            this.Controls.Add(this.lblRange5);
            this.Controls.Add(this.lblRange6);
            this.Controls.Add(this.rtxShowAscii);
            this.Controls.Add(this.picGray);
            this.Controls.Add(this.picNormal);
            this.Controls.Add(this.lblRange1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 900);
            this.MinimumSize = new System.Drawing.Size(1000, 900);
            this.Name = "asciify_Form";
            this.Text = "Asciify";
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth_dec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight_dec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRange1;
        private System.Windows.Forms.PictureBox picNormal;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImport;
        private System.Windows.Forms.PictureBox picGray;
        private System.Windows.Forms.Label lblRange6;
        private System.Windows.Forms.Label lblRange5;
        private System.Windows.Forms.Label lblRange4;
        private System.Windows.Forms.Label lblRange3;
        private System.Windows.Forms.Label lblRange2;
        private System.Windows.Forms.TextBox txtRange1_Char;
        private System.Windows.Forms.TextBox txtRange6_Char;
        private System.Windows.Forms.TextBox txtRange5_Char;
        private System.Windows.Forms.TextBox txtRange4_Char;
        private System.Windows.Forms.TextBox txtRange3_Char;
        private System.Windows.Forms.TextBox txtRange2_Char;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RichTextBox rtxShowAscii;
        private System.Windows.Forms.NumericUpDown numWidth_dec;
        private System.Windows.Forms.NumericUpDown numHeight_dec;
        private System.Windows.Forms.Button btnAsciify;
        private System.Windows.Forms.OpenFileDialog diaImportFile;
    }
}

