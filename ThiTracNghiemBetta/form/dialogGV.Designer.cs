﻿namespace ThiTracNghiemBetta.form
{
    partial class dialogGV
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
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHocVi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKHH = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMAGV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHO = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHOCVI = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMAKH = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gIAOVIENTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter();
            this.kHOATableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMAGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHOCVI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMAKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.layoutControl1);
            this.dataLayoutControl1.Controls.Add(this.txtMaGV);
            this.dataLayoutControl1.Controls.Add(this.txtHo);
            this.dataLayoutControl1.Controls.Add(this.txtTen);
            this.dataLayoutControl1.Controls.Add(this.txtHocVi);
            this.dataLayoutControl1.Controls.Add(this.txtMaKHH);
            this.dataLayoutControl1.DataSource = this.gIAOVIENBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(741, 349);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "TN_CSDLPTDataSet";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Location = new System.Drawing.Point(8, 128);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(725, 213);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Location = new System.Drawing.Point(8, 8);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(709, 197);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(482, 47);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(52, 35);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(584, 47);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(725, 213);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(711, 199);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(48, 8);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaGV.Properties.MaxLength = 8;
            this.txtMaGV.Size = new System.Drawing.Size(685, 22);
            this.txtMaGV.StyleController = this.dataLayoutControl1;
            this.txtMaGV.TabIndex = 4;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.dS;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(48, 32);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(685, 22);
            this.txtHo.StyleController = this.dataLayoutControl1;
            this.txtHo.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(48, 56);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(685, 22);
            this.txtTen.StyleController = this.dataLayoutControl1;
            this.txtTen.TabIndex = 6;
            // 
            // txtHocVi
            // 
            this.txtHocVi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "HOCVI", true));
            this.txtHocVi.Location = new System.Drawing.Point(48, 80);
            this.txtHocVi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(685, 22);
            this.txtHocVi.StyleController = this.dataLayoutControl1;
            this.txtHocVi.TabIndex = 7;
            // 
            // txtMaKHH
            // 
            this.txtMaKHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "MAKH", true));
            this.txtMaKHH.Location = new System.Drawing.Point(48, 104);
            this.txtMaKHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKHH.Name = "txtMaKHH";
            this.txtMaKHH.Size = new System.Drawing.Size(685, 22);
            this.txtMaKHH.StyleController = this.dataLayoutControl1;
            this.txtMaKHH.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(741, 349);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMAGV,
            this.ItemForHO,
            this.ItemForTEN,
            this.ItemForHOCVI,
            this.ItemForMAKH,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(727, 335);
            // 
            // ItemForMAGV
            // 
            this.ItemForMAGV.Control = this.txtMaGV;
            this.ItemForMAGV.Location = new System.Drawing.Point(0, 0);
            this.ItemForMAGV.Name = "ItemForMAGV";
            this.ItemForMAGV.Size = new System.Drawing.Size(727, 24);
            this.ItemForMAGV.Text = "MAGV";
            this.ItemForMAGV.TextSize = new System.Drawing.Size(38, 16);
            // 
            // ItemForHO
            // 
            this.ItemForHO.Control = this.txtHo;
            this.ItemForHO.Location = new System.Drawing.Point(0, 24);
            this.ItemForHO.Name = "ItemForHO";
            this.ItemForHO.Size = new System.Drawing.Size(727, 24);
            this.ItemForHO.Text = "HO";
            this.ItemForHO.TextSize = new System.Drawing.Size(38, 16);
            // 
            // ItemForTEN
            // 
            this.ItemForTEN.Control = this.txtTen;
            this.ItemForTEN.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN.Name = "ItemForTEN";
            this.ItemForTEN.Size = new System.Drawing.Size(727, 24);
            this.ItemForTEN.Text = "TEN";
            this.ItemForTEN.TextSize = new System.Drawing.Size(38, 16);
            // 
            // ItemForHOCVI
            // 
            this.ItemForHOCVI.Control = this.txtHocVi;
            this.ItemForHOCVI.Location = new System.Drawing.Point(0, 72);
            this.ItemForHOCVI.Name = "ItemForHOCVI";
            this.ItemForHOCVI.Size = new System.Drawing.Size(727, 24);
            this.ItemForHOCVI.Text = "HOCVI";
            this.ItemForHOCVI.TextSize = new System.Drawing.Size(38, 16);
            // 
            // ItemForMAKH
            // 
            this.ItemForMAKH.Control = this.txtMaKHH;
            this.ItemForMAKH.Enabled = false;
            this.ItemForMAKH.Location = new System.Drawing.Point(0, 96);
            this.ItemForMAKH.Name = "ItemForMAKH";
            this.ItemForMAKH.Size = new System.Drawing.Size(727, 24);
            this.ItemForMAKH.Text = "MAKH";
            this.ItemForMAKH.TextSize = new System.Drawing.Size(38, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(727, 215);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dialogGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 349);
            this.Controls.Add(this.dataLayoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dialogGV";
            this.Text = "dialogGV";
            this.Load += new System.EventHandler(this.dialogGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMAGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHOCVI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMAKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private TN_CSDLPTDataSet dS;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHocVi;
        private DevExpress.XtraEditors.TextEdit txtMaKHH;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMAGV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHO;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHOCVI;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMAKH;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}