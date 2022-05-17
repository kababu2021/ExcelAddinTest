using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HandyControl.Tools;

namespace ExcelAddInHCSimple
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void btnSimpleHCControl_Click(object sender, RibbonControlEventArgs e)
        {
            var hcTestAppInstance = new HcTestApp();
        }
    }
}
