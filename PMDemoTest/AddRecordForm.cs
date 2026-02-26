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
    public partial class AddRecordForm : Form
    {
        Client currentClient_;
        MySQLModel model_;
        public AddRecordForm(Client currentClient, MySQLModel model)
        {
            InitializeComponent();
            model_ = model;
            currentClient_ = currentClient;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || PriceNumericUpDown.Value == 0 || CountNumericUpDown.Value == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                OrderRecord orderRecord = new OrderRecord();

                orderRecord.NameProduct = NameTextBox.Text;
                orderRecord.SaleDate = SaleDatePicker.Value;
                orderRecord.Price = Convert.ToDouble(PriceNumericUpDown.Value);
                orderRecord.Count = (int)CountNumericUpDown.Value;

                try
                {
                    model_.AddOrderRecord(currentClient_.GetId(), orderRecord);
                    DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
