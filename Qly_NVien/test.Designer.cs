namespace Qly_NVien
{
    partial class test
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ID_TD = new DevExpress.XtraGrid.Columns.GridColumn();
            TENTD = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(99, 92);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(453, 271);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ID_TD, TENTD });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // ID_TD
            // 
            ID_TD.Caption = "ID";
            ID_TD.FieldName = "ID_TD";
            ID_TD.Name = "ID_TD";
            ID_TD.Visible = true;
            ID_TD.VisibleIndex = 0;
            // 
            // TENTD
            // 
            TENTD.Caption = "TÊN TRÌNH ĐỘ";
            TENTD.FieldName = "TENTD";
            TENTD.Name = "TENTD";
            TENTD.Visible = true;
            TENTD.VisibleIndex = 1;
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 470);
            Controls.Add(gridControl1);
            Name = "test";
            Text = "test";
            Load += test_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_TD;
        private DevExpress.XtraGrid.Columns.GridColumn TENTD;
    }
}