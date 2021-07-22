using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using To_work_with_Files_by_Adapter_pattern_in_MVVM.ViewModels;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MainViewModel() { MainWindows = this };
        }

        private void NameTBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (NameTBox.Text == "Name")
            {
                NameTBox.Text = null;



                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);

                NameTBox.Foreground = new SolidColorBrush(color1);


            }
        }

        private void NameTBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (NameTBox.Text == "")
            {

                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);

                NameTBox.Text = "Name";
                NameTBox.Foreground = new SolidColorBrush(color2);
            }
        }

        private void SurnameTBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (SurnameTBox.Text == "")
            {

                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);

                SurnameTBox.Text = "Surname";
                SurnameTBox.Foreground = new SolidColorBrush(color2);
            }
        }

        private void SurnameTBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (SurnameTBox.Text == "Surname")
            {
                SurnameTBox.Text = null;



                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);

                SurnameTBox.Foreground = new SolidColorBrush(color1);


            }
        }

        private void EmailTBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (EmailTBox.Text == "")
            {

                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);

                EmailTBox.Text = "Email";
                EmailTBox.Foreground = new SolidColorBrush(color2);
            }
        }

        private void EmailTBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (EmailTBox.Text == "Email")
            {
                EmailTBox.Text = null;



                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);

                EmailTBox.Foreground = new SolidColorBrush(color1);


            }
        }
    }
}
