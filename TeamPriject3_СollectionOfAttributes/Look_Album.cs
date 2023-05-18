using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class Look_Album : Form
    {
        protected int call_photos;
        protected string album_name;
        protected string login;
        protected string room_type;
        protected int str = 0;
        protected bool delete_mod = false;

        public Look_Album(string Album_name, string Login)
        {
            album_name= Album_name;
            login= Login;



            InitializeComponent();
        }

        private void ShowPhotos()
        {
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `furniture_collection` WHERE  Collection_name = @name", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = album_name;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);
            
            DbDataReader reader = command.ExecuteReader();
            List<string> listId_furnitures = new List<string>();

            List<string> listpath = new List<string>();
            List<string> listlink = new List<string>();



            while (reader.Read())
            {
                listId_furnitures.Add(reader[1].ToString());
            }
            db.CloseConnection();

            command = null;

            for (int i = 0; i < listId_furnitures.Count;i++)
            {

                db.OpenConnection();
                command = new MySqlCommand("SELECT * FROM `furniture` WHERE  FurnitureID = @Id", db.GetConnection());
                command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = listId_furnitures[i];



                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                adapter2.SelectCommand = command;
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
                DbDataReader reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    room_type = reader2[2].ToString();
                    listpath.Add(reader2[5].ToString());

                }

                db.CloseConnection();
            }

            int a = listpath.Count;
            call_photos = a;



            if (str * 6 > a)
            {
                str--;
            }

            int c = a - str * 6;


            switch (c)
            {
                case 0:

                    pictureBox1.Image = null;
                    pictureBox1.Name = null;
                    pictureBox2.Image = null;
                    pictureBox2.Name = null;
                    pictureBox3.Image = null;
                    pictureBox3.Name = null;
                    pictureBox4.Image = null;
                    pictureBox4.Name = null;
                    pictureBox5.Image = null;
                    pictureBox5.Name = null;
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId_furnitures[str * 6];
                    pictureBox2.Image = null;
                    pictureBox2.Name = null;
                    pictureBox3.Image = null;
                    pictureBox3.Name = null;
                    pictureBox4.Image = null;
                    pictureBox4.Name = null;
                    pictureBox5.Image = null;
                    pictureBox5.Name = null;
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;

                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId_furnitures[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId_furnitures[str * 6 + 1];
                    pictureBox3.Image = null;
                    pictureBox3.Name = null;
                    pictureBox4.Image = null;
                    pictureBox4.Name = null;
                    pictureBox5.Image = null;
                    pictureBox5.Name = null;
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;

                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId_furnitures[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId_furnitures[str * 6 + 1];
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox3.Name = listId_furnitures[str * 6 + 2];
                    pictureBox4.Image = null;
                    pictureBox4.Name = null;
                    pictureBox5.Image = null;
                    pictureBox5.Name = null;
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;

                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId_furnitures[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId_furnitures[str * 6 + 1];
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox3.Name = listId_furnitures[str * 6 + 2];
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox4.Name = listId_furnitures[str * 6 +3];
                    pictureBox5.Image = null;
                    pictureBox5.Name = null;
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;

                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId_furnitures[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId_furnitures[str * 6 + 1];
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox3.Name = listId_furnitures[str * 6 + 2];
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox4.Name = listId_furnitures[str * 6 + 3];
                    pictureBox5.Image = Image.FromFile(listpath[str * 6 + 4]);
                    pictureBox5.Name = listId_furnitures[str * 6 + 4];
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;

                    break;
                default:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId_furnitures[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId_furnitures[str * 6 + 1];
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox3.Name = listId_furnitures[str * 6 + 2];
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox4.Name = listId_furnitures[str * 6 + 3];
                    pictureBox5.Image = Image.FromFile(listpath[str * 6 + 4]);
                    pictureBox5.Name = listId_furnitures[str * 6 + 4];
                    pictureBox6.Image = Image.FromFile(listpath[str * 6 + 5]);
                    pictureBox6.Name = listId_furnitures[str * 6 + 5];
                    break;
            }
        }




        private void Delete(string picture_name)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM furniture_collection WHERE  FurnitureID = @id AND Collection_name = @Cn", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = int.Parse(picture_name);
            command.Parameters.Add("@Cn", MySqlDbType.VarChar).Value = album_name;


            command.ExecuteNonQuery();
            MessageBox.Show("Предмет удален");
            db.CloseConnection();
            ShowPhotos();



        }


        private void ShowLink(string picture_name)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `furniture` WHERE  FurnitureID = @uL", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = picture_name;
            db.OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command; // выполняем команду


            DataTable table = new DataTable();

            adapter.Fill(table);// записываем данные в объект класса DataTable


            DbDataReader reader = command.ExecuteReader();

            List<string> listlink = new List<string>();



            while (reader.Read())
            {
                listlink.Add(reader[4].ToString());
            }
            db.CloseConnection();

            Process.Start(listlink[0]);



        }






        public Look_Album()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Look_Album_Load(object sender, EventArgs e)
        {
            label_login.Text = login;
            label_album.Text = album_name;

            ShowPhotos();
        }

        private void label_go_forward_Click(object sender, EventArgs e)
        {
            str++;
            ShowPhotos();
        }

        private void label_go_back_Click(object sender, EventArgs e)
        {
            if (str != 0)
            {
                str -= 1;
                ShowPhotos();
            }
        }

        private void bedroom_label_Click(object sender, EventArgs e)
        {
            AddFurniture addFurniture = new AddFurniture(login, album_name, room_type);
            addFurniture.ShowDialog();
        }












        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Name != "")
            {
                if (delete_mod)
                {
                    Delete(pictureBox1.Name);
                }
                else
                {
                    ShowLink(pictureBox1.Name);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Name != "")
            {
                if (delete_mod)
                {
                    Delete(pictureBox2.Name);
                }
                else
                {
                    ShowLink(pictureBox2.Name);
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Name != "")
            {
                if (delete_mod)
                {
                    Delete(pictureBox3.Name);
                }
                else
                {
                    ShowLink(pictureBox3.Name);
                }

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Name != "")
            {
                if (delete_mod)
                {
                    Delete(pictureBox4.Name);
                }
                else
                {
                    ShowLink(pictureBox4.Name);
                }

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Name != "")
            {
                if (delete_mod)
                {
                    Delete(pictureBox5.Name);
                }
                else
                {
                    ShowLink(pictureBox5.Name);
                }

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Name != "")
            {
                if (delete_mod)
                {
                    Delete(pictureBox6.Name);
                }
                else
                {
                    ShowLink(pictureBox6.Name);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!delete_mod)
            {
                label1.Text = "Прекратить удаление";
                delete_mod= true;
            }
            else
            {
                label1.Text = "- Удалить предметы";
                delete_mod= false;
            }
        }
    }
}
