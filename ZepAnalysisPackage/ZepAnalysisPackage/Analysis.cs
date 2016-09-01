using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using IronPython.Hosting;


namespace ZepAnalysisPackage
{
    public partial class Analysis
    {
        private void Analysis_Load(object sender, RibbonUIEventArgs e)
        {


        }

        /// <summary> 
        /// User wants to make a distribution
        /// </summary>
        private void Distribution_Click(object sender, RibbonControlEventArgs e)
        {
            //User wants to make a distribution plot
            Console.WriteLine("What would you like to print from python?");

        }
    }
}
