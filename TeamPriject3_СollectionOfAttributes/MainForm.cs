using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class MainForm : Form
    {
        protected string login;
        private const string PexelsApiUrl = "https://api.pexels.com/v1/search?query=interior";
        private const string PexelsApiKey = "3GOrWfrocQkomEscjWMcQl2evbNvUjpesFSoQ51PljIdV3ob0PrKGJ8g";

        private string photoUrl;
        private Random _random;
        private HttpClient _httpClient;
        public MainForm()
        {
            InitializeComponent();
            _random = new Random();
            _httpClient = new HttpClient();

            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + PexelsApiKey);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public MainForm(string name)
        {
            InitializeComponent();
            login = name;
            _random = new Random();
            _httpClient = new HttpClient();

            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + PexelsApiKey);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            label_login.Text = login;
            UpdateAlbums();
            GetPhotoWithAPI();
        }

        private async void GetPhotoWithAPI()
        {
            try
            {
                panelLoading.Visible = true;
                {
                    const string apiKey = "3GOrWfrocQkomEscjWMcQl2evbNvUjpesFSoQ51PljIdV3ob0PrKGJ8g";
                    var pexelsApiUrl = "https://api.pexels.com/v1/search?query=interior&per_page=80&page=1";

                    var request = new HttpRequestMessage(HttpMethod.Get, pexelsApiUrl);
                    request.Headers.Add("Authorization", apiKey);
                    var response = await _httpClient.SendAsync(request);
                    response.EnsureSuccessStatusCode();

                    var json = JObject.Parse(await response.Content.ReadAsStringAsync());

                    var images = json["photos"];

                    var randomIndex = _random.Next(images.Count());
                    var randomImage = images[randomIndex];
                    photoUrl = randomImage["src"]["large"].ToString(); // Сохраняем URL в переменную photoUrl
                    var imageStream = await DownloadImageAsync(photoUrl);
                    var image = Image.FromStream(imageStream);
                    pictureBox3.Image = image;
                }
                panelLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нужно включить vpn: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<Stream> DownloadImageAsync(string imageUrl)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(imageUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStreamAsync();
        }

        private void UpdateAlbums()
        {
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM album WHERE  userlogin = @L", db.GetConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;

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
        private void label3_Click(object sender, EventArgs e)
        {
            CreateNewAlbum createNewAlbum = new CreateNewAlbum(login);
            createNewAlbum.ShowDialog();
            UpdateAlbums();
        }

        private void label_go_forward_Click(object sender, EventArgs e)
        {
            GetPhotoWithAPI();
        }

        private void label_name1_Click(object sender, EventArgs e)
        {
            if (label_name1.Text != "")
            {
                Look_Album look_Album = new Look_Album(label_name1.Text, login);
                look_Album.ShowDialog();
                UpdateAlbums();
            }
            


        }

        private void label_name2_Click(object sender, EventArgs e)
        {
            if (label_name2.Text != "")
            {
                Look_Album look_Album = new Look_Album(label_name2.Text, login);
                look_Album.ShowDialog();
                UpdateAlbums();
            }
        }

        private void label_name3_Click(object sender, EventArgs e)
        {
            if (label_name3.Text != "")
            {
                Look_Album look_Album = new Look_Album(label_name3.Text, login);
                look_Album.ShowDialog();
                UpdateAlbums();
            }
        }

        private void label_name4_Click(object sender, EventArgs e)
        {
            if (label_name4.Text != "")
            {
                Look_Album look_Album = new Look_Album(label_name4.Text, login);
                look_Album.ShowDialog();
                UpdateAlbums();
            }
        }

        
        private void ideasBtn_Click(object sender, EventArgs e)
        {
            UserIdeas userIdeas = new UserIdeas(login);
            userIdeas.ShowDialog();
            UpdateAlbums();
        }

        private void label_addalbums_Click(object sender, EventArgs e)
        {
            CreateNewAlbum createNewAlbum = new CreateNewAlbum(login);
            createNewAlbum.ShowDialog();
            UpdateAlbums();
        }

        private void label_show_allAlbums_Click(object sender, EventArgs e)
        {
            All_albums_look album_Look = new All_albums_look(login);
            album_Look.ShowDialog();
            UpdateAlbums();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=collectionofattributes"))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM ideas WHERE login=@login AND picturepath=@picturepath";
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@picturepath", photoUrl);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Вы уже добавляли это фото");
                        return;
                    }

                    command.CommandText = "INSERT INTO ideas (login, picturepath) VALUES (@login, @picturepath)";
                    int numRowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Пример оформления комнаты добавлен в ваши сохраненные");
                }
            }
        }

        private void label_showprofile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(login);
            profile.ShowDialog();
            UpdateAlbums();
        }

        private void label_box1_Click(object sender, EventArgs e)
        {

        }

        private void label_box3_Click(object sender, EventArgs e)
        {

        }
    }
}
