using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Registr_Click(object sender, EventArgs e)
        {
            if (invented_login.Text != "" & invented_password.Text != "" & invented_email.Text != "")
            {
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @Ul ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = invented_login.Text;

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command; // выполняем команду


                DataTable table = new DataTable();

                adapter.Fill(table);// записываем данные в объект класса DataTable


                if (table.Rows.Count == 0)
                {

                    MySqlCommand command1 = new MySqlCommand("INSERT INTO users (`login`, `password`, `email`) VALUES(@login, @password, @email)", db.GetConnection());
                    command1.Parameters.Add("@login", MySqlDbType.VarChar).Value = invented_login.Text;
                    command1.Parameters.Add("@password", MySqlDbType.VarChar).Value = invented_password.Text;
                    command1.Parameters.Add("@email", MySqlDbType.VarChar).Value = invented_email.Text;

                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан!");





                    }
                    else
                    {
                        MessageBox.Show("Ошибка!Попробуйте позже!");
                    }


                    db.CloseConnection();
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                }
            }
            else
            {
                MessageBox.Show("Некоторые данные не введены!");
            }
        }
    }
}
