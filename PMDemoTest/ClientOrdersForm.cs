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
    public partial class ClientOrdersForm : Form
    {
        Client currentClient_;
        MySQLModel model_;
        public ClientOrdersForm(Client currentClient, MySQLModel model)
        {
            InitializeComponent();
            model_ = model;
            currentClient_ = currentClient;
        }

        private void ClientOrdersForm_Load(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            AddRecordForm recordForm = new AddRecordForm(currentClient_, model_);
            if(recordForm.ShowDialog() == DialogResult.OK)
            {
                RefreshOrders();
                MessageBox.Show("Record Added");
            }
        }

        private void RefreshOrders()
        {
            RecordTable.DataSource = model_.GetOrdersForClient(currentClient_.GetId());
        }
    }
}
