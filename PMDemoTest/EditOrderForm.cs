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
    public partial class EditOrderForm : Form
    {
        OrderRecord currentRecord_;
        MySQLModel model_;
        public EditOrderForm(OrderRecord currentRecord, MySQLModel model)
        {
            InitializeComponent();
            model_ = model;
            currentRecord_ = currentRecord;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || PriceNumericUpDown.Value == 0 || CountNumericUpDown.Value == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentRecord_.NameProduct = NameTextBox.Text;
            currentRecord_.SaleDate = SaleDatePicker.Value;
            currentRecord_.Price = Convert.ToDouble(PriceNumericUpDown.Value);
            currentRecord_.Count = (int)CountNumericUpDown.Value;

            try
            {
                model_.UpdateOrderRecord(0/*поле id должно быть у рекорда, могли бы передавать только currentRecord_ и потом получать айди через него*/, currentRecord_);
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

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = currentRecord_.NameProduct;
            SaleDatePicker.Value = currentRecord_.SaleDate;
            PriceNumericUpDown.Value = (decimal)currentRecord_.Price;
            CountNumericUpDown.Value = currentRecord_.Count;
        }
    }
}
