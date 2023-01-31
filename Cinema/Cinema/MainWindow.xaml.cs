using System;
using System.Windows;

namespace Cinema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.mainFrame = mainFrame;
            mainFrame.Navigate(new Authorization());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.GoBack();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (Manager.mainFrame.CanGoBack)
            {
                this.ResizeMode = ResizeMode.CanResize;
                btnBack.Visibility = Visibility.Visible;
            }
            else
            {
                this.ResizeMode = ResizeMode.NoResize;
                btnBack.Visibility = Visibility.Collapsed;
            }

            if (Manager.user == null)
            {
                userInfo.Visibility = Visibility.Collapsed;
            }
            else
            {
                userInfo.Text = "Пользователь: " + Manager.user.Name + " " + Manager.user.Surname;
                userInfo.Visibility = Visibility.Visible;
            }
        }
    }
}
