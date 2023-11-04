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
            btnOpenFile = new Button();
            lbResult = new ListBox();
            txtPath = new TextBox();
            btnHex = new Button();
            btnBinary = new Button();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(22, 21);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Open file...";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // lbResult
            // 
            lbResult.FormattingEnabled = true;
            lbResult.ItemHeight = 20;
            lbResult.Location = new Point(22, 56);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(768, 364);
            lbResult.TabIndex = 1;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(122, 21);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(516, 27);
            txtPath.TabIndex = 2;
            // 
            // btnHex
            // 
            btnHex.Location = new Point(644, 21);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(70, 30);
            btnHex.TabIndex = 4;
            btnHex.Text = "Hex";
            btnHex.UseVisualStyleBackColor = true;
            btnHex.Click += btnHex_Click;
            // 
            // btnBinary
            // 
            btnBinary.Location = new Point(720, 21);
            btnBinary.Name = "btnBinary";
            btnBinary.Size = new Size(70, 30);
            btnBinary.TabIndex = 5;
            btnBinary.Text = "Binary";
            btnBinary.UseVisualStyleBackColor = true;
            btnBinary.Click += btnBinary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBinary);
            Controls.Add(btnHex);
            Controls.Add(txtPath);
            Controls.Add(lbResult);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private ListBox lbResult;
        private TextBox txtPath;
        private Button btnHex;
        private Button btnBinary;
    }
}