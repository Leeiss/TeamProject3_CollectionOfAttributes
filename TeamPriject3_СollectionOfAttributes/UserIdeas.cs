using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class UserIdeas : Form
    {
        private string Login;
        List<string> addresses = new List<string>();
        List<string> addressesList = new List<string>();
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=collectionofattributes";
        public UserIdeas(string login)
        {
            InitializeComponent();
            Login = login;
        }

        private void UserIdeas_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT picturepath FROM ideas WHERE login = @login";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", Login);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string address = reader.GetString("picturepath");
                            addresses.Add(address);
                        }
                    }
                }
                connection.Close();
                foreach (string address in addresses)
                {
                    addressesList.Add(address);
                }
                if (addressesList.Count > 0)
                {
                    UpdateSaves(addresses);
                    addressesList.RemoveRange(0, 5);

                }
                else
                {
                    MessageBox.Show("У вас пока нет сохраненных фото, вернитесь на главное чтобы их добавить");
                }

            }
        }
        private async void UpdateSaves(List<string> list)
        {
            try
            {
                panelClosing.Visible = true;

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(list[0]);
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                    }
                }

                try
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync(list[1]);
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            pictureBox2.Image = Bitmap.FromStream(stream);
                        }
                    }
                }
                catch
                {
                    return;
                }

                try
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync(list[2]);
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            pictureBox3.Image = Bitmap.FromStream(stream);
                        }
                    }
                }
                catch
                {
                    return;
                }

                try
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync(list[3]);
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            pictureBox4.Image = Bitmap.FromStream(stream);
                        }
                    }
                }
                catch
                {
                    return;
                }

                try
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync(list[4]);
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            pictureBox5.Image = Bitmap.FromStream(stream);
                        }
                    }
                }
                catch
                {
                    return;
                }

                try
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync(list[5]);
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            pictureBox6.Image = Bitmap.FromStream(stream);
                        }
                    }
                }
                catch
                {
                    return;
                }
                panelClosing.Visible = false;
            }
            catch
            {
                MessageBox.Show("Необходимо подключение к vpn");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowIdeaForm showIdeaForm = new ShowIdeaForm(addressesList[0]);
            showIdeaForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowIdeaForm showIdeaForm = new ShowIdeaForm(addressesList[1]);
            showIdeaForm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowIdeaForm showIdeaForm = new ShowIdeaForm(addressesList[2]);
            showIdeaForm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowIdeaForm showIdeaForm = new ShowIdeaForm(addressesList[3]);
            showIdeaForm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowIdeaForm showIdeaForm = new ShowIdeaForm(addressesList[4]);
            showIdeaForm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowIdeaForm showIdeaForm = new ShowIdeaForm(addressesList[5]);
            showIdeaForm.ShowDialog();
        }

        private void label_go_forward_Click(object sender, EventArgs e)
        {
            try
            {
                if (addressesList.Count == 0)
                {
                    foreach (string address in addresses)
                    {
                        addressesList.Add(address);
                    }
                }
                UpdateSaves(addressesList);
                addressesList.RemoveRange(0, 5);
            }
            catch
            {
                MessageBox.Show("У вас пока нет сохраненных фото, вернитесь на главное чтобы их добавить");
            }
        }
    }
}
