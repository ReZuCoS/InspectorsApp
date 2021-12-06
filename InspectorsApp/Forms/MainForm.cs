using System;
using System.IO;
using System.Windows.Forms;
using InspectorsApp.Models;

namespace InspectorsApp.Forms
{
    public partial class MainForm : Form    // Main form class
    {
        private readonly ModelDatabase _database = new ModelDatabase(); // Database object for application

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenDriversTable(object sender, EventArgs e)   // Open table "Drivers"
        {
            var form = new TableDriversForm()
            {
                Database = this._database   // Setting Database for another form
            };

            this.Hide();

            form.ShowDialog();

            this.Show();
        }

        private void CloseApp(object sender, EventArgs e)   // Application closing
        {
            Application.Exit();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            AuthForm form = new AuthForm() // Open auth form
            {
                Database = _database
            };

            if (form.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
    }
}
