using ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMDemoTest
{
    public partial class EditClientForm : Form
    {
        Client currentClient_;
        MySQLModel model_;
        public EditClientForm(Client client, MySQLModel model) // получаем клиента, которого хотим отредактировать и модель
        {
            InitializeComponent();
            model_ = model;
            currentClient_ = client;
            PictureFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
        }

        private void EditClientForm_Load(object sender, EventArgs e) // при загрузке формы, заполняем текст боксы данными существующего клиента 
        {
            NameTextBox.Text = currentClient_.Name;
            PhoneTextBox.Text = currentClient_.Phone;
            MailTextBox.Text = currentClient_.Mail;
            DescriptionRichTextBox.Text = currentClient_.Description;
            ClientPictureBox.Load(currentClient_.ImagePath);
        }

        private void ChoosePictureButton_Click(object sender, EventArgs e)
        {
            if (PictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = $"../../../Resources/img/{PictureFileDialog.SafeFileName}";
                ClientPictureBox.ImageLocation = filepath;
            }
            else
            {
                return;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string newName = NameTextBox.Text;
            string newDescription = DescriptionRichTextBox.Text;
            string newPhone = PhoneTextBox.Text;
            string newMail = MailTextBox.Text;
            string newImagePath = ClientPictureBox.ImageLocation;

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newDescription)
                || string.IsNullOrWhiteSpace(newPhone) || string.IsNullOrWhiteSpace(newMail) || string.IsNullOrWhiteSpace(newImagePath))
            {
                MessageBox.Show("Поля не могут быть пустыми");
                return;
            }

            try
            {
                // тупо заменяем поля клиента, полями с формы(даже если мы меняли, чето одно, ниче страшного)
                currentClient_.Name = newName;
                currentClient_.Description = newDescription;
                currentClient_.Phone = newPhone;
                currentClient_.Mail = newMail;
                currentClient_.ImagePath = newImagePath;

                model_.UpdateClient(currentClient_); // вызываем метод для обновления нашего клиента
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
