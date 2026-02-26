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

namespace ClientsView
{
    public partial class ClientView : UserControl
    {
        public ClientView()
        {
            InitializeComponent();
        }

        public void ShowClientInfo(Client client)
        {
            TitleLabel.Text = client.Name;
            DescriptionLabel.Text = client.Description;
            PhoneLabel.Text = client.Phone;
            MailLabel.Text = client.Mail;
            AvatarBox.Load(client.ImagePath);
        }
    }
}
