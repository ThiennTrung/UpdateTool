namespace UpdateTool
{
    partial class ConfigForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BENHVIEN_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simpleButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(837, 47);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(748, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 36);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(837, 273);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KEY,
            this.VALUE,
            this.BENHVIEN_ID,
            this.TEXT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // KEY
            // 
            this.KEY.Caption = "KEY";
            this.KEY.FieldName = "KEY";
            this.KEY.Name = "KEY";
            this.KEY.Visible = true;
            this.KEY.VisibleIndex = 1;
            this.KEY.Width = 235;
            // 
            // VALUE
            // 
            this.VALUE.Caption = "VALUE";
            this.VALUE.FieldName = "VALUE";
            this.VALUE.Name = "VALUE";
            this.VALUE.Visible = true;
            this.VALUE.VisibleIndex = 2;
            this.VALUE.Width = 1099;
            // 
            // BENHVIEN_ID
            // 
            this.BENHVIEN_ID.Caption = "BENHVIEN_ID";
            this.BENHVIEN_ID.FieldName = "BENHVIEN_ID";
            this.BENHVIEN_ID.Name = "BENHVIEN_ID";
            this.BENHVIEN_ID.Visible = true;
            this.BENHVIEN_ID.VisibleIndex = 0;
            this.BENHVIEN_ID.Width = 112;
            // 
            // TEXT
            // 
            this.TEXT.Caption = "TEXT";
            this.TEXT.FieldName = "TEXT";
            this.TEXT.MinWidth = 17;
            this.TEXT.Name = "TEXT";
            this.TEXT.Visible = true;
            this.TEXT.VisibleIndex = 3;
            this.TEXT.Width = 169;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 320);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KEY;
        private DevExpress.XtraGrid.Columns.GridColumn VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn BENHVIEN_ID;
        private DevExpress.XtraGrid.Columns.GridColumn TEXT;
    }
}