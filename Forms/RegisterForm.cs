// AnimeClient/RegisterForm.cs
using System;
using System.Windows.Forms;

namespace AnimeClient
{
    public partial class RegisterForm : Form
    {
        private readonly ApiClient _apiClient;

        public RegisterForm(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Все поля обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = await _apiClient.RegisterAsync(username, email, password);
            MessageBox.Show(result, "Результат регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result != null && result.Contains("успешно"))
            {
                this.Close(); // Закрываем форму после успешной регистрации
            }
        }
    }
}