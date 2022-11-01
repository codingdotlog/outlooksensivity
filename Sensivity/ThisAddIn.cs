using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace Sensivity
{
    public partial class ThisAddIn
    {
        public String[] domains;
        public String[] recipents;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.ItemSend += new Microsoft.Office.Interop.Outlook.ApplicationEvents_11_ItemSendEventHandler(Application_ItemSend);
            try
            {
                string loggedUser = Environment.UserName;
                string filePath = "C:\\Users\\" + loggedUser + "\\AppData\\Local\\Microsoft\\Office\\Settings.txt";
                List<string> list = new List<string>();
                if (File.Exists(filePath))
                {
                    foreach (string line in System.IO.File.ReadLines(filePath))
                    {
                        string[] split = line.Split('\n');
                        list.Add(split[0]);
                    }

                    domains = list.ToArray();
                }
                else
                {
                    StreamWriter sw = File.CreateText(filePath);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        private void Application_ItemSend(object Item, ref bool Cancel)
        {
            Outlook.MailItem mail = Item as Outlook.MailItem;
            if (mail != null)
            {
                var mipLabels = mail.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/string/{00020386-0000-0000-C000-000000000046}/msip_labels/0x0000001F") as string;
                recipents = GetSMTPAddressForRecipients(mail);
                bool isInternal = mipLabels.Contains("INTERNAL");
                //bool isPublic = mipLabels.Contains("PUBLIC");
                bool isContains = true;
                foreach(string recipent in recipents)
                {
                    if(!domains.Contains(recipent))
                    {
                        isContains = false;
                    }
                }
                if (isInternal==true && isContains==false)
                {
                    MessageBox.Show("Internal Maili Şirket Dışında Gönderemezsiniz!\nYou Cannot Send Internal Mail Outside the Company!","Outlook", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cancel = true;
                }
            }
            
        }

        private string[] GetSMTPAddressForRecipients(Outlook.MailItem mail)
        {
            List<string> list = new List<string>();
            const string PR_SMTP_ADDRESS = "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";
            Outlook.Recipients recips = mail.Recipients;
            string emailsFound = "";
            string[] splitted;
            foreach (Outlook.Recipient recip in recips)
            {
                Outlook.PropertyAccessor pa = recip.PropertyAccessor;
                emailsFound = pa.GetProperty(PR_SMTP_ADDRESS);
                splitted = emailsFound.Split('@');
                list.Add(splitted[1]);
            }
            return list.ToArray();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
