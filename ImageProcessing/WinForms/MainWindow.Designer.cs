namespace ImageProcessing
{
    partial class MainWindow
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
            this.uploadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTransformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdOptonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGrayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equlizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.histView = new System.Windows.Forms.PictureBox();
            this.rb_linear = new System.Windows.Forms.RadioButton();
            this.rb_log = new System.Windows.Forms.RadioButton();
            this.manualTresholdInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuHierarchicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadPictureToolStripMenuItem,
            this.colorTransformationToolStripMenuItem,
            this.equlizeToolStripMenuItem,
            this.normalizeToolStripMenuItem,
            this.quantizeToolStripMenuItem,
            this.binarizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1256, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uploadPictureToolStripMenuItem
            // 
            this.uploadPictureToolStripMenuItem.Name = "uploadPictureToolStripMenuItem";
            this.uploadPictureToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.uploadPictureToolStripMenuItem.Text = "Upload picture";
            this.uploadPictureToolStripMenuItem.Click += new System.EventHandler(this.uploadPictureToolStripMenuItem_Click);
            // 
            // colorTransformationToolStripMenuItem
            // 
            this.colorTransformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayWorldToolStripMenuItem,
            this.referenceColorToolStripMenuItem,
            this.thirdOptonToolStripMenuItem,
            this.toGrayScaleToolStripMenuItem});
            this.colorTransformationToolStripMenuItem.Name = "colorTransformationToolStripMenuItem";
            this.colorTransformationToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.colorTransformationToolStripMenuItem.Text = "ColorTransformation";
            // 
            // grayWorldToolStripMenuItem
            // 
            this.grayWorldToolStripMenuItem.Name = "grayWorldToolStripMenuItem";
            this.grayWorldToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.grayWorldToolStripMenuItem.Text = "GrayWorld";
            this.grayWorldToolStripMenuItem.Click += new System.EventHandler(this.grayWorldToolStripMenuItem_Click);
            // 
            // referenceColorToolStripMenuItem
            // 
            this.referenceColorToolStripMenuItem.Name = "referenceColorToolStripMenuItem";
            this.referenceColorToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.referenceColorToolStripMenuItem.Text = "ReferenceColor";
            this.referenceColorToolStripMenuItem.Click += new System.EventHandler(this.referenceColorToolStripMenuItem_Click);
            // 
            // thirdOptonToolStripMenuItem
            // 
            this.thirdOptonToolStripMenuItem.Name = "thirdOptonToolStripMenuItem";
            this.thirdOptonToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.thirdOptonToolStripMenuItem.Text = "ThirdOpton";
            // 
            // toGrayScaleToolStripMenuItem
            // 
            this.toGrayScaleToolStripMenuItem.Name = "toGrayScaleToolStripMenuItem";
            this.toGrayScaleToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.toGrayScaleToolStripMenuItem.Text = "ToGrayScale";
            this.toGrayScaleToolStripMenuItem.Click += new System.EventHandler(this.toGrayScaleToolStripMenuItem_Click);
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualTresholdInputToolStripMenuItem,
            this.localToolStripMenuItem,
            this.otsuLocalToolStripMenuItem,
            this.otsuHierarchicalToolStripMenuItem});
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.binarizeToolStripMenuItem.Text = "Binarize";
            // 
            // equlizeToolStripMenuItem
            // 
            this.equlizeToolStripMenuItem.Name = "equlizeToolStripMenuItem";
            this.equlizeToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.equlizeToolStripMenuItem.Text = "Equlize";
            this.equlizeToolStripMenuItem.Click += new System.EventHandler(this.equlizeToolStripMenuItem_Click);
            // 
            // normalizeToolStripMenuItem
            // 
            this.normalizeToolStripMenuItem.Name = "normalizeToolStripMenuItem";
            this.normalizeToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.normalizeToolStripMenuItem.Text = "Normalize";
            this.normalizeToolStripMenuItem.Click += new System.EventHandler(this.normalizeToolStripMenuItem_Click);
            // 
            // quantizeToolStripMenuItem
            // 
            this.quantizeToolStripMenuItem.Name = "quantizeToolStripMenuItem";
            this.quantizeToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.quantizeToolStripMenuItem.Text = "Quantize";
            this.quantizeToolStripMenuItem.Click += new System.EventHandler(this.quantizeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "All"});
            this.comboBox1.Location = new System.Drawing.Point(724, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Channel";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image";
            // 
            // histView
            // 
            this.histView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histView.Location = new System.Drawing.Point(644, 101);
            this.histView.Name = "histView";
            this.histView.Size = new System.Drawing.Size(550, 550);
            this.histView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histView.TabIndex = 5;
            this.histView.TabStop = false;
            // 
            // rb_linear
            // 
            this.rb_linear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_linear.AutoSize = true;
            this.rb_linear.Location = new System.Drawing.Point(1024, 55);
            this.rb_linear.Name = "rb_linear";
            this.rb_linear.Size = new System.Drawing.Size(78, 24);
            this.rb_linear.TabIndex = 6;
            this.rb_linear.TabStop = true;
            this.rb_linear.Text = "Linear";
            this.rb_linear.UseVisualStyleBackColor = true;
            this.rb_linear.CheckedChanged += new System.EventHandler(this.rb_linear_CheckedChanged);
            // 
            // rb_log
            // 
            this.rb_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_log.AutoSize = true;
            this.rb_log.Location = new System.Drawing.Point(1130, 55);
            this.rb_log.Name = "rb_log";
            this.rb_log.Size = new System.Drawing.Size(61, 24);
            this.rb_log.TabIndex = 7;
            this.rb_log.TabStop = true;
            this.rb_log.Text = "Log";
            this.rb_log.UseVisualStyleBackColor = true;
            this.rb_log.CheckedChanged += new System.EventHandler(this.rb_log_CheckedChanged);
            // 
            // manualTresholdInputToolStripMenuItem
            // 
            this.manualTresholdInputToolStripMenuItem.Name = "manualTresholdInputToolStripMenuItem";
            this.manualTresholdInputToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.manualTresholdInputToolStripMenuItem.Text = "Manual treshold input";
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.localToolStripMenuItem.Text = "Otsu | Global";
            // 
            // otsuLocalToolStripMenuItem
            // 
            this.otsuLocalToolStripMenuItem.Name = "otsuLocalToolStripMenuItem";
            this.otsuLocalToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.otsuLocalToolStripMenuItem.Text = "Otsu | Local";
            // 
            // otsuHierarchicalToolStripMenuItem
            // 
            this.otsuHierarchicalToolStripMenuItem.Name = "otsuHierarchicalToolStripMenuItem";
            this.otsuHierarchicalToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.otsuHierarchicalToolStripMenuItem.Text = "Otsu | Hierarchical";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 694);
            this.Controls.Add(this.rb_log);
            this.Controls.Add(this.rb_linear);
            this.Controls.Add(this.histView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "ImageProcessing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem uploadPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTransformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirdOptonToolStripMenuItem;
        private System.Windows.Forms.PictureBox histView;
        private System.Windows.Forms.RadioButton rb_linear;
        private System.Windows.Forms.RadioButton rb_log;
        private System.Windows.Forms.ToolStripMenuItem toGrayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equlizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualTresholdInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuHierarchicalToolStripMenuItem;
    }
}

