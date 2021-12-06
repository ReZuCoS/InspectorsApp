using System;
using System.Windows.Forms;
using InspectorsApp.Models;

namespace InspectorsApp.Forms
{
    public partial class AuthForm : Form
    {
        public ModelDatabase Database { get; set; }

        private int _tries = 2;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void CloseApp(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Login(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == "" || textBoxPassword.Text == "")   // Validating null textboxes
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var user = Database.Users.Find(textBoxLogin.Text);

            if (_tries == 0)    // System blocking on 1 minute if _tries == 0
            {
                _tries = 2;

                textBoxLogin.Enabled = false;
                textBoxPassword.Enabled = false;
                loginButton.Enabled = false;
                exitButton.Enabled = false;

                blockTimer.Enabled = true;

                MessageBox.Show("Неверный логин или пароль!\nСистема заблокированна на 1 минуту!");
                return;
            }

            if (user == null || user.Password != textBoxPassword.Text)
            {
                MessageBox.Show($"Неправильный логин или пароль!\nОсталось попыток: {_tries}");

                _tries -= 1;

                return;
            }


            DialogResult = DialogResult.OK;
        }

        private void blockTimerTick(object sender, EventArgs e) // 1 minute block timer tick
        {
            textBoxLogin.Enabled = true;
            textBoxPassword.Enabled = true;
            loginButton.Enabled = true;
            exitButton.Enabled = true;

            blockTimer.Enabled = false;
        }
    }
}
