namespace Qly_NVien
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btThongBao = new DevExpress.XtraBars.BarButtonItem();
            btSuKien = new DevExpress.XtraBars.BarButtonItem();
            btCaLam = new DevExpress.XtraBars.BarButtonItem();
            btTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            btNhanVien = new DevExpress.XtraBars.BarButtonItem();
            btDieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            btKhenThuongKyLuat = new DevExpress.XtraBars.BarButtonItem();
            btBaoLoiGopY = new DevExpress.XtraBars.BarButtonItem();
            btThoiViec = new DevExpress.XtraBars.BarButtonItem();
            btHoSo = new DevExpress.XtraBars.BarButtonItem();
            btDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            btThoat = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupDangKy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageHoSo = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageChamCong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.EmptyAreaImageOptions.ImagePadding = new Padding(45, 44, 45, 44);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btThongBao, btSuKien, btCaLam, btTrinhDo, btNhanVien, btDieuChuyen, btKhenThuongKyLuat, btBaoLoiGopY, btThoiViec, btHoSo, btDoiMatKhau, btThoat });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4);
            ribbon.MaxItemId = 13;
            ribbon.Name = "ribbon";
            ribbon.OptionsMenuMinWidth = 495;
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPageHeThong, ribbonPageHoSo, ribbonPageChamCong });
            ribbon.Size = new Size(1432, 158);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btThongBao
            // 
            btThongBao.Caption = "Thông báo";
            btThongBao.Id = 1;
            btThongBao.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btThongBao.ImageOptions.SvgImage");
            btThongBao.Name = "btThongBao";
            btThongBao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btSuKien
            // 
            btSuKien.Caption = "Sự kiện";
            btSuKien.Id = 2;
            btSuKien.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btSuKien.ImageOptions.SvgImage");
            btSuKien.Name = "btSuKien";
            btSuKien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btCaLam
            // 
            btCaLam.Caption = "Ca làm";
            btCaLam.Id = 3;
            btCaLam.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btCaLam.ImageOptions.SvgImage");
            btCaLam.Name = "btCaLam";
            btCaLam.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btTrinhDo
            // 
            btTrinhDo.Caption = "Trình độ";
            btTrinhDo.Id = 4;
            btTrinhDo.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btTrinhDo.ImageOptions.SvgImage");
            btTrinhDo.Name = "btTrinhDo";
            btTrinhDo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btNhanVien
            // 
            btNhanVien.Caption = "Nhân viên";
            btNhanVien.Id = 5;
            btNhanVien.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btNhanVien.ImageOptions.SvgImage");
            btNhanVien.Name = "btNhanVien";
            btNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btDieuChuyen
            // 
            btDieuChuyen.Caption = "Điều chuyển";
            btDieuChuyen.Id = 6;
            btDieuChuyen.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btDieuChuyen.ImageOptions.SvgImage");
            btDieuChuyen.Name = "btDieuChuyen";
            btDieuChuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btKhenThuongKyLuat
            // 
            btKhenThuongKyLuat.Caption = "Khen thưởng - Kỷ luật";
            btKhenThuongKyLuat.Id = 7;
            btKhenThuongKyLuat.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btKhenThuongKyLuat.ImageOptions.SvgImage");
            btKhenThuongKyLuat.Name = "btKhenThuongKyLuat";
            btKhenThuongKyLuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btBaoLoiGopY
            // 
            btBaoLoiGopY.Caption = "Báo lỗi - Góp ý";
            btBaoLoiGopY.Id = 8;
            btBaoLoiGopY.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btBaoLoiGopY.ImageOptions.SvgImage");
            btBaoLoiGopY.Name = "btBaoLoiGopY";
            btBaoLoiGopY.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btThoiViec
            // 
            btThoiViec.Caption = "Thôi việc";
            btThoiViec.Id = 9;
            btThoiViec.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btThoiViec.ImageOptions.SvgImage");
            btThoiViec.Name = "btThoiViec";
            btThoiViec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btHoSo
            // 
            btHoSo.Caption = "Hồ sơ";
            btHoSo.Id = 10;
            btHoSo.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btHoSo.ImageOptions.SvgImage");
            btHoSo.Name = "btHoSo";
            btHoSo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btDoiMatKhau
            // 
            btDoiMatKhau.Caption = "Đổi mật khẩu";
            btDoiMatKhau.Id = 11;
            btDoiMatKhau.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btDoiMatKhau.ImageOptions.SvgImage");
            btDoiMatKhau.Name = "btDoiMatKhau";
            btDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btThoat
            // 
            btThoat.Caption = "Thoát";
            btThoat.Id = 12;
            btThoat.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btThoat.ImageOptions.SvgImage");
            btThoat.Name = "btThoat";
            btThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPageHeThong
            // 
            ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroupDangKy, ribbonPageGroup4 });
            ribbonPageHeThong.Name = "ribbonPageHeThong";
            ribbonPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btThongBao, true);
            ribbonPageGroup1.ItemLinks.Add(btSuKien, true);
            ribbonPageGroup1.ItemLinks.Add(btNhanVien, true);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Nội bộ";
            // 
            // ribbonPageGroupDangKy
            // 
            ribbonPageGroupDangKy.ItemLinks.Add(btCaLam, true);
            ribbonPageGroupDangKy.ItemLinks.Add(btTrinhDo, true);
            ribbonPageGroupDangKy.Name = "ribbonPageGroupDangKy";
            ribbonPageGroupDangKy.Text = "Đăng ký";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(btDieuChuyen, true);
            ribbonPageGroup4.ItemLinks.Add(btKhenThuongKyLuat, true);
            ribbonPageGroup4.ItemLinks.Add(btBaoLoiGopY, true);
            ribbonPageGroup4.ItemLinks.Add(btThoiViec, true);
            ribbonPageGroup4.ItemLinks.Add(btThoat, true);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Nghiệp vụ";
            // 
            // ribbonPageHoSo
            // 
            ribbonPageHoSo.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribbonPageHoSo.Name = "ribbonPageHoSo";
            ribbonPageHoSo.Text = "Cá nhân";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btHoSo, true);
            ribbonPageGroup2.ItemLinks.Add(btDoiMatKhau, true);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Tài khoản";
            // 
            // ribbonPageChamCong
            // 
            ribbonPageChamCong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
            ribbonPageChamCong.Name = "ribbonPageChamCong";
            ribbonPageChamCong.Text = "Chấm công";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 858);
            ribbonStatusBar.Margin = new Padding(4);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1432, 24);
            // 
            // FormTrangChu
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 882);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormTrangChu";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "Trang Chủ";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btThongBao;
        private DevExpress.XtraBars.BarButtonItem btSuKien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHoSo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageChamCong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btCaLam;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDangKy;
        private DevExpress.XtraBars.BarButtonItem btTrinhDo;
        private DevExpress.XtraBars.BarButtonItem btNhanVien;
        private DevExpress.XtraBars.BarButtonItem btDieuChuyen;
        private DevExpress.XtraBars.BarButtonItem btKhenThuongKyLuat;
        private DevExpress.XtraBars.BarButtonItem btBaoLoiGopY;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btThoiViec;
        private DevExpress.XtraBars.BarButtonItem btHoSo;
        private DevExpress.XtraBars.BarButtonItem btDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btThoat;
    }
}