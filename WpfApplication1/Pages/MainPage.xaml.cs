using System;
using System.Windows.Controls;
using System.Management;

namespace WpfApplication1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            UserName.Header = Environment.UserName;
            ShowMotherBoard();
            ShowProcessor();
            ShowMemory();
            ShowGPU();
            
        }
        private void ShowMotherBoard()
        {
            ManagementObjectSearcher seacher = new ManagementObjectSearcher("\\root\\CIMV2", "select * from Win32_BaseBoard");
            foreach (var x in seacher.Get())
            {
                motherboard.Items.Add("Manufactor : " + x["Manufacturer"]);
                motherboard.Items.Add("Product : " + x["Product"]);
                motherboard.Items.Add("S/N : " + x["SerialNumber"]);
            }
        }
        private void ShowProcessor()
        {
            ManagementObjectSearcher processor = new ManagementObjectSearcher("\\root\\CIMV2", "select * from Win32_Processor");
            foreach (var x in processor.Get())
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = x["Name"];
                item.Items.Add("Cors : "+ x["NumberOfCores"]);
                item.Items.Add("Logical Processors : " + x["NumberOfLogicalProcessors"]);
                item.Items.Add("Base speed : " + x["MaxClockSpeed"] + " MHz");
                proc.Items.Add(item);
            }
        }
        private void ShowMemory()
        {
            UInt64 totalMemory = 0;
            ManagementObjectSearcher raminfo = new ManagementObjectSearcher("\\root\\CIMV2", "select * from Win32_PhysicalMemory");
            foreach (var x in raminfo.Get())
            {
                UInt64 temp = (UInt64)x["Capacity"] / 1024 / 1024 / 1024;
                totalMemory += temp;
                TreeViewItem item = new TreeViewItem();
                item.Header = ("RAM " +  temp.ToString() + " GB");
                item.Items.Add("Manufactor : " + x["Manufacturer"]);
                item.Items.Add("Capacity " +((UInt64)x["Capacity"] / 1024 / 1024 / 1024).ToString() + " GB");
                item.Items.Add("Speed : "+ x["Speed"] + " MHz");
                item.Items.Add("S/N " + x["SerialNumber"]);
                memory.Items.Add(item);
            }
            memory.Header = memory.Header + " " + totalMemory.ToString() + " GB";
        }
        private void ShowGPU()
        {
            ManagementObjectSearcher gpu = new ManagementObjectSearcher("\\root\\CIMV2", "select * from Win32_VideoController");
            foreach (var x in gpu.Get())
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = x["Name"];
                item.Items.Add("VideoProcessor : " + x["VideoProcessor"]);
                item.Items.Add("Memory : " + (UInt32)x["AdapterRAM"] / 1024 / 1024 / 1024 + " GB");
                gpuu.Items.Add(item);
            }
        }
    }
}
