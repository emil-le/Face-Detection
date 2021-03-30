namespace DetectFace.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhanDang = new System.Windows.Forms.Button();
            this.btnHuanLuyen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgOutput = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgInput = new System.Windows.Forms.PictureBox();
            this.btnThemVaoTapHuanLuyen = new System.Windows.Forms.Button();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgLoading);
            this.panel1.Controls.Add(this.btnNhanDang);
            this.panel1.Controls.Add(this.btnHuanLuyen);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnThemVaoTapHuanLuyen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 758);
            this.panel1.TabIndex = 0;
            // 
            // btnNhanDang
            // 
            this.btnNhanDang.BackColor = System.Drawing.Color.White;
            this.btnNhanDang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanDang.Location = new System.Drawing.Point(271, 700);
            this.btnNhanDang.Name = "btnNhanDang";
            this.btnNhanDang.Size = new System.Drawing.Size(238, 45);
            this.btnNhanDang.TabIndex = 6;
            this.btnNhanDang.Text = "Nhận dạng";
            this.btnNhanDang.UseVisualStyleBackColor = false;
            this.btnNhanDang.Click += new System.EventHandler(this.btnNhanDang_Click);
            // 
            // btnHuanLuyen
            // 
            this.btnHuanLuyen.BackColor = System.Drawing.Color.White;
            this.btnHuanLuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuanLuyen.Location = new System.Drawing.Point(22, 11);
            this.btnHuanLuyen.Name = "btnHuanLuyen";
            this.btnHuanLuyen.Size = new System.Drawing.Size(239, 45);
            this.btnHuanLuyen.TabIndex = 5;
            this.btnHuanLuyen.Text = "Huấn luyện";
            this.btnHuanLuyen.UseVisualStyleBackColor = false;
            this.btnHuanLuyen.Click += new System.EventHandler(this.btnHuanLuyen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.imgOutput);
            this.groupBox2.Location = new System.Drawing.Point(535, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 614);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.AutoSize = true;
            this.txtKetQua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtKetQua.Location = new System.Drawing.Point(32, 55);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(67, 17);
            this.txtKetQua.TabIndex = 4;
            this.txtKetQua.Text = "unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả nhận dạng";
            // 
            // imgOutput
            // 
            this.imgOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgOutput.Location = new System.Drawing.Point(35, 95);
            this.imgOutput.Name = "imgOutput";
            this.imgOutput.Size = new System.Drawing.Size(413, 462);
            this.imgOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOutput.TabIndex = 1;
            this.imgOutput.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.imgInput);
            this.groupBox1.Location = new System.Drawing.Point(22, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 614);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh huấn luyện";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.White;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Location = new System.Drawing.Point(120, 563);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(226, 35);
            this.btnChonAnh.TabIndex = 3;
            this.btnChonAnh.Text = "Chọn ảnh ...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(31, 53);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(306, 24);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên người có ảnh huấn luyện";
            // 
            // imgInput
            // 
            this.imgInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgInput.Location = new System.Drawing.Point(31, 95);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(413, 462);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInput.TabIndex = 0;
            this.imgInput.TabStop = false;
            // 
            // btnThemVaoTapHuanLuyen
            // 
            this.btnThemVaoTapHuanLuyen.BackColor = System.Drawing.Color.White;
            this.btnThemVaoTapHuanLuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoTapHuanLuyen.Location = new System.Drawing.Point(22, 700);
            this.btnThemVaoTapHuanLuyen.Name = "btnThemVaoTapHuanLuyen";
            this.btnThemVaoTapHuanLuyen.Size = new System.Drawing.Size(243, 45);
            this.btnThemVaoTapHuanLuyen.TabIndex = 2;
            this.btnThemVaoTapHuanLuyen.Text = "Thêm vào tập huấn luyện";
            this.btnThemVaoTapHuanLuyen.UseVisualStyleBackColor = false;
            this.btnThemVaoTapHuanLuyen.Click += new System.EventHandler(this.btnThemVaoTapHuanLuyen_Click);
            // 
            // imgLoading
            // 
            this.imgLoading.BackColor = System.Drawing.Color.Transparent;
            this.imgLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLoading.Image = ((System.Drawing.Image)(resources.GetObject("imgLoading.Image")));
            this.imgLoading.Location = new System.Drawing.Point(431, 237);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(184, 138);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoading.TabIndex = 4;
            this.imgLoading.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1031, 758);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Nhận dạng khuôn mặt";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemVaoTapHuanLuyen;
        private System.Windows.Forms.Button btnHuanLuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNhanDang;
        private System.Windows.Forms.Label txtKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgOutput;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgInput;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox imgLoading;
    }
}