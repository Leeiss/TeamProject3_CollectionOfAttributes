using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class Profile : Form
    {
        private string login;
        private string password;
        private string mail;


        public Profile()
        {
            InitializeComponent();
        }
        public Profile(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            


            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE  login = @login", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            db.OpenConnection();

            DbDataReader reader = command.ExecuteReader();


            List<string> list_password = new List<string>();
            List<string> list_email = new List<string>();

            while (reader.Read())
            {
                list_password.Add(reader[1].ToString());
                list_email.Add(reader[3].ToString());
            }
            db.CloseConnection();
            password = list_password[0];
            mail = list_email[0];

            label_login.Text = "Логин: " + login;
            label1.Text = "Пароль: " + password;
            label2.Text = "Почта: " + mail;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (login == "1" && password == "1")
            {
                Add_new_Furnitures add_New_Furnitures = new Add_new_Furnitures();
                add_New_Furnitures.ShowDialog();

            }else
            {
                MessageBox.Show("Вы не администратор!");
            }
            
            this.Close();
        }
    }
}
