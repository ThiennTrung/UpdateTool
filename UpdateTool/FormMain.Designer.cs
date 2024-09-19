using UpdateTool;

namespace UpdateTool
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains1 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains2 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkedListBoxControl2 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AppearanceCell.Options.UseTextOptions = true;
            this.TRANGTHAI.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TRANGTHAI.Caption = "STATUS";
            this.TRANGTHAI.FieldName = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = true;
            this.TRANGTHAI.VisibleIndex = 3;
            this.TRANGTHAI.Width = 76;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.checkEdit2);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.panel4);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1222, 53);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Connect";
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(34, 24);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Multi DB";
            this.checkEdit2.Size = new System.Drawing.Size(63, 20);
            this.checkEdit2.TabIndex = 12;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(898, 24);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Seach";
            this.checkEdit1.Size = new System.Drawing.Size(55, 20);
            this.checkEdit1.TabIndex = 11;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.EditValue = "";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(962, 24);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(199, 20);
            this.textEdit2.TabIndex = 10;
            this.textEdit2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit2_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.simpleButton5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1167, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 28);
            this.panel4.TabIndex = 9;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(3, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(46, 23);
            this.simpleButton5.TabIndex = 6;
            this.simpleButton5.Text = "SAVE";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(214, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(49, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Test";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(816, 22);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(76, 23);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Upload Form";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(-3, 21);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomPercent = 60D;
            this.pictureEdit1.Size = new System.Drawing.Size(36, 24);
            this.pictureEdit1.TabIndex = 6;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(754, 22);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(59, 23);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Run cript";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(678, 22);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(73, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Browser";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(266, 23);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(409, 20);
            this.textEdit1.TabIndex = 3;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scintilla1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 671);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // scintilla1
            // 
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Sql;
            this.scintilla1.Location = new System.Drawing.Point(736, 0);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(486, 671);
            this.scintilla1.TabIndex = 10;
            this.scintilla1.WrapMode = ScintillaNET.WrapMode.Word;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 671);
            this.panel2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridControl1.Location = new System.Drawing.Point(0, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(736, 570);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NAME,
            this.DATE,
            this.TRANGTHAI,
            this.path,
            this.MESS});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.TRANGTHAI;
            gridFormatRule1.ColumnApplyTo = this.TRANGTHAI;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleContains1.AllowAnimation = DevExpress.Utils.DefaultBoolean.False;
            formatConditionRuleContains1.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            formatConditionRuleContains1.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains1.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains1.Values")));
            gridFormatRule1.Rule = formatConditionRuleContains1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.TRANGTHAI;
            gridFormatRule2.ColumnApplyTo = this.TRANGTHAI;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleContains2.AllowAnimation = DevExpress.Utils.DefaultBoolean.False;
            formatConditionRuleContains2.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleContains2.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains2.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains2.Values")));
            gridFormatRule2.Rule = formatConditionRuleContains2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // NAME
            // 
            this.NAME.Caption = "FILE NAME";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 1;
            this.NAME.Width = 265;
            // 
            // DATE
            // 
            this.DATE.Caption = "DATE";
            this.DATE.FieldName = "DATE";
            this.DATE.Name = "DATE";
            this.DATE.Visible = true;
            this.DATE.VisibleIndex = 2;
            this.DATE.Width = 71;
            // 
            // path
            // 
            this.path.Caption = "path";
            this.path.FieldName = "path";
            this.path.Name = "path";
            // 
            // MESS
            // 
            this.MESS.Caption = "MESS";
            this.MESS.FieldName = "MESS";
            this.MESS.Name = "MESS";
            this.MESS.Visible = true;
            this.MESS.VisibleIndex = 4;
            this.MESS.Width = 273;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkedListBoxControl2);
            this.panel5.Controls.Add(this.checkedListBoxControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(736, 79);
            this.panel5.TabIndex = 16;
            // 
            // checkedListBoxControl2
            // 
            this.checkedListBoxControl2.ColumnWidth = 150;
            this.checkedListBoxControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxControl2.Enabled = false;
            this.checkedListBoxControl2.Location = new System.Drawing.Point(353, 0);
            this.checkedListBoxControl2.MultiColumn = true;
            this.checkedListBoxControl2.Name = "checkedListBoxControl2";
            this.checkedListBoxControl2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.checkedListBoxControl2.Size = new System.Drawing.Size(383, 79);
            this.checkedListBoxControl2.TabIndex = 16;
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.ColumnWidth = 150;
            this.checkedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedListBoxControl1.Enabled = false;
            this.checkedListBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxControl1.MultiColumn = true;
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.checkedListBoxControl1.Size = new System.Drawing.Size(353, 79);
            this.checkedListBoxControl1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 649);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 22);
            this.panel3.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(699, 22);
            this.progressBar1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(699, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Time";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::UpdateTool.Properties.Resources.icon;
            this.Name = "FormMain";
            this.Text = "UPDATE TOOL";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn DATE;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private DevExpress.XtraGrid.Columns.GridColumn path;
        private DevExpress.XtraGrid.Columns.GridColumn MESS;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl2;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

