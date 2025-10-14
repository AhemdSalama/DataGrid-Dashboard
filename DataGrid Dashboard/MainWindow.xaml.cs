using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace DataGrid_Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                //Check the button clicked and move the window
                this.DragMove();
            }
        }

        private bool IsMaxmized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // On double click maximize the window
            if (e.ClickCount == 2)
            {
                if (IsMaxmized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaxmized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaxmized = true;
                }
            }

        }
    }
}