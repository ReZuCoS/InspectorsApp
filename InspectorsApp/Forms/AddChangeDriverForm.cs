using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using InspectorsApp.Models;

namespace InspectorsApp.Forms
{
    public partial class AddChangeDriverForm : Form
    {
        public ModelDatabase Database { get; set; } // Database model

        public Driver Driver { get; set; } = null;  // Driver object

        private string _imagePath = null;

        public AddChangeDriverForm()
        {
            InitializeComponent();
        }

        private void SaveDriver(object sender, EventArgs e)
        {
            if (FormValidated())    // Start saving changes after validating
            {
                if(Driver == null)  
                {
                    Driver = new Driver
                    {
                        SecondName = secondNameTextBox.Text,
                        FirstName = firstNameTextBox.Text,
                        MiddleName = middleNameTextBox.Text,
                        Passport = passportTextBox.Text,
                        RegistrationAddress = registrationAddressTextBox.Text,
                        LivingAddress = livingAddressTextBox.Text,
                        Company = companyTextBox.Text,
                        Jobname = jobnameTextBox.Text,
                        Phone = phoneTextBox.Text,
                        Email = emailTextBox.Text,
                        Photo = _imagePath,
                        Description = descriptionTextBox.Text
                    };

                    Database.Drivers.Add(Driver);   // adding new user
                }

                else
                {
                    Driver.SecondName = secondNameTextBox.Text;
                    Driver.FirstName = firstNameTextBox.Text;
                    Driver.MiddleName = middleNameTextBox.Text;
                    Driver.Passport = passportTextBox.Text;
                    Driver.RegistrationAddress = registrationAddressTextBox.Text;
                    Driver.LivingAddress = livingAddressTextBox.Text;
                    Driver.Company = companyTextBox.Text;
                    Driver.Jobname = jobnameTextBox.Text;
                    Driver.Phone = phoneTextBox.Text;
                    Driver.Email = emailTextBox.Text;
                    
                    if(_imagePath != null)
                    {
                        Driver.Photo = _imagePath;
                    }

                    Driver.Description = descriptionTextBox.Text;
                }

                try
                {
                    Database.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private bool FormValidated()
        {
            List<TextBox> notNullTextBoxes = new List<TextBox>()
            {
                secondNameTextBox,
                firstNameTextBox,
                middleNameTextBox,
                passportTextBox,
                registrationAddressTextBox,
                phoneTextBox,
                emailTextBox
            };

            List<TextBox> textOnlyTextBoxes = new List<TextBox>()
            {
                secondNameTextBox,
                firstNameTextBox,
                middleNameTextBox
            };

            List<TextBox> digitsOnlyTextBoxes = new List<TextBox>()
            {
                passportTextBox,
                phoneTextBox
            };

            foreach (TextBox tb0 in notNullTextBoxes)   // Validating nulls values
            {
                if(tb0.Text == "")
                {
                    MessageBox.Show("Заполните все поля отмеченные звёздочкой! (*)");  
                    return false;
                }
            }

            foreach (TextBox tb1 in textOnlyTextBoxes)  // Validating letters only
            {
                if (ContainsDigitsOrSymbols(tb1))
                {
                    MessageBox.Show("Поля ФИО не должны содержать цифр или сиволов!");
                    return false;
                }
            }

            foreach(TextBox tb2 in digitsOnlyTextBoxes) // Validating digits only
            {
                if (ContainsLettersOrSymbols(tb2))
                {
                    MessageBox.Show("Поля Паспорт и Номер телефона не должны содержать символов или букв!");
                    return false;
                }
            }

            if(pictureBox.Image == null)
            {
                MessageBox.Show("Установите фото водителя!");
                return false;
            }

            return true;
        }

        private bool ContainsDigitsOrSymbols(TextBox textBox)
        {
            foreach(char ch in textBox.Text)
            {
                if (!char.IsLetter(ch))
                {
                    return true;
                }
            }

            return false;
        }

        private bool ContainsLettersOrSymbols(TextBox textBox)
        {
            foreach (char ch in textBox.Text)
            {
                if (!char.IsDigit(ch))
                {
                    return true;
                }
            }

            return false;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            if(Driver == null)  // If driver value is null - we're using this form as Adding
            {
                this.Text = "Добавление водителя";
            }
            else
            {
                this.Text = "Изменение пользователя";

                secondNameTextBox.Text = Driver.SecondName;
                firstNameTextBox.Text = Driver.FirstName;
                middleNameTextBox.Text = Driver.MiddleName;
                passportTextBox.Text = Driver.Passport;
                registrationAddressTextBox.Text = Driver.RegistrationAddress;
                livingAddressTextBox.Text = Driver.LivingAddress;
                companyTextBox.Text = Driver.Company;
                jobnameTextBox.Text = Driver.Jobname;
                phoneTextBox.Text = Driver.Phone;
                emailTextBox.Text = Driver.Email;
                descriptionTextBox.Text = Driver.Description;

                pictureBox.Image = new Bitmap($@"{Environment.CurrentDirectory}\Resources\{Driver.Photo}");
            }
        }

        private void CancelAddChange(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void HasMiddleName(object sender, EventArgs e)  // If driver has'nt a middle name, it replases by "нет"
        {
            if (checkBoxMiddleName.Checked)
            {
                middleNameTextBox.Text = "нет";
                middleNameTextBox.Enabled = false;
            }
            else
            {
                middleNameTextBox.Text = "";
                middleNameTextBox.Enabled = true;
            }
        }

        private void LivingAddressLikeRegistration(object sender, EventArgs e)  // If driver lives on registration address, we're making link on it
        {
            if (checkBoxLivingAddress.Checked)
            {
                livingAddressTextBox.Text = registrationAddressTextBox.Text;
                livingAddressTextBox.Enabled = false;
            }
            else
            {
                livingAddressTextBox.Text = "";
                livingAddressTextBox.Enabled = true;
            }
        }

        private void OnAddressTextChanging(object sender, EventArgs e)
        {
            if (checkBoxLivingAddress.Checked)
            {
                livingAddressTextBox.Text = registrationAddressTextBox.Text;
            }
        }

        private void ChangePhoto(object sender, EventArgs e)    // Changing driver photo
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                Title = "Выбор изображения",
                InitialDirectory = $@"C:\Users\{Environment.UserName}\"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _imagePath = fileDialog.FileName;

                pictureBox.Image = new Bitmap(_imagePath);
            }
        }
    }
}
