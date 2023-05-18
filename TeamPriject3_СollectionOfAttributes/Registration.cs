using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class Registration : Form
    {
        private string password;
        private string username;
        private int AdminRight;
       
        public Registration()
        {
            InitializeComponent();
        }

       
        private void button_Registr_Click(object sender, EventArgs e)
        {
           
            if (!invented_login.Text.Equals("") && !invented_email.Text.Equals("") && !invented_password.Text.Equals(""))
            {
                closing_panel.Visible = true;
                string email = invented_email.Text;
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Введите email");
                    return;
                }
                else
                {
                    password = GeneratePassword();
                    SendEmail(email, password);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные");
            }
        }

        /// <summary>
        /// генерируем случайный код
        /// </summary>
        /// <returns></returns>
        public static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

        public void SendEmail(string toEmail, string newPassword)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("list_of_recomendations@mail.ru", "Приложение Подборка атрибутов");
            try
            {
                mail.To.Add(new MailAddress(toEmail));
            }
            catch
            {
                MessageBox.Show("Такого почтового ящика не существует");
            }
            // адрес получателя
            mail.Subject = "Подборка атрибутов: подтверждение почты";
            mail.Body = $"Ваш код для подтверждения почты: {newPassword}. Если аккаунт создаете не вы, то, пожалуйста, игнорируйте это письмо";

            SmtpClient smtp = new SmtpClient("smtp.mail.ru"); // адрес сервера SMTP, на котором наша почта
            smtp.Port = 587; // порт, который использует сервер SMTP, обычно 587 или 465
            smtp.EnableSsl = true; // используем SSL-шифрование для защиты от перехвата данных
            smtp.Credentials = new System.Net.NetworkCredential("list_of_recomendations@mail.ru", "xqNDEUbgA3y3MqTk3xnu"); // логин и пароль от нашей учетной записи
            try
            {
                smtp.Send(mail);
            }
            catch
            {
               closing_panel.Visible = false;
            }
        }

        

        private void Entry_Click(object sender, EventArgs e)
        {
            
                if (!invented_login.Text.Equals("") && !invented_password.Text.Equals("") && !invented_email.Text.Equals(""))
                {
                    username = invented_login.Text;
                    DataBase db = new DataBase();
                    db.OpenConnection();
                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login = @Ul ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                    command1.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = username;

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
                        MySqlCommand command = new MySqlCommand("INSERT INTO users (`login`, `password`, `email`, `admin_rights`) VALUES(@login, @password, @email, @admin_rights)", db.GetConnection());
                        command.Parameters.Add("@login", MySqlDbType.VarChar).Value = username;
                        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = invented_password.Text;
                        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = invented_email.Text;
                        command.Parameters.Add("@admin_rights", MySqlDbType.VarChar).Value = AdminRight;

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Добро пожаловать!");
                            MainForm mainForm = new MainForm();
                            mainForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка");
                        }
                        
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Введенные вами логин или email уже были раннее зарегестрированы");
                    }
                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Введите все данные");
                }
            }
           
        }
    }

