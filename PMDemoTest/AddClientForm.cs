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
    public partial class AddClientForm : Form
    {
        MySQLModel model_;
        public AddClientForm(MySQLModel model)
        {
            InitializeComponent();
            PictureOpenDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            model_ = model;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string description = DescriptionRichTextBox.Text;
            string phone = PhoneTextBox.Text;
            string mail = MailTextBox.Text;
            string imagePath = ClientPictureBox.ImageLocation;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description)
                || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Поля не могут быть пустыми");
                return;
            }

            try
            {
                Client client = new Client(model_.GetClientCount() + 1);
                client.Name = name;
                client.Description = description;
                client.Phone = phone;
                client.Mail = mail;
                client.ImagePath = imagePath;

                model_.AddClient(client);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoosePictureButton_Click(object sender, EventArgs e)
        {
            if(PictureOpenDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = $"../../../Resources/img/{PictureOpenDialog.SafeFileName}";
                ClientPictureBox.ImageLocation = filepath;
            }
            else
            {
                return;
            }
        }
    }
}
