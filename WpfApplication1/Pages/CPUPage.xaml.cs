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
    /// Логика взаимодействия для CPUPage.xaml
    /// </summary>
    public partial class CPUPage : Page
    {

        public string ProcessorName { get; set; }
        private Processor proc;
        private string cpuTemperature;
        private string cpuLoad;

        public string CpuTemp { get { return cpuTemperature; } }
        public string CpuLoad { get { return cpuLoad; } }
        private int cpuCritical;
        public int CpuCriticalTemp
        {
            get { return cpuCritical; }
            set { cpuCritical = value; }
        }

        public event EventHandler CpuInCriticalTemperature;
        public CPUPage()
        {
            InitializeComponent();
            cpuCritical = 80;
            proc = new Processor();
            UpdateCpuInfo();
            ManagementObjectSearcher processor = new ManagementObjectSearcher("\\root\\CIMV2", "select * from Win32_Processor");
            foreach (var x in processor.Get())
            {
                CpuName.Text = (string)x["Name"];
            }
        }
        private int count = 0;
        public void UpdateCpuInfo()
        {

            double loading = (int)proc.GetCurrentTotalLoad();
            int temp = (int)proc.GetCurrentTemperature();

            if (temp > CpuCriticalTemp)
            {
                if (count++ > 10)
                {
                    count = 0;
                    if (CpuInCriticalTemperature != null)
                        CpuInCriticalTemperature(this, new EventArgs());
                }
            }
            else
                count = 0;
            
            cpuTemperature = proc.GetCurrentTemperature().ToString() + " °C";
            cpuLoad = loading.ToString() + "%";
            processCpu.Value = (int)loading;
            processCpu1.Value = temp;
            processCpu.TextInCenter = CpuLoad;
            processCpu1.TextInCenter = CpuTemp;

        }
    }
}
