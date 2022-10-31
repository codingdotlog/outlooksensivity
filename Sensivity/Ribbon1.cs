using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Outlook;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.Diagnostics;
using System.IO;
using Exception = System.Exception;
using Application = System.Windows.Forms.Application;

namespace Sensivity
{
    public partial class Ribbon1
    {

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            


        }

        private void button_settings_Click(object sender, RibbonControlEventArgs e)
        {
            Form Settings = new Settings();
            Settings.Show();
        }






    }
}
