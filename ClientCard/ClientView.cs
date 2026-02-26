using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace ClientCard
{
    public partial class ClientView: UserControl // для карточки создаем библиотеку элементов управления WinForms(добавляем в нее ссылку на ClassLib, а также в сам проект форм добавляем ссылку на карточку)
    {
        private Client client_;
        public ClientView()
        {
            InitializeComponent();
        }

        public void ShowClientInfo(Client client) // вызываем этот метод на основной форме
        {
            client_ = client;

            TitleLabel.Text = client.Name;
            DescriptionLabel.Text = client.Description;
            PhoneLabel.Text = client.Phone;
            MailLabel.Text = client.Mail;
            AvatarBox.Load(client.ImagePath);
        }

        public Client GetClient()
        {
            return client_;
        }

        private void ClientView_MouseMove(object sender, MouseEventArgs e) // когда мышка попадает на карточку цвет меняется на голубой(как бы выделили)
        {
            this.BackColor = Color.LightBlue;
        }

        private void ClientView_MouseLeave(object sender, EventArgs e) // когда мышка покидает карточку цвет возвращается
        {
            this.BackColor = Color.White;
        }
    }
}
