namespace ZepAnalysisPackage
{
    partial class Analysis : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Analysis()
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
            this.ZepAnalysisTools = this.Factory.CreateRibbonTab();
            this.Statistics = this.Factory.CreateRibbonGroup();
            this.Distribution = this.Factory.CreateRibbonButton();
            this.ZepAnalysisTools.SuspendLayout();
            this.Statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZepAnalysisTools
            // 
            this.ZepAnalysisTools.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.ZepAnalysisTools.Groups.Add(this.Statistics);
            this.ZepAnalysisTools.Label = "Zep Analysis Tools";
            this.ZepAnalysisTools.Name = "ZepAnalysisTools";
            // 
            // Statistics
            // 
            this.Statistics.Items.Add(this.Distribution);
            this.Statistics.Label = "Statistics";
            this.Statistics.Name = "Statistics";
            // 
            // Distribution
            // 
            this.Distribution.Image = global::ZepAnalysisPackage.Properties.Resources.Standard_deviation_diagram_svg;
            this.Distribution.Label = "Distribution";
            this.Distribution.Name = "Distribution";
            this.Distribution.ShowImage = true;
            this.Distribution.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Distribution_Click);
            // 
            // Analysis
            // 
            this.Name = "Analysis";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.ZepAnalysisTools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Analysis_Load);
            this.ZepAnalysisTools.ResumeLayout(false);
            this.ZepAnalysisTools.PerformLayout();
            this.Statistics.ResumeLayout(false);
            this.Statistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab ZepAnalysisTools;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Statistics;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Distribution;
    }

    partial class ThisRibbonCollection
    {
        internal Analysis Analysis
        {
            get { return this.GetRibbon<Analysis>(); }
        }
    }
}
