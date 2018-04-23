namespace Q144234 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.myTreeList1 = new DXSample.MyTreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myTreeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // myTreeList1
            // 
            this.myTreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.myTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTreeList1.Location = new System.Drawing.Point(0, 0);
            this.myTreeList1.Name = "myTreeList1";
            this.myTreeList1.BeginUnboundLoad();
            this.myTreeList1.AppendNode(new object[] {
            null,
            null}, -1);
            this.myTreeList1.AppendNode(new object[] {
            null,
            null}, 0);
            this.myTreeList1.AppendNode(new object[] {
            null,
            null}, -1);
            this.myTreeList1.AppendNode(new object[] {
            null,
            null}, 2);
            this.myTreeList1.AppendNode(new object[] {
            null,
            null}, -1);
            this.myTreeList1.AppendNode(new object[] {
            null,
            null}, 4);
            this.myTreeList1.AppendNode(new object[] {
            null,
            null}, -1);
            this.myTreeList1.AppendNode(new object[] {
            null,
            null}, 6);
            this.myTreeList1.EndUnboundLoad();
            this.myTreeList1.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.myTreeList1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.myTreeList1.OptionsSelection.MultiSelect = true;
            this.myTreeList1.OptionsView.ShowFocusedFrame = false;
            this.myTreeList1.Size = new System.Drawing.Size(445, 268);
            this.myTreeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.MinWidth = 38;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "treeListColumn2";
            this.treeListColumn2.FieldName = "treeListColumn2";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 268);
            this.Controls.Add(this.myTreeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myTreeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyTreeList myTreeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;




    }
}

