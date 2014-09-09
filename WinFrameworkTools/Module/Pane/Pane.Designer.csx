namespace $rootnamespace$.Modules
{
    partial class $module$$sub$
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNew$module$ = new DevExpress.XtraEditors.SimpleButton();
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.treeListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNew$module$LayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew$module$LayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew$module$
            // 
            this.btnNew$module$.Image = global::DevExpress.OutlookInspiredApp.Win.Properties.Resources.icon_new_employee_16;
            this.btnNew$module$.Location = new System.Drawing.Point(14, 14);
            this.btnNew$module$.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew$module$.MaximumSize = new System.Drawing.Size(225, 0);
            this.btnNew$module$.MinimumSize = new System.Drawing.Size(225, 0);
            this.btnNew$module$.Name = "btnNew$module$";
            this.btnNew$module$.Size = new System.Drawing.Size(225, 26);
            this.btnNew$module$.StyleController = this.moduleLayout;
            this.btnNew$module$.TabIndex = 0;
            this.btnNew$module$.Text = "New $module$";
            // 
            // moduleLayout
            // 
            this.moduleLayout.Controls.Add(this.btnNew$module$);
            this.moduleLayout.Controls.Add(this.treeList);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Margin = new System.Windows.Forms.Padding(4);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.Root;
            this.moduleLayout.Size = new System.Drawing.Size(358, 665);
            this.moduleLayout.TabIndex = 3;
            // 
            // treeList
            // 
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Location = new System.Drawing.Point(12, 58);
            this.treeList.Margin = new System.Windows.Forms.Padding(4);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.DragNodes = true;
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList.OptionsView.ShowColumns = false;
            this.treeList.OptionsView.ShowFocusedFrame = false;
            this.treeList.OptionsView.ShowHorzLines = false;
            this.treeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.OptionsView.ShowVertLines = false;
            this.treeList.Size = new System.Drawing.Size(334, 595);
            this.treeList.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.treeListLayoutControlItem,
            this.btnNew$module$LayoutControlItem});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 6;
            this.Root.Size = new System.Drawing.Size(358, 665);
            this.Root.Text = "Root";
            // 
            // treeListLayoutControlItem
            // 
            this.treeListLayoutControlItem.Control = this.treeList;
            this.treeListLayoutControlItem.CustomizationFormText = "treeListLayoutControlItem";
            this.treeListLayoutControlItem.Location = new System.Drawing.Point(0, 46);
            this.treeListLayoutControlItem.Name = "treeListLayoutControlItem";
            this.treeListLayoutControlItem.Size = new System.Drawing.Size(338, 599);
            this.treeListLayoutControlItem.Text = "treeListLayoutControlItem";
            this.treeListLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.treeListLayoutControlItem.TextToControlDistance = 0;
            this.treeListLayoutControlItem.TextVisible = false;
            // 
            // btnNew$module$LayoutControlItem
            // 
            this.btnNew$module$LayoutControlItem.Control = this.btnNew$module$;
            this.btnNew$module$LayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew$module$LayoutControlItem.CustomizationFormText = "btnNew$module$LayoutControlItem";
            this.btnNew$module$LayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.btnNew$module$LayoutControlItem.Name = "btnNew$module$LayoutControlItem";
            this.btnNew$module$LayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 16);
            this.btnNew$module$LayoutControlItem.Size = new System.Drawing.Size(338, 46);
            this.btnNew$module$LayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.btnNew$module$LayoutControlItem.Text = "btnNew$module$LayoutControlItem";
            this.btnNew$module$LayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.btnNew$module$LayoutControlItem.TextToControlDistance = 0;
            this.btnNew$module$LayoutControlItem.TextVisible = false;
            this.btnNew$module$LayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // DashboardsFilterPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardsFilterPane";
            this.Size = new System.Drawing.Size(358, 665);
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew$module$LayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.SimpleButton btnNew$module$;
        private XtraLayout.LayoutControl moduleLayout;
        private XtraTreeList.TreeList treeList;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem treeListLayoutControlItem;
        private XtraLayout.LayoutControlItem btnNew$module$LayoutControlItem;

    }
}
