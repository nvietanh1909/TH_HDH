namespace _22DH110144_NguyenVietAnh
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
            btnBrowse = new Button();
            txtPath = new TextBox();
            btnStart = new Button();
            label1 = new Label();
            lbOutput = new ListBox();
            btnRefresh = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(23, 20);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(140, 20);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(809, 27);
            txtPath.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(965, 20);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(93, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.Size = new Size(301, 20);
            label1.TabIndex = 3;
            label1.Text = "Các process ₫ã ₫ược kích hoạt và ₫ang chạy";
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.ItemHeight = 20;
            lbOutput.Location = new Point(27, 101);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(1031, 364);
            lbOutput.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(27, 487);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(149, 52);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(926, 484);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(132, 58);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 564);
            Controls.Add(btnStop);
            Controls.Add(btnRefresh);
            Controls.Add(lbOutput);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(txtPath);
            Controls.Add(btnBrowse);
            Name = "Form1";
            Text = "Quản lý process";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private TextBox txtPath;
        private Button btnStart;
        private Label label1;
        private ListBox lbOutput;
        private Button btnRefresh;
        private Button btnStop;
    }
}