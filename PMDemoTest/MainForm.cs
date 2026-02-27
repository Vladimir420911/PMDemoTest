using ClassLib;
using System;
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            /// Наверно можно было сделать обновление без дополнительной формы
            /// То есть тупо делать на AddClientForm, можно было бы сделать поле на форме типо bool isEditMode
            /// и в зависимости от того на какую кнопку мы нажимаем эта переменная становилась бы true или false
            /// И на форме проверялось бы состояние isEditMode, и в зависимости от этого делали бы разные вещи(редактирование вместо добавления бож)
            /// Тогда пришлось бы заводить дополнительный конструктор(вроде так можно), потому что если мы редактируем, нам нужно получить клиента(которого мы хотим отредактировать)
            /// А сейсас в конструкторе тока model
            /// 
            /// Кароче хз сделал по тупому, много повторных действий, но пофиг
            EditClientForm editForm = new EditClientForm(Card.GetClient(), model); // форме надо скормить айди выбранного клиента(клиент в данный момент отображающийся на карточке)
                                                                                   // и модель
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                RefreshClients();
                MessageBox.Show("Client updated");
            }
        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                model.DeleteClient(Card.GetClient().GetId()); // тут передаем айди клиента, для того, чтобы передать в запрос и удалить его нафиг >:)
                RefreshClients();
                MessageBox.Show("Client deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
