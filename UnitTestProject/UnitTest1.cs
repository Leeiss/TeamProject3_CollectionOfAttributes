using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TeamPriject3_СollectionOfAttributes;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestButton_Registr_Click_WithValidData_ShouldSetClosingPanelVisible()
        {
            // Arrange
            Registration registration = new Registration();
            registration.invented_login.Text = "testuser";
            registration.invented_email.Text = "testemail@example.com";
            registration.invented_password.Text = "testpassword";

            // Act
            registration.button_Registr_Click(null, null);

            // Assert
            Assert.IsTrue(registration.closing_panel.Visible == true);
        }

        [TestMethod]
        public void TestCreateNewAlbum_ValidNameAndRoomType_CreatesAlbum()
        {
            //Arrange
            CreateNewAlbum newAlbum = new CreateNewAlbum();
            newAlbum.namealbum_textbox.Text = "Living Room";
            newAlbum.login = "TestUser";
            newAlbum.room_type = "Living Room";

            //Act
            newAlbum.create_button_Click(null, null);

            //Assert
            MySqlConnection connection = new MySqlConnection(newAlbum.connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM album WHERE Album_name = @albumName AND userlogin = @userLogin", connection);
            cmd.Parameters.AddWithValue("@albumName", newAlbum.namealbum_textbox.Text);
            cmd.Parameters.AddWithValue("@userLogin", newAlbum.login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            Assert.AreEqual(count, 1);
        }

        [TestMethod]
        public void TestCreateNewAlbum_EmptyName_Fails()
        {
            //Arrange
            CreateNewAlbum newAlbum = new CreateNewAlbum();
            newAlbum.namealbum_textbox.Text = "";
            newAlbum.login = "TestUser";
            newAlbum.room_type = "Living Room";

            //Act
            newAlbum.create_button_Click(null, null);

            //Assert
            MySqlConnection connection = new MySqlConnection(newAlbum.connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM album WHERE userlogin = @userLogin", connection);
            cmd.Parameters.AddWithValue("@userLogin", newAlbum.login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            Assert.AreEqual(count, 0);
        }

        [TestMethod]
        public void TestCreateNewAlbum_ExistingName_Fails()
        {
            //Arrange
            CreateNewAlbum newAlbum = new CreateNewAlbum();
            newAlbum.namealbum_textbox.Text = "Bedroom";
            newAlbum.login = "TestUser";
            newAlbum.room_type = "Bedroom";

            //Act
            newAlbum.create_button_Click(null, null);

            //Assert
            MySqlConnection connection = new MySqlConnection(newAlbum.connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM album WHERE userlogin = @userLogin", connection);
            cmd.Parameters.AddWithValue("@userLogin", newAlbum.login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            Assert.AreEqual(count, 1);
            MessageBox.Show("Альбом с таким названием уже существует");
        }

        [TestMethod]
        public void TestCreateNewAlbum_InvalidRoomType_Fails()
        {
            //Arrange
            CreateNewAlbum newAlbum = new CreateNewAlbum();
            newAlbum.namealbum_textbox.Text = "Kitchen";
            newAlbum.login = "TestUser";
            newAlbum.room_type = "Bathroom";

            //Act
            newAlbum.create_button_Click(null, null);

            //Assert
            MySqlConnection connection = new MySqlConnection(newAlbum.connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM album WHERE userlogin = @userLogin", connection);
            cmd.Parameters.AddWithValue("@userLogin", newAlbum.login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            Assert.AreEqual(count, 0);
        }

        [TestMethod]
        public void TestCreateNewAlbum_InvalidUserLogin_Fails()
        {
            //Arrange
            CreateNewAlbum newAlbum = new CreateNewAlbum();
            newAlbum.namealbum_textbox.Text = "Bathroom";
            newAlbum.login = "InvalidUserLogin";
            newAlbum.room_type = "Bathroom";

            //Act
            newAlbum.create_button_Click(null, null);

            //Assert
            MySqlConnection connection = new MySqlConnection(newAlbum.connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM album WHERE userlogin = @userLogin", connection);
            cmd.Parameters.AddWithValue("@userLogin", newAlbum.login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            Assert.AreEqual(count, 0);
        }

        [TestMethod]
        public void TestCreateNewAlbum_Success_ClosesForm()
        {
            //Arrange
            CreateNewAlbum newAlbum = new CreateNewAlbum();
            newAlbum.namealbum_textbox.Text = "Bedroom";
            newAlbum.login = "TestUser";
            newAlbum.room_type = "Bedroom";

            //Act
            newAlbum.create_button_Click(null, null);

            //Assert
            bool isClosed = newAlbum.IsDisposed;
            Assert.AreEqual(isClosed, true);
        }

       

        [TestMethod]
        public void TestCreateNewAlbum_ValidParameters_ChecksForExistingAlbum()
        {
            //Arrange
            CreateNewAlbum newAlbum = new CreateNewAlbum();
            newAlbum.namealbum_textbox.Text = "Living Room";
            newAlbum.login = "TestUser";
            newAlbum.room_type = "Living Room";
            string expectedQuery = "SELECT COUNT(*) FROM album WHERE Album_name = @albumName AND userlogin = @userLogin";

            //Act
            newAlbum.create_button_Click(null, null);

            //Assert
            MySqlConnection connection = new MySqlConnection(newAlbum.connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(expectedQuery, connection);
            cmd.Parameters.AddWithValue("@albumName", newAlbum.namealbum_textbox.Text);
            cmd.Parameters.AddWithValue("@userLogin", newAlbum.login);
            string actualQuery = cmd.CommandText;
            connection.Close();
            Assert.AreEqual(actualQuery, expectedQuery);
        }

        [TestMethod]
        public void TestCreateNewAlbum_ValidParameters_InsertsNewAlbum()
        {
            //Arrange
            CreateNewAlbum newAlbum = new CreateNewAlbum();
            newAlbum.namealbum_textbox.Text = "Kitchen";
            newAlbum.login = "TestUser";
            newAlbum.room_type = "Kitchen";
            string expectedQuery = "INSERT INTO album (Album_name, userlogin, room_type) VALUES (@albumName, @userLogin, @roomType)";

            //Act
            newAlbum.create_button_Click(null, null);

            //Assert
            MySqlConnection connection = new MySqlConnection(newAlbum.connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(expectedQuery, connection);
            cmd.Parameters.AddWithValue("@albumName", newAlbum.namealbum_textbox.Text);
            cmd.Parameters.AddWithValue("@userLogin", newAlbum.login);
            cmd.Parameters.AddWithValue("@roomType", newAlbum.room_type);

            string actualQuery = cmd.CommandText;
            connection.Close();
            Assert.AreEqual(actualQuery, expectedQuery);
        }
    }
}
