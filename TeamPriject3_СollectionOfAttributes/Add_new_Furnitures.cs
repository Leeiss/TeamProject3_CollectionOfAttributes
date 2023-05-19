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
    public partial class Add_new_Furnitures : Form
    {
        public Add_new_Furnitures()
        {
            InitializeComponent();
        }

        private void genres_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewAlbum_lable_Click(object sender, EventArgs e)
        {

        }

        private void Add_new_Furnitures_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO furniture (`room_type_name`, `category`, `link`, `color`, `style`) VALUES(@room_type_name, @category, @link, @admin_rights)", db.GetConnection());
            command.Parameters.Add("@room_type_name", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = invented_password.Text;
            command.Parameters.Add("@link", MySqlDbType.VarChar).Value = invented_email.Text;
            command.Parameters.Add("@admin_rights", MySqlDbType.VarChar).Value = AdminRight;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2.Items.Clear();
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `category` WHERE  room_type_name = @rtname ", db.GetConnection());
            command.Parameters.Add("@rtname", MySqlDbType.VarChar).Value = comboBox1.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            db.OpenConnection();
            DbDataReader reader = command.ExecuteReader();
            List<string> list = new List<string>();
            List<string> list1 = new List<string>();

            while (reader.Read())
            {
                list.Add(reader[2].ToString());
            }
            db.CloseConnection();
            list1 = list.Union(list).ToList();

            for (int i = 0; i< list1.Count; i++)
            {
                comboBox2.Items.Add(list1[i]);
            }


        }
    }
}
