
namespace InspectorsApp.Forms
{
    partial class AddChangeDriverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label jobnameLabel;
            System.Windows.Forms.Label livingAddressLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label registrationAddressLabel;
            System.Windows.Forms.Label secondNameLabel;
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.jobnameTextBox = new System.Windows.Forms.TextBox();
            this.livingAddressTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.registrationAddressTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkBoxLivingAddress = new System.Windows.Forms.CheckBox();
            this.checkBoxMiddleName = new System.Windows.Forms.CheckBox();
            companyLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            jobnameLabel = new System.Windows.Forms.Label();
            livingAddressLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            registrationAddressLabel = new System.Windows.Forms.Label();
            secondNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(12, 201);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(121, 20);
            companyLabel.TabIndex = 1;
            companyLabel.Text = "Место работы:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 329);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(108, 20);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Примечание:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 297);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(63, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "E-mail*:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 41);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(50, 20);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "Имя*:";
            // 
            // jobnameLabel
            // 
            jobnameLabel.AutoSize = true;
            jobnameLabel.Location = new System.Drawing.Point(12, 233);
            jobnameLabel.Name = "jobnameLabel";
            jobnameLabel.Size = new System.Drawing.Size(99, 20);
            jobnameLabel.TabIndex = 11;
            jobnameLabel.Text = "Должность:";
            // 
            // livingAddressLabel
            // 
            livingAddressLabel.AutoSize = true;
            livingAddressLabel.Location = new System.Drawing.Point(12, 169);
            livingAddressLabel.Name = "livingAddressLabel";
            livingAddressLabel.Size = new System.Drawing.Size(157, 20);
            livingAddressLabel.TabIndex = 13;
            livingAddressLabel.Text = "Адрес проживания:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(12, 73);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(93, 20);
            middleNameLabel.TabIndex = 15;
            middleNameLabel.Text = "Отчество*:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(12, 105);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(84, 20);
            passportLabel.TabIndex = 17;
            passportLabel.Text = "Паспорт*:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(12, 265);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(142, 20);
            phoneLabel.TabIndex = 19;
            phoneLabel.Text = "Телефон* (без 7):";
            // 
            // registrationAddressLabel
            // 
            registrationAddressLabel.AutoSize = true;
            registrationAddressLabel.Location = new System.Drawing.Point(12, 137);
            registrationAddressLabel.Name = "registrationAddressLabel";
            registrationAddressLabel.Size = new System.Drawing.Size(167, 20);
            registrationAddressLabel.TabIndex = 23;
            registrationAddressLabel.Text = "Адрес регистрации*:";
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Location = new System.Drawing.Point(12, 9);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new System.Drawing.Size(91, 20);
            secondNameLabel.TabIndex = 25;
            secondNameLabel.Text = "Фамилия*:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(180, 198);
            this.companyTextBox.MaxLength = 100;
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(313, 26);
            this.companyTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(180, 326);
            this.descriptionTextBox.MaxLength = 300;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(313, 26);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(180, 294);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(313, 26);
            this.emailTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(180, 38);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(313, 26);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // jobnameTextBox
            // 
            this.jobnameTextBox.Location = new System.Drawing.Point(180, 230);
            this.jobnameTextBox.MaxLength = 100;
            this.jobnameTextBox.Name = "jobnameTextBox";
            this.jobnameTextBox.Size = new System.Drawing.Size(313, 26);
            this.jobnameTextBox.TabIndex = 12;
            // 
            // livingAddressTextBox
            // 
            this.livingAddressTextBox.Location = new System.Drawing.Point(180, 166);
            this.livingAddressTextBox.MaxLength = 300;
            this.livingAddressTextBox.Name = "livingAddressTextBox";
            this.livingAddressTextBox.Size = new System.Drawing.Size(194, 26);
            this.livingAddressTextBox.TabIndex = 14;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(180, 70);
            this.middleNameTextBox.MaxLength = 50;
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(249, 26);
            this.middleNameTextBox.TabIndex = 16;
            // 
            // passportTextBox
            // 
            this.passportTextBox.Location = new System.Drawing.Point(180, 102);
            this.passportTextBox.MaxLength = 10;
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(313, 26);
            this.passportTextBox.TabIndex = 18;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(180, 262);
            this.phoneTextBox.MaxLength = 10;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(313, 26);
            this.phoneTextBox.TabIndex = 20;
            // 
            // registrationAddressTextBox
            // 
            this.registrationAddressTextBox.Location = new System.Drawing.Point(180, 134);
            this.registrationAddressTextBox.MaxLength = 300;
            this.registrationAddressTextBox.Name = "registrationAddressTextBox";
            this.registrationAddressTextBox.Size = new System.Drawing.Size(313, 26);
            this.registrationAddressTextBox.TabIndex = 24;
            this.registrationAddressTextBox.TextChanged += new System.EventHandler(this.OnAddressTextChanging);
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(180, 6);
            this.secondNameTextBox.MaxLength = 50;
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(313, 26);
            this.secondNameTextBox.TabIndex = 26;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(578, 361);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(167, 29);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelAddChange);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 361);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(167, 29);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveDriver);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.Location = new System.Drawing.Point(497, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(248, 250);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 29;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.ChangePhoto);
            // 
            // checkBoxLivingAddress
            // 
            this.checkBoxLivingAddress.AutoSize = true;
            this.checkBoxLivingAddress.Location = new System.Drawing.Point(380, 168);
            this.checkBoxLivingAddress.Name = "checkBoxLivingAddress";
            this.checkBoxLivingAddress.Size = new System.Drawing.Size(113, 24);
            this.checkBoxLivingAddress.TabIndex = 32;
            this.checkBoxLivingAddress.Text = "Совпадает";
            this.checkBoxLivingAddress.UseVisualStyleBackColor = true;
            this.checkBoxLivingAddress.CheckedChanged += new System.EventHandler(this.LivingAddressLikeRegistration);
            // 
            // checkBoxMiddleName
            // 
            this.checkBoxMiddleName.AutoSize = true;
            this.checkBoxMiddleName.Location = new System.Drawing.Point(435, 72);
            this.checkBoxMiddleName.Name = "checkBoxMiddleName";
            this.checkBoxMiddleName.Size = new System.Drawing.Size(58, 24);
            this.checkBoxMiddleName.TabIndex = 33;
            this.checkBoxMiddleName.Text = "Нет";
            this.checkBoxMiddleName.UseVisualStyleBackColor = true;
            this.checkBoxMiddleName.CheckStateChanged += new System.EventHandler(this.HasMiddleName);
            // 
            // AddChangeDriverForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(757, 402);
            this.Controls.Add(this.checkBoxMiddleName);
            this.Controls.Add(this.checkBoxLivingAddress);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(jobnameLabel);
            this.Controls.Add(this.jobnameTextBox);
            this.Controls.Add(livingAddressLabel);
            this.Controls.Add(this.livingAddressTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(registrationAddressLabel);
            this.Controls.Add(this.registrationAddressTextBox);
            this.Controls.Add(secondNameLabel);
            this.Controls.Add(this.secondNameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(773, 441);
            this.MinimumSize = new System.Drawing.Size(773, 441);
            this.Name = "AddChangeDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЦЕЛЕВОЕ ДЕЙСТВИЕ";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox jobnameTextBox;
        private System.Windows.Forms.TextBox livingAddressTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox registrationAddressTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox checkBoxLivingAddress;
        private System.Windows.Forms.CheckBox checkBoxMiddleName;
    }
}