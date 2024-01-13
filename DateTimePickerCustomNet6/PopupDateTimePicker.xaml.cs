using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DateTimePickerCustomNet6
{
    /// <summary>
    /// Interaction logic for PopupDateTimePicker.xaml
    /// </summary>
    public partial class PopupDateTimePicker : UserControl, INotifyPropertyChanged
    {
        private DateTime _resultMonthAndYear = DateTime.Now;  // Property to hold the selected month and year (second row)
        public DateTime ResultMonthAndYear
        {
            get { return _resultMonthAndYear; }
            set
            {
                if (_resultMonthAndYear != value)
                {
                    _resultMonthAndYear = value;
                    OnPropertyChanged(nameof(ResultMonthAndYear));// INotifyPropertyChanged, the string of the selectedDate (from changing month buttons)
                    
                }
            }
        }

        private TimeOnly _resultTime = TimeOnly.FromDateTime(DateTime.Now);  // Property to hold the Active Time (first row)
        public TimeOnly ResultTime
        {
            get { return _resultTime; }
            set
            {
                if (_resultTime != value)
                {
                    _resultTime = value;
                    OnPropertyChanged(nameof(ResultTime));// INotifyPropertyChanged, the string of the selectedDate (from changing month buttons)
                    
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;// INotifyPropertyChanged implementation
        public PopupDateTimePicker()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ToggleButtonControl_Checked(object sender, RoutedEventArgs e)
        {
            DateTimePickerPopup.IsOpen = true;
        }

        private void ToggleButtonControl_Unchecked(object sender, RoutedEventArgs e)
        {
            DateTimePickerPopup.IsOpen = false;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

 

        private void OK_click(object sender, RoutedEventArgs e)
        {
            ResultMonthAndYear = DatePickerWidget.ResultDate;
            ResultTime = TimePickerWidget.ResultTime;
            ToggleButtonControl_Unchecked(sender, e);
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            ToggleButtonControl_Unchecked(sender, e);
        }
    }

 
}
