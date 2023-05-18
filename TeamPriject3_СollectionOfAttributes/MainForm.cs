using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class MainForm : Form
    {
        protected string login;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string name)
        {
            InitializeComponent();
            login = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            label_login.Text = login;

            DataBase db = new DataBase();
            DataTable dataTable = new DataTable(); 

            MySqlCommand command = new MySqlCommand("SELECT * FROM album WHERE  userlogin = @L", db.GetConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand= command;

            adapter.Fill(dataTable);

            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();


            List<string> list = new List<string>();


            while (reader.Read())
            {
                list.Add(reader[1].ToString());
            }
            db.CloseConnection();
            int a = list.Count;

            switch (a)
            {
                case 0:
                    label_name1.Text = "";
                    label_name2.Text = "";
                    label_name3.Text = "";
                    label_name4.Text = "";
                    break;
                case 1:
                    label_name1.Text = list[a - 1];
                    label_name2.Text = "";
                    label_name3.Text = "";
                    label_name4.Text = "";
                    break;
                case 2:
                    label_name1.Text = list[a - 1];
                    label_name2.Text = list[a - 2];
                    label_name3.Text = "";
                    label_name4.Text = "";
                    break;
                case 3:
                    label_name1.Text = list[a - 1];
                    label_name2.Text = list[a - 2];
                    label_name3.Text = list[a - 3];
                    label_name4.Text = "";
                    break;
                default:
                    label_name1.Text = list[a - 1];
                    label_name2.Text = list[a - 2];
                    label_name3.Text = list[a - 3];
                    label_name4.Text = list[a - 4];
                    break;
            }




        }

        private 
        private void label_go_forward_Click(object sender, EventArgs e)
        {

        }

        private void label_showprofile_Click(object sender, EventArgs e)
        {

        }

        private void label_box3_Click(object sender, EventArgs e)
        {

        }

        private void picturebox_profile_Click(object sender, EventArgs e)
        {

        }

        private void label_addalbums_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            CreateNewAlbum createNewAlbum = new CreateNewAlbum(login);
            createNewAlbum.ShowDialog();
        }
    }
}
