using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class Registration : Form
    {

        private void SendEmail()
        {
            // Отправляем письмо об успешной регистрации
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("CollectionOFAttribures@mail.ru", "Приложение Список атрибутов"); // адрес отправителя
            try
            {
                mail.To.Add(new MailAddress(invented_email.Text, invented_login.Text));
            }
            catch
            {
                MessageBox.Show("Форма указанной строки не годится для адреса электронной почты");
                Application.Exit();
            }
            // адрес получателя
            mail.Subject = "Добро пожаловать в Список рекомендаций!"; ;
            mail.Body = $"{invented_login.Text}, поздравляем тебя с успешной регистрацией!" + Environment.NewLine + "Мы рады приветствовать вас в нашем приложении. Ваш код подтверждения - 1234";

            SmtpClient smtp = new SmtpClient("smtp.mail.ru"); // адрес сервера SMTP, на котором наша почта
            smtp.Port = 587; // порт, который использует сервер SMTP, обычно 587 или 465
            smtp.EnableSsl = true; // используем SSL-шифрование для защиты от перехвата данных
            smtp.Credentials = new System.Net.NetworkCredential("CollectionOFAttribures@mail.ru", "xqNDEUbgA3y3MqTk3xnu"); // логин и пароль от нашей учетной записи
            try
            {
                smtp.Send(mail);
            }
            catch
            {
                MessageBox.Show("Такого почтового ящика не существует");
                Application.Exit();
            }

        }
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
            if (!invented_login.Text.Equals("") && !invented_password.Text.Equals("") && !invented_email.Text.Equals(""))
            {
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login = @Ul ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command1.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = invented_login.Text;

                MySqlCommand command2 = new MySqlCommand("SELECT * FROM users WHERE email = @UE ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command2.Parameters.Add("@UE", MySqlDbType.VarChar).Value = invented_email.Text;

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command1;
                DataTable table1 = new DataTable();
                adapter.Fill(table1);// записываем данные в объект класса DataTable

                adapter.SelectCommand = command2;
                DataTable table2 = new DataTable();
                adapter.Fill(table2);

                if (table1.Rows.Count == 0 && table2.Rows.Count == 0)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO users (`login`, `password`, `email`) VALUES(@login, @password, @email)", db.GetConnection());
                    command.Parameters.Add("@login", MySqlDbType.VarChar).Value = invented_login.Text;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = invented_password.Text;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = invented_email.Text;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        this.Hide();
                        Mail mail = new Mail();
                        mail.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                    db.CloseConnection();
                    Close();
                }
                else
                {
                    MessageBox.Show("Введенные вами логин или email уже были раннее зарегестрированы");
                }
            }
            else
            {
                MessageBox.Show("Некорректно введен логин, пароль или email");
            }
        }
    }
}
