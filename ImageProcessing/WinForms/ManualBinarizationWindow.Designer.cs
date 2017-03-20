namespace ImageProcessing.WinForms
{
    partial class ManualBinarizationWindow
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
            this.srcImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonUpper = new System.Windows.Forms.RadioButton();
            this.radioButtonLower = new System.Windows.Forms.RadioButton();
            this.radioButtonRange = new System.Windows.Forms.RadioButton();
            this.upperThershold = new System.Windows.Forms.NumericUpDown();
            this.lowerThershold = new System.Windows.Forms.NumericUpDown();
            this.rangeThersholdFrom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rangeThersholdTo = new System.Windows.Forms.NumericUpDown();
            this.btnBinarize = new System.Windows.Forms.Button();
            this.destImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperThershold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerThershold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeThersholdFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeThersholdTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destImage)).BeginInit();
            this.SuspendLayout();
            // 
            // srcImage
            // 
            this.srcImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcImage.Location = new System.Drawing.Point(12, 49);
            this.srcImage.Name = "srcImage";
            this.srcImage.Size = new System.Drawing.Size(382, 366);
            this.srcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.srcImage.TabIndex = 2;
            this.srcImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // radioButtonUpper
            // 
            this.radioButtonUpper.AutoSize = true;
            this.radioButtonUpper.Location = new System.Drawing.Point(21, 442);
            this.radioButtonUpper.Name = "radioButtonUpper";
            this.radioButtonUpper.Size = new System.Drawing.Size(148, 24);
            this.radioButtonUpper.TabIndex = 4;
            this.radioButtonUpper.TabStop = true;
            this.radioButtonUpper.Text = "Upper treshhold";
            this.radioButtonUpper.UseVisualStyleBackColor = true;
            this.radioButtonUpper.CheckedChanged += new System.EventHandler(this.radioButtonUpper_CheckedChanged);
            // 
            // radioButtonLower
            // 
            this.radioButtonLower.AutoSize = true;
            this.radioButtonLower.Location = new System.Drawing.Point(21, 484);
            this.radioButtonLower.Name = "radioButtonLower";
            this.radioButtonLower.Size = new System.Drawing.Size(147, 24);
            this.radioButtonLower.TabIndex = 5;
            this.radioButtonLower.TabStop = true;
            this.radioButtonLower.Text = "Lower treshhold";
            this.radioButtonLower.UseVisualStyleBackColor = true;
            this.radioButtonLower.CheckedChanged += new System.EventHandler(this.radioButtonLower_CheckedChanged);
            // 
            // radioButtonRange
            // 
            this.radioButtonRange.AutoSize = true;
            this.radioButtonRange.Location = new System.Drawing.Point(21, 527);
            this.radioButtonRange.Name = "radioButtonRange";
            this.radioButtonRange.Size = new System.Drawing.Size(113, 24);
            this.radioButtonRange.TabIndex = 6;
            this.radioButtonRange.TabStop = true;
            this.radioButtonRange.Text = "On a range";
            this.radioButtonRange.UseVisualStyleBackColor = true;
            this.radioButtonRange.CheckedChanged += new System.EventHandler(this.radioButtonRange_CheckedChanged);
            // 
            // upperThershold
            // 
            this.upperThershold.Location = new System.Drawing.Point(195, 442);
            this.upperThershold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upperThershold.Name = "upperThershold";
            this.upperThershold.Size = new System.Drawing.Size(158, 26);
            this.upperThershold.TabIndex = 7;
            // 
            // lowerThershold
            // 
            this.lowerThershold.Location = new System.Drawing.Point(195, 484);
            this.lowerThershold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.lowerThershold.Name = "lowerThershold";
            this.lowerThershold.Size = new System.Drawing.Size(158, 26);
            this.lowerThershold.TabIndex = 8;
            // 
            // rangeThersholdFrom
            // 
            this.rangeThersholdFrom.Location = new System.Drawing.Point(196, 527);
            this.rangeThersholdFrom.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rangeThersholdFrom.Name = "rangeThersholdFrom";
            this.rangeThersholdFrom.Size = new System.Drawing.Size(61, 26);
            this.rangeThersholdFrom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "to";
            // 
            // rangeThersholdTo
            // 
            this.rangeThersholdTo.Location = new System.Drawing.Point(292, 527);
            this.rangeThersholdTo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rangeThersholdTo.Name = "rangeThersholdTo";
            this.rangeThersholdTo.Size = new System.Drawing.Size(61, 26);
            this.rangeThersholdTo.TabIndex = 11;
            this.rangeThersholdTo.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // btnBinarize
            // 
            this.btnBinarize.Location = new System.Drawing.Point(433, 518);
            this.btnBinarize.Name = "btnBinarize";
            this.btnBinarize.Size = new System.Drawing.Size(382, 31);
            this.btnBinarize.TabIndex = 12;
            this.btnBinarize.Text = "Binarize it!";
            this.btnBinarize.UseVisualStyleBackColor = true;
            this.btnBinarize.Click += new System.EventHandler(this.btnBinarize_Click);
            // 
            // destImage
            // 
            this.destImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destImage.Location = new System.Drawing.Point(433, 49);
            this.destImage.Name = "destImage";
            this.destImage.Size = new System.Drawing.Size(382, 366);
            this.destImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.destImage.TabIndex = 13;
            this.destImage.TabStop = false;
            // 
            // ManualBinarizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 571);
            this.Controls.Add(this.destImage);
            this.Controls.Add(this.btnBinarize);
            this.Controls.Add(this.rangeThersholdTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rangeThersholdFrom);
            this.Controls.Add(this.lowerThershold);
            this.Controls.Add(this.upperThershold);
            this.Controls.Add(this.radioButtonRange);
            this.Controls.Add(this.radioButtonLower);
            this.Controls.Add(this.radioButtonUpper);
            this.Controls.Add(this.srcImage);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManualBinarizationWindow";
            this.Text = "Manual Thresholding";
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperThershold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerThershold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeThersholdFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeThersholdTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox srcImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonUpper;
        private System.Windows.Forms.RadioButton radioButtonLower;
        private System.Windows.Forms.RadioButton radioButtonRange;
        private System.Windows.Forms.NumericUpDown upperThershold;
        private System.Windows.Forms.NumericUpDown lowerThershold;
        private System.Windows.Forms.NumericUpDown rangeThersholdFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rangeThersholdTo;
        private System.Windows.Forms.Button btnBinarize;
        private System.Windows.Forms.PictureBox destImage;
    }
}