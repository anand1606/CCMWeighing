namespace CCMDataCapture
{
    partial class frmWeightMaster
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
            this.gridWt = new DevExpress.XtraGrid.GridControl();
            this.gv_Wt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.ComboBox();
            this.txtLength = new System.Windows.Forms.ComboBox();
            this.txtMinWt = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaxWt = new DevExpress.XtraEditors.SpinEdit();
            this.txtNomWt = new DevExpress.XtraEditors.SpinEdit();
            this.btnExport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlmMinWt = new DevExpress.XtraEditors.SpinEdit();
            this.txtAlmMaxWt = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridWt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Wt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinWt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxWt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomWt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlmMinWt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlmMaxWt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridWt
            // 
            this.gridWt.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridWt.Location = new System.Drawing.Point(242, 34);
            this.gridWt.MainView = this.gv_Wt;
            this.gridWt.Margin = new System.Windows.Forms.Padding(4);
            this.gridWt.Name = "gridWt";
            this.gridWt.Size = new System.Drawing.Size(607, 465);
            this.gridWt.TabIndex = 15;
            this.gridWt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Wt});
            // 
            // gv_Wt
            // 
            this.gv_Wt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gv_Wt.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_Wt.GridControl = this.gridWt;
            this.gv_Wt.Name = "gv_Wt";
            this.gv_Wt.OptionsBehavior.Editable = false;
            this.gv_Wt.OptionsCustomization.AllowColumnMoving = false;
            this.gv_Wt.OptionsCustomization.AllowFilter = false;
            this.gv_Wt.OptionsCustomization.AllowGroup = false;
            this.gv_Wt.OptionsCustomization.AllowQuickHideColumns = false;
            this.gv_Wt.OptionsCustomization.AllowSort = false;
            this.gv_Wt.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gv_Wt.OptionsFilter.AllowFilterEditor = false;
            this.gv_Wt.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gv_Wt.OptionsFilter.AllowMRUFilterList = false;
            this.gv_Wt.OptionsFind.AllowFindPanel = false;
            this.gv_Wt.OptionsMenu.EnableColumnMenu = false;
            this.gv_Wt.OptionsMenu.EnableFooterMenu = false;
            this.gv_Wt.OptionsMenu.EnableGroupPanelMenu = false;
            this.gv_Wt.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.gv_Wt.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gv_Wt.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.gv_Wt.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gv_Wt.OptionsMenu.ShowSplitItem = false;
            this.gv_Wt.OptionsView.ColumnAutoWidth = false;
            this.gv_Wt.OptionsView.ShowDetailButtons = false;
            this.gv_Wt.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gv_Wt.OptionsView.ShowGroupPanel = false;
            this.gv_Wt.DoubleClick += new System.EventHandler(this.gv_Wt_DoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(121, 399);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 41);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 399);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 41);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(121, 350);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 41);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 350);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 41);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Min. Wt.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nom. Wt.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Max Wt.";
            // 
            // txtSize
            // 
            this.txtSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSize.FormattingEnabled = true;
            this.txtSize.Location = new System.Drawing.Point(101, 55);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(119, 24);
            this.txtSize.TabIndex = 32;
            this.txtSize.SelectionChangeCommitted += new System.EventHandler(this.txtSize_SelectionChangeCommitted);
            // 
            // txtClass
            // 
            this.txtClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtClass.FormattingEnabled = true;
            this.txtClass.Location = new System.Drawing.Point(101, 92);
            this.txtClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(119, 24);
            this.txtClass.TabIndex = 33;
            this.txtClass.SelectionChangeCommitted += new System.EventHandler(this.txtClass_SelectionChangeCommitted);
            // 
            // txtLength
            // 
            this.txtLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLength.FormattingEnabled = true;
            this.txtLength.Location = new System.Drawing.Point(101, 131);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(119, 24);
            this.txtLength.TabIndex = 34;
            this.txtLength.SelectionChangeCommitted += new System.EventHandler(this.txtLength_SelectionChangeCommitted);
            // 
            // txtMinWt
            // 
            this.txtMinWt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinWt.Location = new System.Drawing.Point(100, 168);
            this.txtMinWt.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinWt.Name = "txtMinWt";
            this.txtMinWt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinWt.Properties.Appearance.Options.UseFont = true;
            this.txtMinWt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMinWt.Size = new System.Drawing.Size(120, 22);
            this.txtMinWt.TabIndex = 35;
            // 
            // txtMaxWt
            // 
            this.txtMaxWt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaxWt.Location = new System.Drawing.Point(100, 205);
            this.txtMaxWt.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxWt.Name = "txtMaxWt";
            this.txtMaxWt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxWt.Properties.Appearance.Options.UseFont = true;
            this.txtMaxWt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaxWt.Size = new System.Drawing.Size(120, 22);
            this.txtMaxWt.TabIndex = 36;
            // 
            // txtNomWt
            // 
            this.txtNomWt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNomWt.Location = new System.Drawing.Point(100, 242);
            this.txtNomWt.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomWt.Name = "txtNomWt";
            this.txtNomWt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomWt.Properties.Appearance.Options.UseFont = true;
            this.txtNomWt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNomWt.Size = new System.Drawing.Size(120, 22);
            this.txtNomWt.TabIndex = 37;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(13, 448);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(208, 41);
            this.btnExport.TabIndex = 44;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "List of Records";
            // 
            // txtAlmMinWt
            // 
            this.txtAlmMinWt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAlmMinWt.Location = new System.Drawing.Point(101, 280);
            this.txtAlmMinWt.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlmMinWt.Name = "txtAlmMinWt";
            this.txtAlmMinWt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmMinWt.Properties.Appearance.Options.UseFont = true;
            this.txtAlmMinWt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAlmMinWt.Size = new System.Drawing.Size(120, 22);
            this.txtAlmMinWt.TabIndex = 38;
            // 
            // txtAlmMaxWt
            // 
            this.txtAlmMaxWt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAlmMaxWt.Location = new System.Drawing.Point(101, 310);
            this.txtAlmMaxWt.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlmMaxWt.Name = "txtAlmMaxWt";
            this.txtAlmMaxWt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmMaxWt.Properties.Appearance.Options.UseFont = true;
            this.txtAlmMaxWt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAlmMaxWt.Size = new System.Drawing.Size(120, 22);
            this.txtAlmMaxWt.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Alarm Min Wt.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 313);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Alarm Max Wt.";
            // 
            // frmWeightMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 508);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlmMaxWt);
            this.Controls.Add(this.txtAlmMinWt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtNomWt);
            this.Controls.Add(this.txtMaxWt);
            this.Controls.Add(this.txtMinWt);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridWt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWeightMaster";
            this.Text = "Weight Chart Master";
            this.Load += new System.EventHandler(this.frmWeightMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridWt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Wt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinWt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxWt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomWt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlmMinWt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlmMaxWt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridWt;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Wt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtSize;
        private System.Windows.Forms.ComboBox txtClass;
        private System.Windows.Forms.ComboBox txtLength;
        private DevExpress.XtraEditors.SpinEdit txtMinWt;
        private DevExpress.XtraEditors.SpinEdit txtMaxWt;
        private DevExpress.XtraEditors.SpinEdit txtNomWt;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SpinEdit txtAlmMinWt;
        private DevExpress.XtraEditors.SpinEdit txtAlmMaxWt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}