using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Speech.Synthesis;

using NLog;


namespace WpfApplication1
{
    partial class MainViewModel : INotifyPropertyChanged
    {
        private SpeechSynthesizer synth;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private System.Windows.Threading.DispatcherTimer timer;
        private DispatcherTimer timerForLog;
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public MainViewModel()
        {
            synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Male);
            synth.Rate = 4;

            cpuPage = new Pages.CPUPage();
            mainPage = new Pages.MainPage();
            ramPage = new Pages.RAMPage();
            gpuPage = new Pages.GPUPage();

            cpuPage.CpuInCriticalTemperature += CpuPage_CpuInCriticalTemperature;
            ramPage.RamLowMemory += RamPage_RamLowMemory;
            gpuPage.GpuCriticalTemperature += GpuPage_GpuCriticalTemperature;
            current = mainPage;
            mainSelected = "LightGray";

            timer = GetTimer(1);
            timer.Tick += Timer_Tick;
            timer.Start();
              
            timerForLog = GetTimer(10);
            timerForLog.Tick += TimerForLog_Tick;
            timerForLog.Start();
        }

        private void GpuPage_GpuCriticalTemperature(object sender, EventArgs e)
        {
            synth.Speak("джи пи у воорнинг");
        }

        private void RamPage_RamLowMemory(object sender, EventArgs e)
        {
            synth.Speak("меморри  эндинг" );
        }

        private void CpuPage_CpuInCriticalTemperature(object sender, EventArgs e)
        {
            synth.Speak("си пи ю воорнинг");
        }

        private void TimerForLog_Tick(object sender, EventArgs e)
        {
            string textLog = string.Format("     CPU [ {0,-9} , {1,-7} ] RAM [ {2,-8} , {3,-10} ] GPU [ {4,-11} , {5,-9} ]", h, l, rl, ra, gl, gt);
            logger.Info(textLog);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            cpuPage.UpdateCpuInfo();
            ramPage.UpdateRamInfo();
            gpuPage.UpdateGpuInfo();
            PropertyChangedInfo();

        }
        private void PropertyChangedInfo()
        {
            OnPropertyChanged("h");
            OnPropertyChanged("rl");
            OnPropertyChanged("ra");
            OnPropertyChanged("gl");
            OnPropertyChanged("gt");
            OnPropertyChanged("l");
        }
        private DispatcherTimer GetTimer(int seconds)
        {
            DispatcherTimer t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, seconds);
            return t;
        }


    }
    partial class MainViewModel : INotifyPropertyChanged
    {
        private Page current;
        private Pages.CPUPage cpuPage;
        private Pages.RAMPage ramPage;
        private Pages.MainPage mainPage;
        private Pages.GPUPage gpuPage;

        public Page CurrentPage
        {
            get { return current; }
        }

        public Page CPUpage
        {
            get { return cpuPage; }
        }

        public Page MAINpage
        {
            get { return mainPage; }
        }

        public Page RAMpage
        {
            get { return ramPage; }
        }

        public Page GPUpage
        {
            get { return gpuPage; }
        }


    }
    partial class MainViewModel : INotifyPropertyChanged
    {
        private RelayCommand showMain;
        private RelayCommand showCpu;
        private RelayCommand showRam;
        private RelayCommand showGpu;
        private RelayCommand showProperty;

        public RelayCommand ShowMain
        {
            get
            {
                return showProperty ??
                    (showProperty = new RelayCommand((obj) =>
                    {
                        current = mainPage;
                        MakeBackgroundWhite();
                        MainSelected = "LightGray";
                        OnPropertyChanged("CurrentPage");
                    }));
            }
        }
        public RelayCommand ShowCpu
        {
            get
            {
                return showCpu ??
                    (showCpu = new RelayCommand((obj) =>
                    {
                        current = cpuPage;
                        MakeBackgroundWhite();
                        CpuSelected = "LightGray";
                        OnPropertyChanged("CurrentPage");
                    }));
            }
        }
        public RelayCommand ShowRam
        {
            get
            {
                return showRam ??
                    (showRam = new RelayCommand((obj) =>
                    {
                        current = ramPage;
                        MakeBackgroundWhite();
                        RamSelected = "LightGray";
                        OnPropertyChanged("CurrentPage");
                    }));
            }
        }
        public RelayCommand ShowGpu
        {
            get
            {
                return showGpu ??
                    (showGpu = new RelayCommand((obj) =>
                    {
                        current = gpuPage;
                        MakeBackgroundWhite();
                        GpuSelected = "LightGray";
                        OnPropertyChanged("CurrentPage");
                    }));
            }
        }
        public RelayCommand ShowPropartyWindow
        {
            get
            {
                return showMain ??
                    (showMain = new RelayCommand((obj) =>
                    {
                        var prop = new Proparty();
                        prop.CpuTempCritical = cpuPage.CpuCriticalTemp;
                        prop.RamLoadCritical = ramPage.RamCriticalPercentLoad;
                        prop.GpuTempCritical = gpuPage.GpuTempCritical;
                        if (prop.ShowDialog() == true)
                        {
                            
                            cpuPage.CpuCriticalTemp = prop.CpuTempCritical;
                            ramPage.RamCriticalPercentLoad = prop.RamLoadCritical;
                            gpuPage.GpuTempCritical = prop.GpuTempCritical;
                        }
                    }));
            }
        }
         

    }
    partial class MainViewModel : INotifyPropertyChanged
    {
        private string mainSelected;
        private string cpuSelected;
        private string ramSelected;
        private string gpuSelected;
        public string MainSelected
        {
            get { return mainSelected; }
            private set
            {
                mainSelected = value;
                OnPropertyChanged("MainSelected");
            }
        }
        public string CpuSelected
        {
            get { return cpuSelected; }
            private set
            {
                cpuSelected = value;
                OnPropertyChanged("CpuSelected");
            }
        }
        public string RamSelected
        {
            get { return ramSelected; }
            private set
            {
                ramSelected = value;
                OnPropertyChanged("RamSelected");
            }
        }
        public string GpuSelected
        {
            get { return gpuSelected; }
            private set
            {
                gpuSelected = value;
                OnPropertyChanged("GpuSelected");
            }
        }
        private void MakeBackgroundWhite()
        {
            MainSelected = "White";
            CpuSelected = "White";
            RamSelected = "White";
            GpuSelected = "White";
        }

    }
    partial class MainViewModel : INotifyPropertyChanged
    {
        public string h { get { return "T: " + cpuPage.CpuTemp; } }
        public string l { get { return "L: " + cpuPage.CpuLoad; } }
        public string rl { get { return "L: " + ramPage.RamLoad; } }
        public string ra { get { return "A: " + ramPage.RamAvailable; } }
        public string gl { get { return "C: " + gpuPage.GpuClock; } }
        public string gt { get { return "T: " + gpuPage.GpuTemp; } }

    }
}
