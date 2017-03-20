namespace ImageProcessing.WinForms
{
    partial class RefColorTransformWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPickDestClr = new System.Windows.Forms.Button();
            this.destPicBox = new System.Windows.Forms.PictureBox();
            this.srcPicBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnTransform = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.saveImageToolStripMenuItem.Text = "Save image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click to set source color";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPickDestClr);
            this.panel1.Controls.Add(this.destPicBox);
            this.panel1.Controls.Add(this.srcPicBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 100);
            this.panel1.TabIndex = 5;
            // 
            // btnPickDestClr
            // 
            this.btnPickDestClr.Location = new System.Drawing.Point(211, 57);
            this.btnPickDestClr.Name = "btnPickDestClr";
            this.btnPickDestClr.Size = new System.Drawing.Size(128, 34);
            this.btnPickDestClr.TabIndex = 5;
            this.btnPickDestClr.Text = "Pick another";
            this.btnPickDestClr.UseVisualStyleBackColor = true;
            this.btnPickDestClr.Click += new System.EventHandler(this.btnPickDestClr_Click);
            // 
            // destPicBox
            // 
            this.destPicBox.BackColor = System.Drawing.SystemColors.Control;
            this.destPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destPicBox.Location = new System.Drawing.Point(17, 59);
            this.destPicBox.Name = "destPicBox";
            this.destPicBox.Size = new System.Drawing.Size(25, 25);
            this.destPicBox.TabIndex = 4;
            this.destPicBox.TabStop = false;
            // 
            // srcPicBox
            // 
            this.srcPicBox.BackColor = System.Drawing.SystemColors.Control;
            this.srcPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcPicBox.Location = new System.Drawing.Point(17, 16);
            this.srcPicBox.Name = "srcPicBox";
            this.srcPicBox.Size = new System.Drawing.Size(25, 25);
            this.srcPicBox.TabIndex = 3;
            this.srcPicBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destination color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Source color";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(12, 718);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(500, 34);
            this.btnTransform.TabIndex = 6;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // RefColorTransformWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 762);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RefColorTransformWindow";
            this.Text = "RefColorTransformWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPickDestClr;
        private System.Windows.Forms.PictureBox destPicBox;
        private System.Windows.Forms.PictureBox srcPicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnTransform;
    }
}