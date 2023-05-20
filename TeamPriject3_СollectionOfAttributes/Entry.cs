using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class Entry : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Entry()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            String loginUser = entered_login.Text;
            String passUser = entered_password.Text;

            DataBase db = new DataBase();




            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE  login = @uL AND password = @uP ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;



            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command; // выполняем команду


            DataTable table = new DataTable();

            adapter.Fill(table);// записываем данные в объект класса DataTable

            if (table.Rows.Count > 0)
            {

                MainForm mainForm = new MainForm(loginUser);
                mainForm.ShowDialog();
                this.Close();
                logger.Info("успешно перешли в просмотр альбома!");


            }

            else
            {
                MessageBox.Show("Пользователь с такими данными не найден!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Entry_Load(object sender, EventArgs e)
        {
            entered_password.PasswordChar = '*';
        }
    }
}
