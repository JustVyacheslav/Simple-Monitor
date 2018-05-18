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
    /// Логика взаимодействия для GPUPage.xaml
    /// </summary>
    public partial class GPUPage : Page
    {
        public event EventHandler GpuCriticalTemperature;
        private Gpu gpu;
        private string gpuTemp;
        private string gpuClock;
        public string GpuTemp { get { return gpuTemp; } }
        public string GpuClock { get { return gpuClock; } }

        private int gpuCriticalTemperture;
        public int GpuTempCritical
        {
            get { return gpuCriticalTemperture; }
            set { gpuCriticalTemperture = value; }
        }

        public GPUPage()
        {
            InitializeComponent();
            gpuCriticalTemperture = 80;
            gpu = new Gpu();
            GpuName.Text = gpu.Name;
        }
        private int count = 0;
        public void UpdateGpuInfo()
        {
            int temp = (int)gpu.GetTemerature();
            if (temp > GpuTempCritical)
            {
                if (count++ > 10)
                {
                    count = 0;
                    if (GpuCriticalTemperature != null)
                        GpuCriticalTemperature(this, new EventArgs());
                }
            }
            else
                count = 0;
            gpuTemp = temp.ToString() + " °C";
            x1.Text = "Memory : " + gpu.GetGpuMemoryTotal() + " MB";
            x2.Text = "Av. Memory : " + Math.Round(gpu.GetGpuMemoryAvailable(),2).ToString() + " MB" ;
            x3.Text = "Clock : " + (int)gpu.GetGpuClock() + " MHz";
            TempGpu.Value = temp;
            TempGpu.TextInCenter = GpuTemp;
            gpuClock = ((int)gpu.GetGpuClock()).ToString() + " MHz";
        }
    }
}
