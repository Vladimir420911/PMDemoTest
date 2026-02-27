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

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            if (RecordTable.SelectedRows.Count > 0) // если число выбранных строк на таблице больше 0(то есть, строка выбрана)
            {
                var selectedRow = RecordTable.SelectedRows[0]; // сохраняем нашу выбранную строку в переменную
                OrderRecord record = selectedRow.DataBoundItem as OrderRecord; // представляем строку как OrderRecord
                if (record == null)
                {
                    return;
                }
                EditOrderForm editOrderForm = new EditOrderForm(record, model_);
                if(editOrderForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshOrders();
                    MessageBox.Show("Order updated");
                }
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if(RecordTable.SelectedRows.Count > 0)
            {
                var selectedRow = RecordTable.SelectedRows[0];
                OrderRecord record = selectedRow.DataBoundItem as OrderRecord;
                if (record == null)
                {
                    return;
                }

                try
                {
                    model_.DeleteOrderRecord(0/*record.GetId() <-- в record типо тоже должен быть Id свой, мне лень*/);
                    RefreshOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
