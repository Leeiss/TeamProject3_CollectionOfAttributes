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
    public partial class CreateNewAlbum : Form
    {


        protected string room_type;
        protected string login;

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








            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO album (`userlogin`, `Album_name`, `room_type`) VALUES(@login, @album_name, @room_type)", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@album_name", MySqlDbType.VarChar).Value = namealbum_textbox.Text;
            command.Parameters.Add("@room_type", MySqlDbType.VarChar).Value = room_type;

            



            

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM album WHERE Album_name = @Id ", db.GetConnection());
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = namealbum_textbox.Text;





            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command2;
            DataTable table2 = new DataTable();
            adapter.Fill(table2);













            if (namealbum_textbox.Text != "")
            {
                if (room_type != null)
                {
                    if (table2.Rows.Count == 0)
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            AddFurniture addFurniture = new AddFurniture(login, namealbum_textbox.Text, room_type);
                            addFurniture.ShowDialog();


                        }
                        else
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Альбом с таким имене уже существует");
                    }

                }
                else
                {
                    MessageBox.Show("Вы не выбрали категорию");
                }

            } else
            {
                MessageBox.Show("Вы не написали название альбома");
            }
            db.CloseConnection();








            this.Close();
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
