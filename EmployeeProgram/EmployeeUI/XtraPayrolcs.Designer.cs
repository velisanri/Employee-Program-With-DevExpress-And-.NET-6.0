namespace EmployeeUI
{
    partial class XtraPayrolcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraPayrolcs));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnExcel = new DevExpress.XtraEditors.SimpleButton();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            txtYear = new DevExpress.XtraEditors.ComboBoxEdit();
            txtMounth = new DevExpress.XtraEditors.ComboBoxEdit();
            btnPayroll = new DevExpress.XtraEditors.SimpleButton();
            gC2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colIdentityNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colMounth2 = new DevExpress.XtraGrid.Columns.GridColumn();
            colYear2 = new DevExpress.XtraGrid.Columns.GridColumn();
            colServiceDay = new DevExpress.XtraGrid.Columns.GridColumn();
            colGrossPay = new DevExpress.XtraGrid.Columns.GridColumn();
            colInsurancePremiumEmployeeShare = new DevExpress.XtraGrid.Columns.GridColumn();
            colIncomeTaxAssessment = new DevExpress.XtraGrid.Columns.GridColumn();
            colCumulaticeIncomeTaxAssessment = new DevExpress.XtraGrid.Columns.GridColumn();
            colNetPay = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmployeePayrollEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryEmployeePayrollEmail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gC1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMounth = new DevExpress.XtraGrid.Columns.GridColumn();
            colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmployeeCount = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalPay = new DevExpress.XtraGrid.Columns.GridColumn();
            colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryBtnMail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtYear.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMounth.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gC2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryEmployeePayrollEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gC1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnMail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnExcel);
            layoutControl1.Controls.Add(btnClose);
            layoutControl1.Controls.Add(txtYear);
            layoutControl1.Controls.Add(txtMounth);
            layoutControl1.Controls.Add(btnPayroll);
            layoutControl1.Controls.Add(gC2);
            layoutControl1.Controls.Add(gC1);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(780, 474);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnExcel
            // 
            btnExcel.ImageOptions.Image = (Image)resources.GetObject("btnExcel.ImageOptions.Image");
            btnExcel.Location = new Point(12, 100);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(257, 36);
            btnExcel.StyleController = layoutControl1;
            btnExcel.TabIndex = 12;
            btnExcel.Text = "Excel Oluştur";
            btnExcel.Click += btnExcel_Click;
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new Point(12, 140);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(257, 36);
            btnClose.StyleController = layoutControl1;
            btnClose.TabIndex = 11;
            btnClose.Text = " Kapat";
            btnClose.Click += btnClose_Click;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(37, 36);
            txtYear.Name = "txtYear";
            txtYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtYear.Properties.Items.AddRange(new object[] { "2022" });
            txtYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtYear.Size = new Size(232, 20);
            txtYear.StyleController = layoutControl1;
            txtYear.TabIndex = 10;
            // 
            // txtMounth
            // 
            txtMounth.Location = new Point(37, 12);
            txtMounth.Name = "txtMounth";
            txtMounth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtMounth.Properties.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            txtMounth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtMounth.Size = new Size(232, 20);
            txtMounth.StyleController = layoutControl1;
            txtMounth.TabIndex = 9;
            // 
            // btnPayroll
            // 
            btnPayroll.ImageOptions.Image = (Image)resources.GetObject("btnPayroll.ImageOptions.Image");
            btnPayroll.Location = new Point(12, 60);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(257, 36);
            btnPayroll.StyleController = layoutControl1;
            btnPayroll.TabIndex = 8;
            btnPayroll.Text = "Bordro Hesapla";
            btnPayroll.Click += btnPayroll_Click;
            // 
            // gC2
            // 
            gC2.Location = new Point(273, 238);
            gC2.MainView = gridView2;
            gC2.Name = "gC2";
            gC2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryEmployeePayrollEmail });
            gC2.Size = new Size(495, 224);
            gC2.TabIndex = 5;
            gC2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colEmployeeId, colName, colIdentityNumber, colMounth2, colYear2, colServiceDay, colGrossPay, colInsurancePremiumEmployeeShare, colIncomeTaxAssessment, colCumulaticeIncomeTaxAssessment, colNetPay, colEmployeePayrollEmail });
            gridView2.GridControl = gC2;
            gridView2.Name = "gridView2";
            // 
            // colId
            // 
            colId.Caption = "#";
            colId.FieldName = "Id";
            colId.Name = "colId";
            // 
            // colEmployeeId
            // 
            colEmployeeId.Caption = "Personel Id";
            colEmployeeId.FieldName = "EmployeeId";
            colEmployeeId.Name = "colEmployeeId";
            colEmployeeId.Visible = true;
            colEmployeeId.VisibleIndex = 0;
            // 
            // colName
            // 
            colName.Caption = "Personel Adı";
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            // 
            // colIdentityNumber
            // 
            colIdentityNumber.Caption = "Tc kimlik numarası";
            colIdentityNumber.FieldName = "IdentityNumber";
            colIdentityNumber.Name = "colIdentityNumber";
            colIdentityNumber.Visible = true;
            colIdentityNumber.VisibleIndex = 2;
            // 
            // colMounth2
            // 
            colMounth2.Caption = "Dönem";
            colMounth2.FieldName = "Mounth";
            colMounth2.Name = "colMounth2";
            // 
            // colYear2
            // 
            colYear2.Caption = "Yıl";
            colYear2.FieldName = "Year";
            colYear2.Name = "colYear2";
            // 
            // colServiceDay
            // 
            colServiceDay.Caption = "Çalışma Günü";
            colServiceDay.FieldName = "ServiceDay";
            colServiceDay.Name = "colServiceDay";
            colServiceDay.Visible = true;
            colServiceDay.VisibleIndex = 3;
            // 
            // colGrossPay
            // 
            colGrossPay.Caption = "Brüt Ücret";
            colGrossPay.FieldName = "GrossPay";
            colGrossPay.Name = "colGrossPay";
            colGrossPay.Visible = true;
            colGrossPay.VisibleIndex = 4;
            // 
            // colInsurancePremiumEmployeeShare
            // 
            colInsurancePremiumEmployeeShare.Caption = "İşçi Payı %15";
            colInsurancePremiumEmployeeShare.FieldName = "InsurancePremiumEmployeeShare";
            colInsurancePremiumEmployeeShare.Name = "colInsurancePremiumEmployeeShare";
            colInsurancePremiumEmployeeShare.Visible = true;
            colInsurancePremiumEmployeeShare.VisibleIndex = 5;
            // 
            // colIncomeTaxAssessment
            // 
            colIncomeTaxAssessment.Caption = "Gelir Vergisi";
            colIncomeTaxAssessment.FieldName = "IncomeTaxAssessment";
            colIncomeTaxAssessment.Name = "colIncomeTaxAssessment";
            colIncomeTaxAssessment.Visible = true;
            colIncomeTaxAssessment.VisibleIndex = 6;
            // 
            // colCumulaticeIncomeTaxAssessment
            // 
            colCumulaticeIncomeTaxAssessment.Caption = "Kümülatif Gelir Vergisi Matrahı";
            colCumulaticeIncomeTaxAssessment.FieldName = "CumulaticeIncomeTaxAssessment";
            colCumulaticeIncomeTaxAssessment.Name = "colCumulaticeIncomeTaxAssessment";
            colCumulaticeIncomeTaxAssessment.Visible = true;
            colCumulaticeIncomeTaxAssessment.VisibleIndex = 7;
            // 
            // colNetPay
            // 
            colNetPay.Caption = "Net Ücret";
            colNetPay.FieldName = "NetPay";
            colNetPay.Name = "colNetPay";
            colNetPay.Visible = true;
            colNetPay.VisibleIndex = 8;
            // 
            // colEmployeePayrollEmail
            // 
            colEmployeePayrollEmail.Caption = "Mail Gönder";
            colEmployeePayrollEmail.ColumnEdit = repositoryEmployeePayrollEmail;
            colEmployeePayrollEmail.Name = "colEmployeePayrollEmail";
            colEmployeePayrollEmail.Visible = true;
            colEmployeePayrollEmail.VisibleIndex = 9;
            // 
            // repositoryEmployeePayrollEmail
            // 
            repositoryEmployeePayrollEmail.AutoHeight = false;
            repositoryEmployeePayrollEmail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) });
            repositoryEmployeePayrollEmail.Name = "repositoryEmployeePayrollEmail";
            repositoryEmployeePayrollEmail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryEmployeePayrollEmail.Click += repositoryEmployeePayrollEmail_Click;
            // 
            // gC1
            // 
            gC1.Location = new Point(273, 12);
            gC1.MainView = gridView1;
            gC1.Name = "gC1";
            gC1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnMail });
            gC1.Size = new Size(495, 222);
            gC1.TabIndex = 4;
            gC1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMounth, colYear, colEmployeeCount, colTotalPay, colMail });
            gridView1.GridControl = gC1;
            gridView1.Name = "gridView1";
            gridView1.Click += gridView1_Click;
            // 
            // colMounth
            // 
            colMounth.Caption = "Dönem";
            colMounth.FieldName = "MounthName";
            colMounth.Name = "colMounth";
            colMounth.Visible = true;
            colMounth.VisibleIndex = 0;
            // 
            // colYear
            // 
            colYear.Caption = "Yıl";
            colYear.FieldName = "Year";
            colYear.Name = "colYear";
            colYear.Visible = true;
            colYear.VisibleIndex = 1;
            // 
            // colEmployeeCount
            // 
            colEmployeeCount.Caption = "Personel Sayısı";
            colEmployeeCount.FieldName = "EmployeeCount";
            colEmployeeCount.Name = "colEmployeeCount";
            colEmployeeCount.Visible = true;
            colEmployeeCount.VisibleIndex = 2;
            // 
            // colTotalPay
            // 
            colTotalPay.Caption = "Toplam Net Maaş";
            colTotalPay.FieldName = "TotalNetPay";
            colTotalPay.Name = "colTotalPay";
            colTotalPay.Visible = true;
            colTotalPay.VisibleIndex = 3;
            // 
            // colMail
            // 
            colMail.Caption = "Mail Gönder";
            colMail.ColumnEdit = repositoryBtnMail;
            colMail.Name = "colMail";
            colMail.Visible = true;
            colMail.VisibleIndex = 4;
            // 
            // repositoryBtnMail
            // 
            repositoryBtnMail.AutoHeight = false;
            editorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            editorButtonImageOptions1.Image = (Image)resources.GetObject("editorButtonImageOptions1.Image");
            repositoryBtnMail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryBtnMail.Name = "repositoryBtnMail";
            repositoryBtnMail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnMail.Click += repositoryBtnMail_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem5, layoutControlItem3, layoutControlItem4, layoutControlItem6, layoutControlItem7 });
            Root.Name = "Root";
            Root.Size = new Size(780, 474);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gC1;
            layoutControlItem1.Location = new Point(261, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(499, 226);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = gC2;
            layoutControlItem2.Location = new Point(261, 226);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(499, 228);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnPayroll;
            layoutControlItem5.Location = new Point(0, 48);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(261, 40);
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtMounth;
            layoutControlItem3.Location = new Point(0, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(261, 24);
            layoutControlItem3.Text = "Ay";
            layoutControlItem3.TextSize = new Size(13, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtYear;
            layoutControlItem4.Location = new Point(0, 24);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(261, 24);
            layoutControlItem4.Text = "Yıl";
            layoutControlItem4.TextSize = new Size(13, 13);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = btnClose;
            layoutControlItem6.Location = new Point(0, 128);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(261, 326);
            layoutControlItem6.TextSize = new Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = btnExcel;
            layoutControlItem7.Location = new Point(0, 88);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(261, 40);
            layoutControlItem7.TextSize = new Size(0, 0);
            layoutControlItem7.TextVisible = false;
            // 
            // XtraPayrolcs
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 474);
            Controls.Add(layoutControl1);
            Name = "XtraPayrolcs";
            Text = "Bordro Formu";
            Load += XtraPayrolcs_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtYear.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMounth.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gC2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryEmployeePayrollEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)gC1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnMail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtYear;
        private DevExpress.XtraEditors.ComboBoxEdit txtMounth;
        private DevExpress.XtraEditors.SimpleButton btnPayroll;
        private DevExpress.XtraGrid.GridControl gC2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gC1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn colMounth;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPay;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnMail;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentityNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMounth2;
        private DevExpress.XtraGrid.Columns.GridColumn colYear2;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceDay;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossPay;
        private DevExpress.XtraGrid.Columns.GridColumn colInsurancePremiumEmployeeShare;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomeTaxAssessment;
        private DevExpress.XtraGrid.Columns.GridColumn colCumulaticeIncomeTaxAssessment;
        private DevExpress.XtraGrid.Columns.GridColumn colNetPay;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePayrollEmail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryEmployeePayrollEmail;
    }
}