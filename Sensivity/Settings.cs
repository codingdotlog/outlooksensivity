using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensivity
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public string filePath;

        private void Settings_Load(object sender, EventArgs e)
        {
            string loggedUser = Environment.UserName;
            filePath = "C:\\Users\\"+ loggedUser + "\\AppData\\Local\\Microsoft\\Office\\Settings.txt";

            loadSettings();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            listView_domains.Clear();
            string prepare = textBox_domain.Text.ToString() + '\n';
            System.IO.File.AppendAllText(filePath, prepare);
            loadSettings();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            removeLine(listView_domains.SelectedIndices[0], filePath);
        }



        void loadSettings()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    foreach (string line in System.IO.File.ReadLines(filePath))
                    {
                        string[] split = line.Split('\n');
                        //
                        listView_domains.Items.Add(split[0]);

                    }
                }
                else
                {
                    StreamWriter sw = File.CreateText(filePath);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }



        void removeLine(int Line, string Path)
        {
            StringBuilder sb = new StringBuilder();
            Line = Line + 1;
            using (StreamReader sr = new StreamReader(Path))
            {
                int Countup = 0;
                while (!sr.EndOfStream)
                {
                    Countup++;
                    if (Countup != Line)
                    {
                        using (StringWriter sw = new StringWriter(sb))
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(sb.ToString());
            }
            //
            listView_domains.Items[Line - 1].Remove();
        }


    }
}
