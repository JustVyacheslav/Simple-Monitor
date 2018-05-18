using System;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Proparty.xaml
    /// </summary>
    public partial class Proparty : Window
    {
        private int cpuCritical;
        public int CpuTempCritical { get { return cpuCritical; } set {cpuCritical = value; CpuCritical.Text = value.ToString(); } }

        private int ramCritical;
        public int RamLoadCritical { get { return ramCritical; } set { ramCritical = value; RamCritical.Text = value.ToString(); } }

        private int gpuCritical;
        public int GpuTempCritical { get { return gpuCritical; } set { gpuCritical = value; GpuCritical.Text = value.ToString(); } }


        public Proparty()
        {
            InitializeComponent();
            CpuTempCritical = 80;
            RamLoadCritical = 90;
            GpuTempCritical = 80;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cpuCritical = (int)Convert.ToUInt32(CpuCritical.Text);
            } 
            catch
            {
                cpuCritical = 80;
            }
            try
            {
                ramCritical = (int)Convert.ToUInt32(RamCritical.Text);
            }
            catch
            {
                ramCritical = 90;
            }
            try
            {
                gpuCritical = (int)Convert.ToUInt32(GpuCritical.Text);
            }
            catch
            {
                gpuCritical = 80;
            }
            this.DialogResult = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
