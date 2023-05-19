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


        protected string path;


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
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO furniture (`name` ,`room_type_name`, `category`, `link`,`path` , `color`, `style`) VALUES(@name, @room_type_name, @category, @link, @path, @color, @style)", db.GetConnection());
            command.Parameters.Add("@room_type_name", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = comboBox2.Text;
            command.Parameters.Add("@link", MySqlDbType.VarChar).Value = entered_link.Text;
            command.Parameters.Add("@color", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@style", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = "Добавленный";
            command.Parameters.Add("@path", MySqlDbType.VarChar).Value = path;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Предмет добавлен!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }


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

        private void select_poster_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                path = fileDialog.FileName;
            }
        }
    }
}
