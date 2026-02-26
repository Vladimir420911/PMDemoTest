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
    public partial class ClientView: UserControl
    {
        private Client client_;
        public ClientView()
        {
            InitializeComponent();
        }

        public void ShowClientInfo(Client client)
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

        private void ClientView_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void ClientView_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
