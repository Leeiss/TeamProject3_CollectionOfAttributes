using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        protected int str = 0;


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
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    pictureBox6.Image = null;
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    pictureBox6.Image = null;

                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    pictureBox6.Image = null;

                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    pictureBox6.Image = null;

                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox5.Image = null;
                    pictureBox6.Image = null;

                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox5.Image = Image.FromFile(listpath[str * 6 + 4]);
                    pictureBox6.Image = null;

                    break;
                default:
                    pictureBox1.Image = Image.FromFile(listpath[str * 6]);
                    pictureBox2.Image = Image.FromFile(listpath[str * 6 + 1]);
                    pictureBox3.Image = Image.FromFile(listpath[str * 6 + 2]);
                    pictureBox4.Image = Image.FromFile(listpath[str * 6 + 3]);
                    pictureBox5.Image = Image.FromFile(listpath[str * 6 + 4]);
                    pictureBox6.Image = Image.FromFile(listpath[str * 6 + 5]);
                    break;
            }
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
    }
}
