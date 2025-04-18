using System.Windows;
using System.Windows.Input;
using PulseLogin.ViewModels;

namespace PulseLogin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Permitir arrastrar la ventana desde cualquier parte
            this.MouseLeftButtonDown += (s, e) =>
            {
                if (e.ButtonState == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            };
        }

        private void CloseButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ForgotPassword_Click(object sender, MouseButtonEventArgs e)
        {
            var viewModel = this.DataContext as LoginViewModel;
            viewModel?.ForgotPasswordCommand.Execute(null);
        }
    }
}