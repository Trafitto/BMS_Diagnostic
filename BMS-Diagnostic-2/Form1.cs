using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_Diagnostic_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<InstalledProgram> instPrograms = new List<InstalledProgram>();
        List<InstalledProgram> TOTinstPrograms = new List<InstalledProgram>();
        List<string> PanelPrg = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            ScanBar.Visible = false;
            ScanBar.Enabled = false;
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanBar.Visible = true;
            ScanBar.Enabled = true;
            btnScan.Enabled = false;
            btnFile.Enabled = true;
            lbl1.Visible = true;
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            ScanBar.Value += 10;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            ScanBar.Value += 10;
            foreach (ManagementObject mo in mos.Get())
            {
                PanelPrg.Add(Convert.ToString(mo["Name"]));
            }
            ScanBar.Value += 50;
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        //Console.WriteLine(subkey.GetValue("DisplayName"));
                        //Console.WriteLine(subkey.GetValue("EstimatedSize"));
                        foreach (string prog in PanelPrg)
                        { 
                            if (prog == Convert.ToString(subkey.GetValue("DisplayName")) && prog!=null && prog!="")
                            {
                                instPrograms.Add(new InstalledProgram(Convert.ToString(subkey.GetValue("DisplayName")),
                           Convert.ToString(subkey.GetValue("DisplayVersion")), Convert.ToString(subkey.GetValue("InstallDate")), Convert.ToSingle(subkey.GetValue("EstimatedSize")), Convert.ToString(subkey.GetValue("InstallLocation")), Convert.ToString(subkey.GetValue("Publisher"))));
                            }
                            TOTinstPrograms.Add(new InstalledProgram(Convert.ToString(subkey.GetValue("DisplayName")),
                           Convert.ToString(subkey.GetValue("DisplayVersion")), Convert.ToString(subkey.GetValue("InstallDate")), Convert.ToSingle(subkey.GetValue("EstimatedSize")), Convert.ToString(subkey.GetValue("InstallLocation")), Convert.ToString(subkey.GetValue("Publisher"))));
                        }
                    }
                }
            }
            ScanBar.Value += 10;
            grdProgrammi.DataSource = dataSet1.Tables["InstallPrg"];
            foreach (InstalledProgram iP in instPrograms)
            { 
                iP.estimatedSize = iP.estimatedSize / 1024;
                InstallTable.Rows.Add(iP.displayName, iP.displayVersion, iP.estimatedSize.ToString("n2") + " Mb", iP.installDate, iP.installLocation, iP.publisher);
            }
            ScanBar.Value += 20;
            btnScan.Enabled = true;
            ScanBar.Visible = false;
            ScanBar.Value = 0;
            ScanBar.Enabled = false;
            lbl1.Visible = false;

        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            string FileName = "SW_" + System.DateTime.Now.ToString("dd_MM_yy") + ".csv";
            StreamWriter sw = File.CreateText(@"BMS-Diagnostic-2" + FileName);
            sw.WriteLine("Nome "+";"+"Versione "+";"+"Dimensione (Mb)"+";"+"Data installazione"+";"+"Locazione"+";"+"Autore");
            sw.WriteLine();
            foreach (InstalledProgram iP in instPrograms)
            {
                sw.WriteLine(iP.displayName+";"+ iP.displayVersion+";"+iP.estimatedSize+";"+iP.installDate+";"+iP.installLocation+";"+iP.publisher);
            }
            sw.Close();
        }
    }
}
