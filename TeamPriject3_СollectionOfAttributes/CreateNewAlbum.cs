using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class CreateNewAlbum : Form
    {


        protected string room_type;
        protected string login;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=collectionofattributes";

        public CreateNewAlbum()
        {
            InitializeComponent();
        }


        public CreateNewAlbum(string login)
        {
            InitializeComponent();
            this.login= login;
        }



        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateNewAlbum_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM album WHERE Album_name = @albumName AND userlogin = @userLogin", connection);
            cmd.Parameters.AddWithValue("@albumName", namealbum_textbox.Text);
            cmd.Parameters.AddWithValue("@userLogin", login);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Альбом с таким названием уже существует");
                this.Close();
            }
            else
            {
                cmd = new MySqlCommand("INSERT INTO album (Album_name, userlogin, room_type) VALUES (@albumName, @userLogin, @roomType)", connection);
                cmd.Parameters.AddWithValue("@albumName", namealbum_textbox.Text);
                cmd.Parameters.AddWithValue("@userLogin", login);
                cmd.Parameters.AddWithValue("@roomType", room_type);

                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Альбом успешно создан");
                this.Close();
            }    
            

        }

        private void bathroom_label_Click(object sender, EventArgs e)
        {
            room_type = "Ванная";
        }

        private void kitchen_label_Click(object sender, EventArgs e)
        {
            room_type = "Кухня";
        }

        private void livingroom_label_Click(object sender, EventArgs e)
        {
            room_type = "Гостинная";
        }

        private void bedroom_label_Click(object sender, EventArgs e)
        {
            room_type = "Спальня";
        }

        private void diningroom_label_Click(object sender, EventArgs e)
        {
            room_type = "Столовая";
        }

        private void laundry_label_Click(object sender, EventArgs e)
        {
            room_type = "Прачечная";
        }

        private void cabinet_label_Click(object sender, EventArgs e)
        {
            room_type = "Кабинет";
        }
    }
}
