namespace _22DH110144_NguyenVietAnh
{
    partial class Form1
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
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCham = new System.Windows.Forms.Button();
            this.btnNhanh = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbKetqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtThreads
            // 
            this.txtThreads.Location = new System.Drawing.Point(190, 15);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(243, 22);
            this.txtThreads.TabIndex = 0;
            this.txtThreads.TextChanged += new System.EventHandler(this.txtThreads_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số thread cần chạy :";
            // 
            // btnCham
            // 
            this.btnCham.Location = new System.Drawing.Point(439, 9);
            this.btnCham.Name = "btnCham";
            this.btnCham.Size = new System.Drawing.Size(146, 33);
            this.btnCham.TabIndex = 2;
            this.btnCham.Text = "Ưu tiên thấp";
            this.btnCham.UseVisualStyleBackColor = true;
            this.btnCham.Click += new System.EventHandler(this.btnCham_Click);
            // 
            // btnNhanh
            // 
            this.btnNhanh.Location = new System.Drawing.Point(591, 10);
            this.btnNhanh.Name = "btnNhanh";
            this.btnNhanh.Size = new System.Drawing.Size(167, 32);
            this.btnNhanh.TabIndex = 3;
            this.btnNhanh.Text = "Ưu tiên cao";
            this.btnNhanh.UseVisualStyleBackColor = true;
            this.btnNhanh.Click += new System.EventHandler(this.btnNhanh_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(764, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(210, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Tích 2 ma trận";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbKetqua
            // 
            this.lbKetqua.FormattingEnabled = true;
            this.lbKetqua.ItemHeight = 16;
            this.lbKetqua.Location = new System.Drawing.Point(15, 48);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(959, 484);
            this.lbKetqua.TabIndex = 5;
            this.lbKetqua.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 545);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNhanh);
            this.Controls.Add(this.btnCham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThreads);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCham;
        private System.Windows.Forms.Button btnNhanh;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbKetqua;
    }
}

