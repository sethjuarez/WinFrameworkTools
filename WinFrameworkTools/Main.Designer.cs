namespace WinFrameworkTools
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Main()
        {
            /// <summary>
            /// Required for Windows.Forms Class Composition Designer support
            /// </summary>
            InitializeComponent();
        }

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
            this.actionCreateMainModule = new DevExpress.CodeRush.Core.Action(this.components);
            this.actionCreatePaneModule = new DevExpress.CodeRush.Core.Action(this.components);
            this.actionCreateEditModule = new DevExpress.CodeRush.Core.Action(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Images16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCreateMainModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCreatePaneModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCreateEditModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // actionCreateMainModule
            // 
            this.actionCreateMainModule.ActionName = "CreateMainModule";
            this.actionCreateMainModule.ButtonText = "Create Main Module";
            this.actionCreateMainModule.CommonMenu = DevExpress.CodeRush.Menus.VsCommonBar.ProjectContext;
            this.actionCreateMainModule.GroupName = "Modules";
            this.actionCreateMainModule.ImageBackColor = System.Drawing.Color.Empty;
            this.actionCreateMainModule.ToolbarItem.ButtonIsPressed = false;
            this.actionCreateMainModule.ToolbarItem.Caption = null;
            this.actionCreateMainModule.ToolbarItem.Image = null;
            this.actionCreateMainModule.ToolbarItem.ToolbarName = null;
            this.actionCreateMainModule.Execute += new DevExpress.CodeRush.Core.CommandExecuteEventHandler(this.actionCreateMainModule_Execute);
            // 
            // actionCreatePaneModule
            // 
            this.actionCreatePaneModule.ActionName = "CreatePaneModule";
            this.actionCreatePaneModule.ButtonText = "Create Pane Module";
            this.actionCreatePaneModule.CommonMenu = DevExpress.CodeRush.Menus.VsCommonBar.ProjectContext;
            this.actionCreatePaneModule.GroupName = "Modules";
            this.actionCreatePaneModule.ImageBackColor = System.Drawing.Color.Empty;
            this.actionCreatePaneModule.ToolbarItem.ButtonIsPressed = false;
            this.actionCreatePaneModule.ToolbarItem.Caption = null;
            this.actionCreatePaneModule.ToolbarItem.Image = null;
            this.actionCreatePaneModule.ToolbarItem.ToolbarName = null;
            this.actionCreatePaneModule.Execute += new DevExpress.CodeRush.Core.CommandExecuteEventHandler(this.actionCreatePaneModule_Execute);
            // 
            // actionCreateEditModule
            // 
            this.actionCreateEditModule.ActionName = "CreateEditModule";
            this.actionCreateEditModule.ButtonText = "Create Edit Module";
            this.actionCreateEditModule.CommonMenu = DevExpress.CodeRush.Menus.VsCommonBar.ProjectContext;
            this.actionCreateEditModule.GroupName = "Modules";
            this.actionCreateEditModule.ImageBackColor = System.Drawing.Color.Empty;
            this.actionCreateEditModule.ToolbarItem.ButtonIsPressed = false;
            this.actionCreateEditModule.ToolbarItem.Caption = null;
            this.actionCreateEditModule.ToolbarItem.Image = null;
            this.actionCreateEditModule.ToolbarItem.ToolbarName = null;
            this.actionCreateEditModule.Execute += new DevExpress.CodeRush.Core.CommandExecuteEventHandler(this.actionCreateEditModule_Execute);
            ((System.ComponentModel.ISupportInitialize)(this.Images16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCreateMainModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCreatePaneModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCreateEditModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.CodeRush.Core.Action actionCreateMainModule;
        private DevExpress.CodeRush.Core.Action actionCreatePaneModule;
        private DevExpress.CodeRush.Core.Action actionCreateEditModule;
    }
}