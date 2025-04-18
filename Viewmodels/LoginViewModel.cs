using System.Windows.Input;
using System.Windows;
using PulseLogin.Helpers;

namespace PulseLogin.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string? _username;
        public string? Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public ICommand LoginCommand { get; }
        public ICommand ForgotPasswordCommand { get; }

        public LoginViewModel()
        {
            _username = string.Empty; // Inicializar para evitar advertencia
            LoginCommand = new RelayCommand(ExecuteLogin);
            ForgotPasswordCommand = new RelayCommand(ExecuteForgotPassword);
        }

        private void ExecuteLogin()
        {
            // Aquí iría la lógica de inicio de sesión
            MessageBox.Show("Iniciando sesión con usuario: " + (Username ?? "No especificado"));
        }

        private void ExecuteForgotPassword()
        {
            MessageBox.Show("Funcionalidad de recuperación de contraseña");
        }
    }
}