using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.ComponentModel;
using System.Security.Policy;

namespace ClassLib
{
    public class MySQLModel
    {
        private const string connString = "server=localhost;user=root;database=clients_db;password=123456;port=3307;";

        public int GetClientCount()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(id) FROM clientsinfo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    return count;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public BindingList<Client> ReadAllClients()
        {
            BindingList<Client> clients = new BindingList<Client>();

            try
            {
                using(MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();

                    string query = "SELECT id, clientName, phone, mail, description, imagePath FROM clientsinfo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Client client = new Client(reader.GetInt32(0));
                            client.Name = reader.GetString(1);
                            client.Phone = reader.GetString(2);
                            client.Mail = reader.GetString(3);
                            client.Description = reader.GetString(4);
                            client.ImagePath = reader.GetString(5);

                            clients.Add(client);
                        }
                    }

                    return clients;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AddClient(Client client)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    string query = "INSERT INTO clientsinfo(id, clientName, phone, mail, description, imagePath) VALUES (@id, @clientName, @phone, @mail, @description, @imagePath)";
                
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", client.GetId());
                    cmd.Parameters.AddWithValue("@clientName", client.Name);
                    cmd.Parameters.AddWithValue("@phone", client.Phone);
                    cmd.Parameters.AddWithValue("@mail", client.Mail);
                    cmd.Parameters.AddWithValue("@description", client.Description);
                    cmd.Parameters.AddWithValue("@imagePath", client.ImagePath);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BindingList<OrderRecord> GetOrdersForClient(int id)
        {
            BindingList<OrderRecord> records = new BindingList<OrderRecord>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();

                    string query = $"SELECT article, date, price, count FROM orders WHERE idClient = '{id}'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            OrderRecord record = new OrderRecord();
                            record.NameProduct = reader.GetString(0);
                            record.SaleDate = reader.GetDateTime(1);
                            record.Price = reader.GetDouble(2);
                            record.Count = reader.GetInt32(3);

                            records.Add(record);
                        }
                    }
                }

                return records;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddOrderRecord(int id, OrderRecord record)
        {
            try
            {
               using (MySqlConnection connection = new MySqlConnection(connString))
               {
                    connection.Open();

                    string query = "INSERT INTO orders(idclient, article, date, price, count) VALUES (@id, @article, @date, @price, @count)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@article", record.NameProduct);
                    cmd.Parameters.AddWithValue("@date", record.SaleDate);
                    cmd.Parameters.AddWithValue("@price", record.Price);
                    cmd.Parameters.AddWithValue("@count", record.Count);

                    cmd.ExecuteNonQuery();
               }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
