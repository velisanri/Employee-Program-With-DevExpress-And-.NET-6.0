namespace EmployeeUI
{
    partial class XtraEmployeeUpdate
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmployeeUpdate));
            TC = new DevExpress.XtraLayout.LayoutControlItem();
            txtIdentityNumber = new DevExpress.XtraEditors.TextEdit();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtDeparment = new DevExpress.XtraEditors.ComboBoxEdit();
            txtStartingDate = new DevExpress.XtraEditors.DateEdit();
            txtSalary = new DevExpress.XtraEditors.TextEdit();
            txtBirthDate = new DevExpress.XtraEditors.DateEdit();
            txtLastName = new DevExpress.XtraEditors.TextEdit();
            txtName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)TC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIdentityNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDeparment.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            SuspendLayout();
            // 
            // TC
            // 
            TC.Control = txtIdentityNumber;
            TC.Location = new Point(0, 144);
            TC.Name = "TC";
            TC.Size = new Size(448, 24);
            TC.TextSize = new Size(84, 13);
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.Location = new Point(108, 156);
            txtIdentityNumber.MenuManager = barManager1;
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.Properties.MaxLength = 11;
            txtIdentityNumber.Size = new Size(348, 20);
            txtIdentityNumber.StyleController = layoutControl1;
            txtIdentityNumber.TabIndex = 10;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnClose, btnUpdate });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnUpdate), new DevExpress.XtraBars.LinkPersistInfo(btnClose) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnUpdate
            // 
            btnUpdate.Caption = "Personel Güncelle";
            btnUpdate.Id = 1;
            btnUpdate.ImageOptions.LargeImage = (Image)resources.GetObject("btnUpdate.ImageOptions.LargeImage");
            btnUpdate.Name = "btnUpdate";
            btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnUpdate.ItemClick += btnUpdate_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Kapat";
            btnClose.Id = 0;
            btnClose.ImageOptions.LargeImage = (Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(468, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 343);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(468, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 20);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 323);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(468, 20);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 323);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtIdentityNumber);
            layoutControl1.Controls.Add(txtDeparment);
            layoutControl1.Controls.Add(txtStartingDate);
            layoutControl1.Controls.Add(txtSalary);
            layoutControl1.Controls.Add(txtBirthDate);
            layoutControl1.Controls.Add(txtLastName);
            layoutControl1.Controls.Add(txtName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 20);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1270, 124, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(468, 323);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtDeparment
            // 
            txtDeparment.Location = new Point(108, 132);
            txtDeparment.MenuManager = barManager1;
            txtDeparment.Name = "txtDeparment";
            txtDeparment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDeparment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtDeparment.Size = new Size(348, 20);
            txtDeparment.StyleController = layoutControl1;
            txtDeparment.TabIndex = 9;
            txtDeparment.SelectedIndexChanged += txtDeparment_SelectedIndexChanged;
            // 
            // txtStartingDate
            // 
            txtStartingDate.EditValue = null;
            txtStartingDate.Location = new Point(108, 108);
            txtStartingDate.MenuManager = barManager1;
            txtStartingDate.Name = "txtStartingDate";
            txtStartingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtStartingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtStartingDate.Size = new Size(348, 20);
            txtStartingDate.StyleController = layoutControl1;
            txtStartingDate.TabIndex = 8;
            // 
            // txtSalary
            // 
            txtSalary.EditValue = "0";
            txtSalary.Location = new Point(108, 84);
            txtSalary.MenuManager = barManager1;
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(348, 20);
            txtSalary.StyleController = layoutControl1;
            txtSalary.TabIndex = 7;
            // 
            // txtBirthDate
            // 
            txtBirthDate.EditValue = null;
            txtBirthDate.Location = new Point(108, 60);
            txtBirthDate.MenuManager = barManager1;
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirthDate.Size = new Size(348, 20);
            txtBirthDate.StyleController = layoutControl1;
            txtBirthDate.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(108, 36);
            txtLastName.MenuManager = barManager1;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(348, 20);
            txtLastName.StyleController = layoutControl1;
            txtLastName.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 12);
            txtName.MenuManager = barManager1;
            txtName.Name = "txtName";
            txtName.Size = new Size(348, 20);
            txtName.StyleController = layoutControl1;
            txtName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, TC });
            Root.Name = "Root";
            Root.Size = new Size(468, 323);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtName;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(448, 24);
            layoutControlItem1.Text = "Personel Adı";
            layoutControlItem1.TextSize = new Size(84, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 168);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(448, 135);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtLastName;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(448, 24);
            layoutControlItem2.Text = "Personel Soyadı";
            layoutControlItem2.TextSize = new Size(84, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtBirthDate;
            layoutControlItem3.Location = new Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(448, 24);
            layoutControlItem3.Text = "Dogum Tarihi";
            layoutControlItem3.TextSize = new Size(84, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtSalary;
            layoutControlItem4.Location = new Point(0, 72);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(448, 24);
            layoutControlItem4.Text = "Maas";
            layoutControlItem4.TextSize = new Size(84, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = txtStartingDate;
            layoutControlItem5.Location = new Point(0, 96);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(448, 24);
            layoutControlItem5.Text = "ise Baslama Tarihi";
            layoutControlItem5.TextSize = new Size(84, 13);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = txtDeparment;
            layoutControlItem6.Location = new Point(0, 120);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(448, 24);
            layoutControlItem6.Text = "Bolumu";
            layoutControlItem6.TextSize = new Size(84, 13);
            // 
            // XtraEmployeeUpdate
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 343);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IconOptions.LargeImage = (Image)resources.GetObject("XtraEmployeeUpdate.IconOptions.LargeImage");
            Name = "XtraEmployeeUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Güncelleme Formu";
            Load += XtraEmployeeUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)TC).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIdentityNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtDeparment.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem TC;
        private DevExpress.XtraEditors.TextEdit txtIdentityNumber;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtDeparment;
        private DevExpress.XtraEditors.DateEdit txtStartingDate;
        private DevExpress.XtraEditors.TextEdit txtSalary;
        private DevExpress.XtraEditors.DateEdit txtBirthDate;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}