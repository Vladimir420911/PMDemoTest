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
    public partial class MainForm : Form
    {
        MySQLModel model;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                model = new MySQLModel();
                RefreshClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
        }

        private void ClientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ClientsListBox.SelectedItem;
            if(item == null)
            {
                return;
            }

            Client client = item as Client;
            if(client == null)
            {
                return;
            }

            Card.ShowClientInfo(client);
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            ClientOrdersForm ordersForm = new ClientOrdersForm(Card.GetClient(), model);
            ordersForm.Show();
        }

        private void RefreshClients()
        {
            ClientsListBox.DataSource = model.ReadAllClients();
            ClientsListBox.DisplayMember = "Name";
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(model);
            if(addClientForm.ShowDialog() == DialogResult.OK)
            {
                RefreshClients();
                MessageBox.Show("New client has been added");
            }
        }
    }
}
