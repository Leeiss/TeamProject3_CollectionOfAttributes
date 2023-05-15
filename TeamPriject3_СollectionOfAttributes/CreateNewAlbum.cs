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


        protected string category;
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
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("INSERT INTO album (`userlogin`, `Album_name`, `category`) VALUES(@login, @album_name, @category)", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@album_name", MySqlDbType.VarChar).Value = namealbum_textbox.Text;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = category;

            db.OpenConnection();

            if (namealbum_textbox.Text != "")
            {
                if (category != null)
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
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
            category = "bathroom";
        }

        private void kitchen_label_Click(object sender, EventArgs e)
        {
            category = "kitchen";
        }

        private void livingroom_label_Click(object sender, EventArgs e)
        {
            category = "livingroom";
        }

        private void bedroom_label_Click(object sender, EventArgs e)
        {
            category = "bedroom";
        }

        private void diningroom_label_Click(object sender, EventArgs e)
        {
            category = "diningroom";
        }

        private void laundry_label_Click(object sender, EventArgs e)
        {
            category = "laundry";
        }

        private void cabinet_label_Click(object sender, EventArgs e)
        {
            category = "cabinet";
        }
    }
}
