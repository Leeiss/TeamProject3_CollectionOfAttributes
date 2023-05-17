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
    public partial class Albums : Form

    {
        protected string login;
        protected int album_count;
        public Albums()
        {
            InitializeComponent();
        }
        public Albums(string name)
        {
            InitializeComponent();
            login = name;
        }
        private void Albums_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM album WHERE userlogin = @log", db.GetConnection());
            command1.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;


            db.OpenConnection();
            DbDataReader reader = command1.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[1]);
                data[data.Count - 1][0] = reader[1].ToString();




            }
            reader.Close();
            db.CloseConnection();

            AlbumsTable.Rows.Clear();

            foreach (string[] s in data)
            {
                AlbumsTable.Rows.Add(s);
                album_count++;

            }
            if (data.Count > 0)
            {
                AlbumsTable.Visible = true;
            }
            else
            {
                MessageBox.Show("У вас пока нет альбомов");
            }
            allalbums_label.Text = "Всего альбомов: " + album_count;

        }


        private void AlbumsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlbumBrausing albumBrausing = new AlbumBrausing();
            albumBrausing.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AlbumsTable.RowCount; i++)
            {
                AlbumsTable.Rows[i].Selected = false;
                for (int j = 0; j < AlbumsTable.ColumnCount; j++)
                    if (AlbumsTable.Rows[i].Cells[j].Value != null)
                        if (AlbumsTable.Rows[i].Cells[j].Value.ToString().Contains(Entered_Text.Text))

                        {
                            AlbumsTable.Rows[i].Selected = true;

                            break;
                        }
            }
        }
    }
   
}
