namespace ExcelAddInHCSimple
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpTestGroup = this.Factory.CreateRibbonGroup();
            this.btnSimpleHCControl = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.grpTestGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.grpTestGroup);
            this.tab1.Label = "ExcelAddinHCSimple";
            this.tab1.Name = "tab1";
            // 
            // grpTestGroup
            // 
            this.grpTestGroup.Items.Add(this.btnSimpleHCControl);
            this.grpTestGroup.Label = "Test Group";
            this.grpTestGroup.Name = "grpTestGroup";
            // 
            // btnSimpleHCControl
            // 
            this.btnSimpleHCControl.Label = "Simple HC Control";
            this.btnSimpleHCControl.Name = "btnSimpleHCControl";
            this.btnSimpleHCControl.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSimpleHCControl_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpTestGroup.ResumeLayout(false);
            this.grpTestGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpTestGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSimpleHCControl;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
