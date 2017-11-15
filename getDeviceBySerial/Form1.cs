using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Windows.Input;
using System.Runtime.InteropServices;

namespace getDeviceBySerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            obSearch();
        }

        private void obSearch()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_Keyboard");
            mbsList = mbs.Get();
            
            foreach (ManagementObject mo in mbsList)
            {
                    listBox1.Items.Add(mo["DeviceID"].ToString());
            }
            
        }

    }
}
