using DateTimePickerCustomNet6;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestCalander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime myDate = DatePickerWidget.ResultDate;
        public TimeOnly myTime = TimePickerWidget.ResultTime;
        public MainWindow()
        {
            
            InitializeComponent();
        }


    }
}