using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication1.circularbar
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class MyBar : UserControl
    {
        public static readonly DependencyProperty TextInCenterProperty = DependencyProperty.Register("TextInCenter", typeof(string), typeof(MyBar));
        public string TextInCenter
        {
            get { return (string)this.GetValue(TextInCenterProperty); }
            set { this.SetValue(TextInCenterProperty, value); }
        }

        public static readonly DependencyProperty IndicatorBrushProperty = DependencyProperty.Register("IndicatorBrush", typeof(Brush), typeof(MyBar));
        public Brush IndicatorBrush
        {
            get { return (Brush)this.GetValue(IndicatorBrushProperty); }
            set { this.SetValue(IndicatorBrushProperty, value); }
        }
        public static readonly DependencyProperty BackgroundBrushProperty = DependencyProperty.Register("BackgroundBrush", typeof(Brush), typeof(MyBar));
        public Brush BackgroundBrush
        {
            get { return (Brush)this.GetValue(BackgroundBrushProperty); }
            set { this.SetValue(BackgroundBrushProperty, value); }
        }
        public static readonly DependencyProperty ProgressBorderBrushProperty = DependencyProperty.Register("ProgressBorderBrush", typeof(Brush), typeof(MyBar));
        public Brush ProgressBorderBrush
        {
            get { return (Brush)this.GetValue(ProgressBorderBrushProperty); }
            set { this.SetValue(ProgressBorderBrushProperty, value); }
        }
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(MyBar));
        public int Value
        {
            get { return (int)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }
        public MyBar()
        {

            InitializeComponent();
        }
    }
   
    public class ValueToAngleConverter : IValueConverter
    {
        public object Convert(object value, Type t, object parameter, System.Globalization.CultureInfo culture)
        {
            return (double)(((int)value * 0.01) * 360);
        }

        public object ConvertBack(object value, Type t, object parameter, System.Globalization.CultureInfo culture)
        {
            return (double)((double)value / 360) * 100;
        }
    }


}
