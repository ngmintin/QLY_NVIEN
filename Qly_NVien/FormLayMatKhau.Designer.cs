namespace Qly_NVien
{
    partial class FormLayMatKhau
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            txbMatKhauMoi = new TextBox();
            txbXacNhanLai = new TextBox();
            buttonXacNhan = new Button();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 60);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(txbMatKhauMoi, 0, 1);
            tableLayoutPanel2.Controls.Add(txbXacNhanLai, 0, 3);
            tableLayoutPanel2.Location = new Point(118, 141);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(291, 139);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(285, 34);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu mới:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(3, 68);
            label4.Name = "label4";
            label4.Size = new Size(285, 34);
            label4.TabIndex = 1;
            label4.Text = "Xác nhận lại mật khẩu mới:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbMatKhauMoi
            // 
            txbMatKhauMoi.Dock = DockStyle.Fill;
            txbMatKhauMoi.Font = new Font("Times New Roman", 14.25F);
            txbMatKhauMoi.ForeColor = Color.Gray;
            txbMatKhauMoi.Location = new Point(3, 37);
            txbMatKhauMoi.Name = "txbMatKhauMoi";
            txbMatKhauMoi.Size = new Size(285, 29);
            txbMatKhauMoi.TabIndex = 2;
            txbMatKhauMoi.Text = "Nhập mật khẩu";
            txbMatKhauMoi.Enter += txbMatKhauMoi_Enter;
            txbMatKhauMoi.Leave += txbMatKhauMoi_Leave;
            // 
            // txbXacNhanLai
            // 
            txbXacNhanLai.Dock = DockStyle.Fill;
            txbXacNhanLai.Font = new Font("Times New Roman", 14.25F);
            txbXacNhanLai.ForeColor = Color.Gray;
            txbXacNhanLai.Location = new Point(3, 105);
            txbXacNhanLai.Name = "txbXacNhanLai";
            txbXacNhanLai.Size = new Size(285, 29);
            txbXacNhanLai.TabIndex = 3;
            txbXacNhanLai.Text = "Xác nhận lại mật khẩu";
            txbXacNhanLai.Enter += txbXacNhanLai_Enter;
            txbXacNhanLai.Leave += txbXacNhanLai_Leave;
            // 
            // buttonXacNhan
            // 
            buttonXacNhan.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXacNhan.Location = new Point(195, 318);
            buttonXacNhan.Name = "buttonXacNhan";
            buttonXacNhan.Size = new Size(135, 54);
            buttonXacNhan.TabIndex = 3;
            buttonXacNhan.Text = "Xác nhận";
            buttonXacNhan.UseVisualStyleBackColor = true;
            // 
            // FormLayMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 432);
            Controls.Add(buttonXacNhan);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Name = "FormLayMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLayMatKhau";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private TextBox txbMatKhauMoi;
        private TextBox txbXacNhanLai;
        private Button buttonXacNhan;
    }
}