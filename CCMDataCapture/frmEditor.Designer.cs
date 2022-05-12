namespace CCMDataCapture
{
    partial class frmEditor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_report = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSrNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeSrNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPipeDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPipeClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevPer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPipeStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptStatus = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colJoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMould = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptMaterial = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colStandard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptStandard = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtIncharge = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtShift = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.txtMachines = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptRemarks = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptStandard)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptRemarks)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grd_report, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 469);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grd_report
            // 
            this.grd_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_report.Location = new System.Drawing.Point(3, 123);
            this.grd_report.MainView = this.gridView1;
            this.grd_report.Name = "grd_report";
            this.grd_report.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rptStatus,
            this.rptMaterial,
            this.rptStandard,
            this.rptRemarks});
            this.grd_report.Size = new System.Drawing.Size(909, 343);
            this.grd_report.TabIndex = 7;
            this.grd_report.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSrNo,
            this.colDate,
            this.colTime,
            this.colShift,
            this.colMachine,
            this.colSizeSrNo,
            this.colPipeDia,
            this.colPipeClass,
            this.colLength,
            this.colBatchNo,
            this.colNomWt,
            this.colActWt,
            this.colDevPer,
            this.colPipeStatus,
            this.colJoint,
            this.colMould,
            this.colMaterial,
            this.colStandard,
            this.colRemarks});
            this.gridView1.GridControl = this.grd_report;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridView1.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView1.OptionsMenu.ShowSplitItem = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colSrNo
            // 
            this.colSrNo.Caption = "SrNo";
            this.colSrNo.FieldName = "SrNo";
            this.colSrNo.Name = "colSrNo";
            this.colSrNo.OptionsColumn.AllowEdit = false;
            this.colSrNo.OptionsColumn.AllowMove = false;
            this.colSrNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSrNo.OptionsColumn.ReadOnly = true;
            this.colSrNo.Visible = true;
            this.colSrNo.VisibleIndex = 0;
            this.colSrNo.Width = 43;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "LogDate";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.OptionsColumn.AllowMove = false;
            this.colDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDate.OptionsColumn.ReadOnly = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 76;
            // 
            // colTime
            // 
            this.colTime.Caption = "Time";
            this.colTime.FieldName = "LogTime";
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 2;
            this.colTime.Width = 56;
            // 
            // colShift
            // 
            this.colShift.Caption = "Shift";
            this.colShift.FieldName = "tShift";
            this.colShift.Name = "colShift";
            this.colShift.Visible = true;
            this.colShift.VisibleIndex = 3;
            this.colShift.Width = 33;
            // 
            // colMachine
            // 
            this.colMachine.Caption = "Machine";
            this.colMachine.FieldName = "MachineNo";
            this.colMachine.Name = "colMachine";
            this.colMachine.Visible = true;
            this.colMachine.VisibleIndex = 4;
            this.colMachine.Width = 53;
            // 
            // colSizeSrNo
            // 
            this.colSizeSrNo.Caption = "SizeSrNo";
            this.colSizeSrNo.FieldName = "IntSrNo";
            this.colSizeSrNo.Name = "colSizeSrNo";
            this.colSizeSrNo.Visible = true;
            this.colSizeSrNo.VisibleIndex = 5;
            this.colSizeSrNo.Width = 56;
            // 
            // colPipeDia
            // 
            this.colPipeDia.Caption = "PipeDia";
            this.colPipeDia.FieldName = "PipeDia";
            this.colPipeDia.Name = "colPipeDia";
            this.colPipeDia.OptionsColumn.AllowEdit = false;
            this.colPipeDia.OptionsColumn.AllowMove = false;
            this.colPipeDia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPipeDia.OptionsColumn.ReadOnly = true;
            this.colPipeDia.Visible = true;
            this.colPipeDia.VisibleIndex = 6;
            this.colPipeDia.Width = 48;
            // 
            // colPipeClass
            // 
            this.colPipeClass.Caption = "PipeClass";
            this.colPipeClass.FieldName = "PipeClass";
            this.colPipeClass.Name = "colPipeClass";
            this.colPipeClass.OptionsColumn.AllowEdit = false;
            this.colPipeClass.OptionsColumn.AllowMove = false;
            this.colPipeClass.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPipeClass.OptionsColumn.ReadOnly = true;
            this.colPipeClass.Visible = true;
            this.colPipeClass.VisibleIndex = 7;
            this.colPipeClass.Width = 58;
            // 
            // colLength
            // 
            this.colLength.Caption = "Length";
            this.colLength.FieldName = "PipeLength";
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 8;
            this.colLength.Width = 48;
            // 
            // colBatchNo
            // 
            this.colBatchNo.Caption = "BatchNo";
            this.colBatchNo.FieldName = "PipeNumber";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.OptionsColumn.AllowEdit = false;
            this.colBatchNo.OptionsColumn.AllowMove = false;
            this.colBatchNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBatchNo.OptionsColumn.ReadOnly = true;
            this.colBatchNo.Visible = true;
            this.colBatchNo.VisibleIndex = 9;
            this.colBatchNo.Width = 81;
            // 
            // colNomWt
            // 
            this.colNomWt.Caption = "NomWt";
            this.colNomWt.FieldName = "NomWt";
            this.colNomWt.Name = "colNomWt";
            this.colNomWt.OptionsColumn.AllowEdit = false;
            this.colNomWt.OptionsColumn.ReadOnly = true;
            this.colNomWt.Visible = true;
            this.colNomWt.VisibleIndex = 11;
            this.colNomWt.Width = 63;
            // 
            // colActWt
            // 
            this.colActWt.Caption = "ActWt";
            this.colActWt.FieldName = "ActWt";
            this.colActWt.Name = "colActWt";
            this.colActWt.OptionsColumn.AllowEdit = false;
            this.colActWt.OptionsColumn.AllowMove = false;
            this.colActWt.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colActWt.OptionsColumn.ReadOnly = true;
            this.colActWt.Visible = true;
            this.colActWt.VisibleIndex = 10;
            this.colActWt.Width = 56;
            // 
            // colDevPer
            // 
            this.colDevPer.Caption = "Wt. Gain(%)";
            this.colDevPer.FieldName = "DevPer";
            this.colDevPer.Name = "colDevPer";
            this.colDevPer.OptionsColumn.AllowEdit = false;
            this.colDevPer.OptionsColumn.ReadOnly = true;
            this.colDevPer.Visible = true;
            this.colDevPer.VisibleIndex = 12;
            // 
            // colPipeStatus
            // 
            this.colPipeStatus.Caption = "PipeStatus";
            this.colPipeStatus.ColumnEdit = this.rptStatus;
            this.colPipeStatus.FieldName = "PipeStatus";
            this.colPipeStatus.Name = "colPipeStatus";
            this.colPipeStatus.OptionsColumn.AllowMove = false;
            this.colPipeStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPipeStatus.Visible = true;
            this.colPipeStatus.VisibleIndex = 13;
            this.colPipeStatus.Width = 99;
            // 
            // rptStatus
            // 
            this.rptStatus.AutoHeight = false;
            this.rptStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptStatus.Name = "rptStatus";
            // 
            // colJoint
            // 
            this.colJoint.Caption = "Joint";
            this.colJoint.FieldName = "JointType";
            this.colJoint.Name = "colJoint";
            this.colJoint.Visible = true;
            this.colJoint.VisibleIndex = 16;
            this.colJoint.Width = 43;
            // 
            // colMould
            // 
            this.colMould.Caption = "Mould";
            this.colMould.FieldName = "MouldNo";
            this.colMould.Name = "colMould";
            this.colMould.Visible = true;
            this.colMould.VisibleIndex = 15;
            this.colMould.Width = 87;
            // 
            // colMaterial
            // 
            this.colMaterial.Caption = "Material";
            this.colMaterial.ColumnEdit = this.rptMaterial;
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 14;
            this.colMaterial.Width = 91;
            // 
            // rptMaterial
            // 
            this.rptMaterial.AutoHeight = false;
            this.rptMaterial.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptMaterial.Name = "rptMaterial";
            this.rptMaterial.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colStandard
            // 
            this.colStandard.Caption = "Standard";
            this.colStandard.ColumnEdit = this.rptStandard;
            this.colStandard.FieldName = "Standard";
            this.colStandard.Name = "colStandard";
            this.colStandard.Visible = true;
            this.colStandard.VisibleIndex = 17;
            this.colStandard.Width = 123;
            // 
            // rptStandard
            // 
            this.rptStandard.AutoHeight = false;
            this.rptStandard.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptStandard.Name = "rptStandard";
            this.rptStandard.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtIncharge);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtShift);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtMachines);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(726, 63);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 27);
            this.btnExport.TabIndex = 30;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(726, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 27);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(614, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 27);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(614, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 27);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Go";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtIncharge
            // 
            this.txtIncharge.Location = new System.Drawing.Point(139, 60);
            this.txtIncharge.Name = "txtIncharge";
            this.txtIncharge.Size = new System.Drawing.Size(255, 20);
            this.txtIncharge.TabIndex = 26;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 63);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(122, 13);
            this.label27.TabIndex = 25;
            this.label27.Text = "Name of Shift Incharge :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(403, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 24;
            this.label26.Text = "Shift :";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(453, 19);
            this.txtShift.Name = "txtShift";
            this.txtShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtShift.Properties.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.txtShift.Size = new System.Drawing.Size(125, 20);
            this.txtShift.TabIndex = 23;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(214, 23);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(39, 13);
            this.lbl_date.TabIndex = 11;
            this.lbl_date.Text = "Date  :";
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(269, 18);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDate.Size = new System.Drawing.Size(125, 22);
            this.txtDate.TabIndex = 10;
            // 
            // txtMachines
            // 
            this.txtMachines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMachines.FormattingEnabled = true;
            this.txtMachines.Items.AddRange(new object[] {
            "P",
            "Q",
            "R"});
            this.txtMachines.Location = new System.Drawing.Point(81, 19);
            this.txtMachines.Name = "txtMachines";
            this.txtMachines.Size = new System.Drawing.Size(125, 21);
            this.txtMachines.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Machine :";
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "Remarks";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 18;
            // 
            // rptRemarks
            // 
            this.rptRemarks.AutoHeight = false;
            this.rptRemarks.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.rptRemarks.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.rptRemarks.MaskSettings.Set("mask", "[0-9 a-zA-Z \\-\\[\\]+=.*(){},$:;!@#?><]+");
            this.rptRemarks.MaxLength = 50;
            this.rptRemarks.Name = "rptRemarks";
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEditor";
            this.Text = "Quality Editor";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptStandard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptRemarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl grd_report;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_date;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private System.Windows.Forms.ComboBox txtMachines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label26;
        private DevExpress.XtraEditors.ComboBoxEdit txtShift;
        private DevExpress.XtraEditors.TextEdit txtIncharge;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn colSrNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPipeDia;
        private DevExpress.XtraGrid.Columns.GridColumn colPipeClass;
        private DevExpress.XtraGrid.Columns.GridColumn colActWt;
        private DevExpress.XtraGrid.Columns.GridColumn colPipeStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rptStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeSrNo;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colJoint;
        private DevExpress.XtraGrid.Columns.GridColumn colMould;
        private DevExpress.XtraGrid.Columns.GridColumn colShift;
        private DevExpress.XtraGrid.Columns.GridColumn colMachine;
        private DevExpress.XtraGrid.Columns.GridColumn colNomWt;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colStandard;
        private System.Windows.Forms.Button btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn colDevPer;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rptMaterial;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rptStandard;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rptRemarks;
    }
}