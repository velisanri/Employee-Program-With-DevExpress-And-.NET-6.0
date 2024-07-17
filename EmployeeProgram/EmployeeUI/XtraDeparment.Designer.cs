namespace EmployeeUI
{
    partial class XtraDeparment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraDeparment));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            gC1 = new DevExpress.XtraGrid.GridControl();
            repositoryBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryBtnStatusChange = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            txtDeparmentName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            txtoyle = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatusChange = new DevExpress.XtraGrid.Columns.GridColumn();
            colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gC1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnStatusChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDeparmentName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtoyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnClose);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(gC1);
            layoutControl1.Controls.Add(txtDeparmentName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(631, 529);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new Point(12, 76);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(607, 36);
            btnClose.StyleController = layoutControl1;
            btnClose.TabIndex = 7;
            btnClose.Text = "Kapat";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.Location = new Point(12, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(607, 36);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.Click += btnSave_Click;
            // 
            // gC1
            // 
            gC1.Location = new Point(12, 168);
            gC1.MainView = gridView1;
            gC1.Name = "gC1";
            gC1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnDelete, repositoryBtnEdit, repositoryBtnStatusChange });
            gC1.Size = new Size(607, 349);
            gC1.TabIndex = 5;
            gC1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gC1.Click += gridControl1_Click;
            // 
            // repositoryBtnEdit
            // 
            repositoryBtnEdit.AutoHeight = false;
            repositoryBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo) });
            repositoryBtnEdit.Name = "repositoryBtnEdit";
            repositoryBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnEdit.Click += repositoryBtnEdit_Click;
            // 
            // repositoryBtnDelete
            // 
            repositoryBtnDelete.AutoHeight = false;
            repositoryBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryBtnDelete.Name = "repositoryBtnDelete";
            repositoryBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnDelete.Click += repositoryBtnDelete_Click;
            // 
            // repositoryBtnStatusChange
            // 
            repositoryBtnStatusChange.AutoHeight = false;
            repositoryBtnStatusChange.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK) });
            repositoryBtnStatusChange.Name = "repositoryBtnStatusChange";
            repositoryBtnStatusChange.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnStatusChange.Click += repositoryBtnStatusChange_Click;
            // 
            // txtDeparmentName
            // 
            txtDeparmentName.Location = new Point(70, 12);
            txtDeparmentName.Name = "txtDeparmentName";
            txtDeparmentName.Size = new Size(549, 20);
            txtDeparmentName.StyleController = layoutControl1;
            txtDeparmentName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { txtoyle, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new Size(631, 529);
            Root.TextVisible = false;
            // 
            // txtoyle
            // 
            txtoyle.Control = txtDeparmentName;
            txtoyle.Location = new Point(0, 0);
            txtoyle.Name = "txtoyle";
            txtoyle.Size = new Size(611, 24);
            txtoyle.Text = "Bölüm Adı";
            txtoyle.TextSize = new Size(46, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 104);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(611, 52);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = gC1;
            layoutControlItem2.Location = new Point(0, 156);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(611, 353);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnSave;
            layoutControlItem3.Location = new Point(0, 24);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(611, 40);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnClose;
            layoutControlItem1.Location = new Point(0, 64);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(611, 40);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colStatus, colEdit, colStatusChange, colDelete });
            gridView1.GridControl = gC1;
            gridView1.Name = "gridView1";
            // 
            // colId
            // 
            colId.Caption = "#";
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colName
            // 
            colName.Caption = "Bölüm Adı";
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            // 
            // colStatus
            // 
            colStatus.Caption = "Durum";
            colStatus.FieldName = "Status";
            colStatus.Name = "colStatus";
            colStatus.Visible = true;
            colStatus.VisibleIndex = 2;
            // 
            // colEdit
            // 
            colEdit.Caption = "Güncelle";
            colEdit.ColumnEdit = repositoryBtnEdit;
            colEdit.Name = "colEdit";
            colEdit.Visible = true;
            colEdit.VisibleIndex = 3;
            // 
            // colStatusChange
            // 
            colStatusChange.Caption = "Durumu Değiştir";
            colStatusChange.ColumnEdit = repositoryBtnStatusChange;
            colStatusChange.Name = "colStatusChange";
            colStatusChange.Visible = true;
            colStatusChange.VisibleIndex = 4;
            // 
            // colDelete
            // 
            colDelete.Caption = "Sil";
            colDelete.ColumnEdit = repositoryBtnDelete;
            colDelete.Name = "colDelete";
            colDelete.Visible = true;
            colDelete.VisibleIndex = 5;
            // 
            // XtraDeparment
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 529);
            Controls.Add(layoutControl1);
            IconOptions.LargeImage = (Image)resources.GetObject("XtraDeparment.IconOptions.LargeImage");
            Name = "XtraDeparment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bölümler";
            Load += XtraDeparment_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gC1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnStatusChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDeparmentName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtoyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gC1;
        private DevExpress.XtraEditors.TextEdit txtDeparmentName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem txtoyle;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnStatusChange;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusChange;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
    }
}