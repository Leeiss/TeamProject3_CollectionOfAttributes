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
    public partial class AddFurniture : Form
    {

        protected string login;
        protected string name_album;
        protected string room_type;



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

            switch (dataTable.Rows.Count)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_album_Click(object sender, EventArgs e)
        {

        }

        private void label_name1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {

            }
        }
    }
}
