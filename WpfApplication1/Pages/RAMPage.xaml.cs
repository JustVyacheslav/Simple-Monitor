using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Management;

namespace WpfApplication1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RAMPage.xaml
    /// </summary>
    public partial class RAMPage : Page
    {
        public event EventHandler RamLowMemory;
        private RAM ram;
        private string ramLoad;
        private string ramAvailable;
        public string RamLoad { get { return ramLoad; } }
        public string RamAvailable { get { return ramAvailable; } }

        private int ramCriticalLoad;
        public int RamCriticalPercentLoad
        {
            get { return ramCriticalLoad; }
            set { ramCriticalLoad = value; }
        }

        public RAMPage()
        {
            InitializeComponent();

            ramCriticalLoad = 90;
            ram = new RAM();
            UInt64 totalMemory = 0;
            ManagementObjectSearcher raminfo = new ManagementObjectSearcher("\\root\\CIMV2", "select * from Win32_PhysicalMemory");
            foreach (var x in raminfo.Get())
            {
                totalMemory += (UInt64)x["Capacity"] / 1024 / 1024 / 1024;
                
            }
            PhMemory.Text = "Physical Memory " + totalMemory + " GB";
            UpdateRamInfo();
        }
        private int count = 0;
        public void UpdateRamInfo()
        {
            int load = (int)ram.GetInUsePercent();
            int aval = (int)ram.GetAvailableMbytes();
            if (load > RamCriticalPercentLoad)
            {
                if (count++ > 10)
                {
                    count = 0;
                    if (RamLowMemory != null)
                        RamLowMemory(this, new EventArgs());
                }
            }
            else
                count = 0;
                
            ramLoad = load.ToString() + " %";
            ramAvailable = aval + " MB";

            CompMemoryLoad.TextInCenter = RamLoad;
            CompMemoryAv.TextInCenter = RamAvailable + "\n( " + (100 - load) + "%)";
            CompMemoryLoad.Value = load;
            CompMemoryAv.Value = 100-load;
        }
    }
}
