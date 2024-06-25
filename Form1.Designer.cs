namespace ClipCut_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblUrl = new Label();
            lblFileName = new Label();
            lblVideoMaxLength = new Label();
            txtUrl = new TextBox();
            txtFileName = new TextBox();
            numVideoMaxLength = new NumericUpDown();
            btnDownload = new Button();
            progressBar = new ProgressBar();
            btnBrowse = new Button();
            txtDirectory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numVideoMaxLength).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Window;
            lblTitle.Location = new Point(316, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ClipCut";
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUrl.ForeColor = SystemColors.Window;
            lblUrl.Location = new Point(30, 130);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(136, 23);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "YouTube URL:";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = SystemColors.Window;
            lblFileName.Location = new Point(30, 170);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(104, 23);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "File Name:";
            // 
            // lblVideoMaxLength
            // 
            lblVideoMaxLength.AutoSize = true;
            lblVideoMaxLength.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVideoMaxLength.ForeColor = SystemColors.Window;
            lblVideoMaxLength.Location = new Point(30, 210);
            lblVideoMaxLength.Name = "lblVideoMaxLength";
            lblVideoMaxLength.Size = new Size(270, 23);
            lblVideoMaxLength.TabIndex = 3;
            lblVideoMaxLength.Text = "Video Max Length (Seconds):";
            // 
            // txtUrl
            // 
            txtUrl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUrl.Location = new Point(304, 127);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(448, 30);
            txtUrl.TabIndex = 4;
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.ForeColor = SystemColors.WindowText;
            txtFileName.Location = new Point(304, 167);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(261, 30);
            txtFileName.TabIndex = 5;
            // 
            // numVideoMaxLength
            // 
            numVideoMaxLength.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numVideoMaxLength.Location = new Point(303, 206);
            numVideoMaxLength.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numVideoMaxLength.Name = "numVideoMaxLength";
            numVideoMaxLength.Size = new Size(150, 30);
            numVideoMaxLength.TabIndex = 6;
            numVideoMaxLength.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // btnDownload
            // 
            btnDownload.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(255, 252);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(270, 40);
            btnDownload.TabIndex = 7;
            btnDownload.Text = "Download and Cut Video";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.ForestGreen;
            progressBar.Location = new Point(125, 310);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(527, 29);
            progressBar.TabIndex = 8;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(601, 169);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(128, 28);
            btnBrowse.TabIndex = 9;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtDirectory
            // 
            txtDirectory.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDirectory.Location = new Point(459, 214);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.ReadOnly = true;
            txtDirectory.Size = new Size(293, 22);
            txtDirectory.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(782, 353);
            Controls.Add(txtDirectory);
            Controls.Add(btnBrowse);
            Controls.Add(progressBar);
            Controls.Add(btnDownload);
            Controls.Add(numVideoMaxLength);
            Controls.Add(txtFileName);
            Controls.Add(txtUrl);
            Controls.Add(lblVideoMaxLength);
            Controls.Add(lblFileName);
            Controls.Add(lblUrl);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "ClipCut";
            ((System.ComponentModel.ISupportInitialize)numVideoMaxLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUrl;
        private Label lblFileName;
        private Label lblVideoMaxLength;
        private TextBox txtUrl;
        private TextBox txtFileName;
        private NumericUpDown numVideoMaxLength;
        private Button btnDownload;
        private ProgressBar progressBar;
        private Button btnBrowse;
        private TextBox txtDirectory;
    }
}
