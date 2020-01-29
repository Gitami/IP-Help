using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;

namespace WindowsFormsApplication2
{
    public partial class IPhelpForm : Form
    {
        public IPhelpForm()
        {
            InitializeComponent();

            string myHost = Dns.GetHostName();
            string myIPv4 = null;
            string myIPv6 = null;
            string mytmp = null;
            string sysVersion = "1.02";
            
            systemuptime.Text = null;

            for (int i = 0; i <= Dns.GetHostEntry(myHost).AddressList.Length - 1; i++){
                if (Dns.GetHostEntry(myHost).AddressList[i].IsIPv6LinkLocal == false){
                    if (Dns.GetHostEntry(myHost).AddressList[i].AddressFamily.ToString() == "InterNetworkV6")
                    {
                        myIPv6 = myIPv6 + Dns.GetHostEntry(myHost).AddressList[i].ToString() + "\n";
                    }
                    else if (Dns.GetHostEntry(myHost).AddressList[i].AddressFamily.ToString() == "InterNetwork")
                    {
                        mytmp = Dns.GetHostEntry(myHost).AddressList[i].ToString();
                        if (!mytmp.StartsWith("10.0") && !mytmp.StartsWith("172.16") && !mytmp.StartsWith("192.168") && !mytmp.StartsWith("169.254"))
                        {
                            myIPv4 = myIPv4 + Dns.GetHostEntry(myHost).AddressList[i].ToString() + "\n";
                        }
                        else {
                            myIPv6 = myIPv6 + Dns.GetHostEntry(myHost).AddressList[i].ToString() + "\n";
                        }
                    }
                    
                }

            }


            userlabel.Text = System.Environment.UserDomainName.ToString().ToUpper()
                            + " \\ "
                            + System.Environment.UserName.ToString().ToUpper();


            machinelabel.Text = System.Environment.MachineName.ToString().ToUpper()
                                + "\n"
                                + regFetchValue("BaseBoardManufacturer", "HARDWARE\\DESCRIPTION\\System\\BIOS")
                                + "\n"
                                + regFetchValue("SystemProductName","HARDWARE\\DESCRIPTION\\System\\BIOS")
                                ;
                            



            if (myIPv4 != null){
                IPv4address.Text = myIPv4;
            }
            else {
                IPv4address.ForeColor = IPv4address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
                IPv4address.Text = "No address found";
            }

            if (myIPv6 != null){
                IPv6address.Text = myIPv6;
            }
            else{
                IPv6addressheadline.Text = "";
                IPv6address.Text = "";
            }

            appversion.Text = "v." + sysVersion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Function for fetchine registry data

        public static string regFetchValue(string Name, string regloc)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(regloc);
            if (key != null)
            {
                try
                {
                    string myKey = key.GetValue(Name).ToString();
                    return myKey;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        private void ticktimer_Tick(object sender, EventArgs e)
        {
            string tmpdays = "";
            string tmphours = "";

            if (TimeSpan.FromMilliseconds(System.Environment.TickCount).Days != 0){
                    tmpdays = TimeSpan.FromMilliseconds(System.Environment.TickCount).Days.ToString()
                              + " days ";
                }
            if (TimeSpan.FromMilliseconds(System.Environment.TickCount).Hours != 0){
                    tmphours = TimeSpan.FromMilliseconds(System.Environment.TickCount).Hours.ToString()
                               + " hours ";
                }

            systemuptime.Text = "Since boot: "
                            + tmpdays
                            + tmphours 
                            + TimeSpan.FromMilliseconds(System.Environment.TickCount).Minutes.ToString() + " min ";

            ticktimer.Interval = 30000;

        }


    }
}
