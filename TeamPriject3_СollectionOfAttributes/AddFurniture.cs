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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class AddFurniture : Form
    {

        protected string login;
        protected string name_album;
        protected string room_type;
        protected string category;

        private int str = 0;
        protected int call_photos = 0;
        

        public AddFurniture()
        {
            InitializeComponent();
        }


        public AddFurniture(string login, string name_album, string room_type)
        {
            InitializeComponent();
            this.login = login;
            this.name_album = name_album;
            this.room_type = room_type;
        }




        private void AddFurniture_Load(object sender, EventArgs e)
        {
            label_login.Text = login;
            label_album.Text = room_type+ " — фото дизайна интерьера";



            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM category WHERE  room_type_name = @TN", db.GetConnection());
            command.Parameters.Add("@TN", MySqlDbType.VarChar).Value = room_type;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();


            List<string> list = new List<string>();


            while (reader.Read())
            {
                list.Add(reader[2].ToString());
            }
            db.CloseConnection();


            switch (list.Count)
            {
                case 0:
                    label_name1.Text = "";
                    label_name2.Text = "";
                    label_name3.Text = "";
                    label_name4.Text = "";
                    label_name5.Text = "";
                    label_name6.Text = "";

                    break;
                case 1:
                    label_name1.Text = list[0];
                    label_name2.Text = "";
                    label_name3.Text = "";
                    label_name4.Text = "";
                    label_name5.Text = "";
                    label_name6.Text = "";
                    break;
                case 2:
                    label_name1.Text = list[0];
                    label_name2.Text = list[1];
                    label_name3.Text = "";
                    label_name4.Text = "";
                    label_name5.Text = "";
                    label_name6.Text = "";
                    break;
                case 3:
                    label_name1.Text = list[0];
                    label_name2.Text = list[1];
                    label_name3.Text = list[2];
                    label_name4.Text = "";
                    label_name5.Text = "";
                    label_name6.Text = "";
                    break;
                case 4:
                    label_name1.Text = list[0];
                    label_name2.Text = list[1];
                    label_name3.Text = list[2];
                    label_name4.Text = list[3];
                    label_name5.Text = "";
                    label_name6.Text = "";
                    break;
                case 5:
                    label_name1.Text = list[0];
                    label_name2.Text = list[1];
                    label_name3.Text = list[2];
                    label_name4.Text = list[3];
                    label_name5.Text = list[4];
                    label_name6.Text = "";
                    break;
                default:
                    label_name1.Text = list[0];
                    label_name2.Text = list[1];
                    label_name3.Text = list[2];
                    label_name4.Text = list[3];
                    label_name5.Text = list[4];
                    label_name6.Text = list[5];
                    break;
            }

        }

        
        private void ShowPhotos()
        {


            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `furniture` WHERE  room_type_name = @rtname AND category = @cat ", db.GetConnection());
            command.Parameters.Add("@rtname", MySqlDbType.VarChar).Value = room_type;
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = category;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();


            List<string> listpath = new List<string>();
            List<string> listId = new List<string>();


            while (reader.Read())
            {
                listpath.Add(reader[5].ToString());
                listId.Add(reader[0].ToString());
            }

            db.CloseConnection();

            int a = listpath.Count;
            call_photos = a;


            
            if (str*6 > a)
            {
                str --;
            }

            int c = a - str * 6;


            int maxstr = a / 6;



           
            switch (c)
            {
                case 0:
                        
                    pictureBox1.Image = null;
                    pictureBox1.Name= null;
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
                    pictureBox1.Image = Image.FromFile(listpath[str*6]);
                    pictureBox1.Name = listId[str * 6];
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
                    pictureBox1.Image = Image.FromFile(listpath[str * 6 ]);
                    pictureBox1.Name = listId[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId[str * 6 + 1];
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
                    pictureBox1.Name = listId[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId[str * 6 + 1];
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox4.Image = null;
                    pictureBox4.Name = null;
                    pictureBox5.Image = null;
                    pictureBox5.Name = null;
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;

                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId[str * 6 + 1];
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox3.Name = listId[str * 6 + 2];
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox4.Name = listId[str * 6 + 3];
                    pictureBox5.Image = null;
                    pictureBox5.Name = null;
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;

                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId[str * 6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId[str * 6 + 1];
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox3.Name = listId[str * 6 + 2];
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox4.Name = listId[str * 6 + 3];
                    pictureBox5.Image = Image.FromFile(listpath[str * 6 + 4]);
                    pictureBox5.Name = listId[str * 6 + 4];
                    pictureBox6.Image = null;
                    pictureBox6.Name = null;

                    break;
                default:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox1.Name = listId[str*6];
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox2.Name = listId[str * 6 + 1];
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox3.Name = listId[str * 6 + 2];
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox4.Name = listId[str * 6 + 3];
                    pictureBox5.Image = Image.FromFile(listpath[str * 6 + 4]);
                    pictureBox5.Name = listId[str * 6 + 4];
                    pictureBox6.Image = Image.FromFile(listpath[str * 6 + 5]);
                    pictureBox6.Name = listId[str * 6 + 5];
                    break;
            }

        }
            
        

        private void addtocollection(string Idfurniture)
        {
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO furniture_collection (`Collection_name`, `FurnitureID`) VALUES(@cId, @fId)", db.GetConnection());
            command.Parameters.Add("@cId", MySqlDbType.VarChar).Value = name_album;
            command.Parameters.Add("@fId", MySqlDbType.VarChar).Value = Idfurniture;


            MySqlCommand command2 = new MySqlCommand("SELECT * FROM furniture_collection WHERE Collection_name = @cId AND FurnitureID = @fId ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
            command2.Parameters.Add("@cId", MySqlDbType.VarChar).Value = name_album;
            command2.Parameters.Add("@fId", MySqlDbType.VarChar).Value = Idfurniture;




            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command2;
            DataTable table2 = new DataTable();
            adapter.Fill(table2);






            if (table2.Rows.Count == 0)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вещь успешно добавлена!");
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
            }else
            {
                MessageBox.Show("Этот предмет уже добавлен");

            }



            db.CloseConnection();
        }



         




        private void label_name1_Click(object sender, EventArgs e)
        {
            if (label_name1.Text != "")
            {
                category = label_name1.Text;
                ShowPhotos();
            }
        }

        private void label_name2_Click(object sender, EventArgs e)
        {
            if (label_name2.Text != "")
            {
                category = label_name2.Text;
                ShowPhotos();
            }
        }

        private void label_name3_Click(object sender, EventArgs e)
        {
            if (label_name3.Text != "")
            {
                category = label_name3.Text;
                ShowPhotos();
            }
        }

        private void label_name4_Click(object sender, EventArgs e)
        {
            if (label_name4.Text != "")
            {
                category = label_name4.Text;
                ShowPhotos();
            }
        }

        private void label_name5_Click(object sender, EventArgs e)
        {
            if (label_name5.Text != "")
            {
                category = label_name5.Text;
                ShowPhotos();
            }
        }

        private void label_name6_Click(object sender, EventArgs e)
        {
            if (label_name6.Text != "")
            {
                category = label_name6.Text;
                ShowPhotos();
            }
        }




















        private void pictureBox_logo_Click(object sender, EventArgs e)
        {

        }
        private void label_album_Click(object sender, EventArgs e)
        {

        }

        private void label_go_forward_Click(object sender, EventArgs e)
        {
            str += 1;
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




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                addtocollection(pictureBox1.Name);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                addtocollection(pictureBox2.Name);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                addtocollection(pictureBox3.Name);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != null)
            {
                addtocollection(pictureBox4.Name);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
            {
                addtocollection(pictureBox5.Name);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != null)
            {
                addtocollection(pictureBox6.Name);

            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
