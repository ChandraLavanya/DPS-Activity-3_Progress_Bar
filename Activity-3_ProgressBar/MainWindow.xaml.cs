using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Activity_3_ProgressBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProgressButton_Click(object sender, RoutedEventArgs e)
        {
            double i;
            for(i = 0; i <100; i++)
            {
                Dispatcher.Invoke(() => ProgressBar.Value = i, DispatcherPriority.Background);
            }
            
            string username = "";
            string password = "";
            if (UserNameTextBox.Text.Length == 0 && PasswordBox.Password.Length == 0)
            {
                Label1.Content = "Please enter User Name";
            }
            else
            {
                username = UserNameTextBox.Text;
                password = PasswordBox.Password;
                Label1.Content = "Welcome " + username;
            }
        }
    }
}
