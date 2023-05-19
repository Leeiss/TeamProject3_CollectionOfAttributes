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
    public partial class All_albums_look : Form
    {

        protected string login;
        protected int str = 0;
        protected int call_album;

        public All_albums_look()
        {
            InitializeComponent();
        }


        public All_albums_look(string login)
        {
            this.login = login;
            InitializeComponent();
        }





        private void CreateNewAlbum_lable_Click(object sender, EventArgs e)
        {

        }

        private void album_call_Click(object sender, EventArgs e)
        {

        }

        private void entered_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            CreateNewAlbum createNewAlbum = new CreateNewAlbum(login);
            createNewAlbum.ShowDialog();
        }

        private void Album_look_Load(object sender, EventArgs e)
        {
            ShowNames();
        }





        private void ShowNames()
        {
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM album WHERE  userlogin = @login", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();


            List<string> list = new List<string>();


            while (reader.Read())
            {
                list.Add(reader[1].ToString());
            }
            int a = list.Count;
            call_album = a;
            db.CloseConnection();

            if (str * 6 >= a && a != 0)
            {
                str--;
            }

            int c = a - str * 6;

            album_call.Text = "Всего альбомов: " + call_album.ToString();


            switch (c)
            {
                case 0:

                    button_name1.Text = null;
                    button_name2.Text = null;
                    button_name3.Text = null;
                    button_name4.Text = null;
                    button_name5.Text = null;
                    button_name6.Text = null;
                    break;
                case 1:
                    button_name1.Text = list[str*6];
                    button_name2.Text = null;
                    button_name3.Text = null;
                    button_name4.Text = null;
                    button_name5.Text = null;
                    button_name6.Text = null;

                    break;
                case 2:
                    button_name1.Text = list[str * 6];
                    button_name2.Text = list[str * 6 + 1];
                    button_name3.Text = null;
                    button_name4.Text = null;
                    button_name5.Text = null;
                    button_name6.Text = null;

                    break;
                case 3:
                    button_name1.Text = list[str * 6];
                    button_name2.Text = list[str * 6 + 1];
                    button_name3.Text = list[str * 6 + 2];
                    button_name4.Text = null;
                    button_name5.Text = null;
                    button_name6.Text = null;

                    break;
                case 4:
                    button_name1.Text = list[str * 6];
                    button_name2.Text = list[str * 6 + 1];
                    button_name3.Text = list[str * 6 + 2];
                    button_name4.Text = list[str * 6 + 3];
                    button_name5.Text = null;
                    button_name6.Text = null;

                    break;
                case 5:
                    button_name1.Text = list[str * 6];
                    button_name2.Text = list[str * 6 + 1];
                    button_name3.Text = list[str * 6 + 2];
                    button_name4.Text = list[str * 6 + 3];
                    button_name5.Text = list[str * 6 + 4];
                    button_name6.Text = null;

                    break;
                default:
                    button_name1.Text = list[str * 6];
                    button_name2.Text = list[str * 6 + 1];
                    button_name3.Text = list[str * 6 + 2];
                    button_name4.Text = list[str * 6 + 3];
                    button_name5.Text = list[str * 6 + 4];
                    button_name6.Text = list[str * 6 + 5];
                    break;
            }

            if (entered_login.Text != "")
            {
                if (button_name1.Text.Contains(entered_login.Text))
                {
                    button_name1.BackColor = Color.MediumAquamarine;
                }
                else
                {
                    button_name1.BackColor = Color.WhiteSmoke;
                }



                if (button_name2.Text.Contains(entered_login.Text))
                {
                    button_name2.BackColor = Color.MediumAquamarine;
                }
                else
                {
                    button_name2.BackColor = Color.WhiteSmoke;
                }


                if (button_name3.Text.Contains(entered_login.Text))
                {
                    button_name3.BackColor = Color.MediumAquamarine;
                }
                else
                {
                    button_name3.BackColor = Color.WhiteSmoke;
                }


                if (button_name4.Text.Contains(entered_login.Text))
                {
                    button_name4.BackColor = Color.MediumAquamarine;
                }
                else
                {
                    button_name4.BackColor = Color.WhiteSmoke;
                }



                if (button_name5.Text.Contains(entered_login.Text))
                {
                    button_name5.BackColor = Color.MediumAquamarine;
                }
                else
                {
                    button_name5.BackColor = Color.WhiteSmoke;
                }


                if (button_name6.Text.Contains(entered_login.Text))
                {
                    button_name6.BackColor = Color.MediumAquamarine;
                }
                else
                {
                    button_name6.BackColor = Color.WhiteSmoke;
                }
            } else
            {
                button_name1.BackColor = Color.WhiteSmoke;
                button_name2.BackColor = Color.WhiteSmoke;
                button_name3.BackColor = Color.WhiteSmoke;
                button_name4.BackColor = Color.WhiteSmoke;
                button_name5.BackColor = Color.WhiteSmoke;
                button_name6.BackColor = Color.WhiteSmoke;

            }

        }

        private void label_go_forward_Click(object sender, EventArgs e)
        {
            str += 1;
            ShowNames();
        }

        private void label_go_back_Click(object sender, EventArgs e)
        {
            if (str != 0)
            {
                str -= 1;
                ShowNames();
            }
        }

        private void button_name1_Click(object sender, EventArgs e)
        {
            if (button_name1.Text != "")
            {
                Look_Album look_Album = new Look_Album(button_name1.Text, login);
                look_Album.ShowDialog();
                ShowNames();
            }
        }

        private void button_name2_Click(object sender, EventArgs e)
        {
            if (button_name2.Text != "")
            {
                Look_Album look_Album = new Look_Album(button_name2.Text, login);
                look_Album.ShowDialog();
                ShowNames();
            }
        }

        private void button_name3_Click(object sender, EventArgs e)
        {
            if (button_name3.Text != "")
            {
                Look_Album look_Album = new Look_Album(button_name3.Text, login);
                look_Album.ShowDialog();
                ShowNames();
            }
        }

        private void button_name4_Click(object sender, EventArgs e)
        {
            if (button_name4.Text != "")
            {
                Look_Album look_Album = new Look_Album(button_name4.Text, login);
                look_Album.ShowDialog();
                ShowNames();
            }
        }
        private void button_name5_Click(object sender, EventArgs e)
        {
            if (button_name5.Text != "")
            {
                Look_Album look_Album = new Look_Album(button_name5.Text, login);
                look_Album.ShowDialog();
                ShowNames();
            }
        }

        private void button_name6_Click(object sender, EventArgs e)
        {
            if (button_name6.Text != "")
            {
                Look_Album look_Album = new Look_Album(button_name6.Text, login);
                look_Album.ShowDialog();
                ShowNames();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowNames();
        }



        private void entered_login_MouseClick(object sender, MouseEventArgs e)
        {
            entered_login.Clear();
        }
    }
}
