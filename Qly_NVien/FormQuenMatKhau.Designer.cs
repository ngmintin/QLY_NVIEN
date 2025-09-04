namespace Qly_NVien
{
    partial class FormQuenMatKhau
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
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            txbTenDangNhap = new TextBox();
            buttonXacNhan = new Button();
            label5 = new Label();
            LLDangNhap = new LinkLabel();
            LLDangKy = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 34);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 0;
            label1.Text = "Quên mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 76);
            label2.Name = "label2";
            label2.Size = new Size(326, 19);
            label2.TabIndex = 1;
            label2.Text = "Hãy nhập tên đăng nhập của bạn để lấy lại mật khẩu.\r\n";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(txbTenDangNhap, 0, 1);
            tableLayoutPanel1.Location = new Point(108, 149);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(325, 100);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(319, 50);
            label3.TabIndex = 0;
            label3.Text = "Tên đăng nhập:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Dock = DockStyle.Fill;
            txbTenDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTenDangNhap.Location = new Point(3, 53);
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(319, 26);
            txbTenDangNhap.TabIndex = 1;
            // 
            // buttonXacNhan
            // 
            buttonXacNhan.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXacNhan.Location = new Point(200, 282);
            buttonXacNhan.Name = "buttonXacNhan";
            buttonXacNhan.Size = new Size(135, 54);
            buttonXacNhan.TabIndex = 3;
            buttonXacNhan.Text = "Xác nhận";
            buttonXacNhan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(444, 390);
            label5.Name = "label5";
            label5.Size = new Size(16, 23);
            label5.TabIndex = 7;
            label5.Text = "/";
            // 
            // LLDangNhap
            // 
            LLDangNhap.AutoSize = true;
            LLDangNhap.Font = new Font("Times New Roman", 12F);
            LLDangNhap.Location = new Point(374, 390);
            LLDangNhap.Name = "LLDangNhap";
            LLDangNhap.Size = new Size(74, 19);
            LLDangNhap.TabIndex = 8;
            LLDangNhap.TabStop = true;
            LLDangNhap.Text = "Đăng nhập";
            // 
            // LLDangKy
            // 
            LLDangKy.AutoSize = true;
            LLDangKy.Font = new Font("Times New Roman", 12F);
            LLDangKy.Location = new Point(454, 390);
            LLDangKy.Name = "LLDangKy";
            LLDangKy.Size = new Size(60, 19);
            LLDangKy.TabIndex = 9;
            LLDangKy.TabStop = true;
            LLDangKy.Text = "Đăng ký";
            // 
            // FormQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(532, 432);
            Controls.Add(LLDangKy);
            Controls.Add(LLDangNhap);
            Controls.Add(label5);
            Controls.Add(buttonXacNhan);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQuenMatKhau";
            Text = "FormQuenMatKhau";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private TextBox txbTenDangNhap;
        private Button buttonXacNhan;
        private Label label5;
        private LinkLabel LLDangNhap;
        private LinkLabel LLDangKy;
    }
}