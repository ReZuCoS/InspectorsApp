using System;
using System.Linq;
using System.Windows.Forms;
using InspectorsApp.Models;

namespace InspectorsApp.Forms
{
    public partial class TableDriversForm : Form
    {
        public ModelDatabase Database { get; set; }

        public TableDriversForm()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)   // Loading table from database
        {
            driverBindingSource.DataSource = Database.Drivers.ToList();
        }

        private void AddNewDriver(object sender, EventArgs e)   // Open form AddChangeDriverForm with user = null
        {
            var form = new AddChangeDriverForm()
            {
                Database = this.Database
            };

            DialogResult dialogResult = form.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                driverBindingSource.DataSource = Database.Drivers.ToList();
            }
        }

        private void DeleteSelectedDriver(object sender, EventArgs e)   // Delete marked by arrow row
        {
            Driver driver = (Driver)driverBindingSource.Current;

            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить пользователя:" +
                $"\n{driver.SecondName} {driver.FirstName} {driver.MiddleName}?\nЭто действие нельзя отменить!",
                "Удаление водителя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Database.Drivers.Remove(driver);
            }

            try
            {
                Database.SaveChanges();
                driverBindingSource.DataSource = Database.Drivers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeSelectedDriver(object sender, EventArgs e)   // Open form AddChangeDriverForm with user = current
        {
            Driver driver = (Driver)driverBindingSource.Current;

            var form = new AddChangeDriverForm()
            {
                Database = this.Database,
                Driver = driver
            };

            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                driverBindingSource.DataSource = Database.Drivers.ToList();
            }
        }
    }
}
