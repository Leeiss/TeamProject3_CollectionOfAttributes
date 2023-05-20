using NLog;
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
    public partial class Firstin : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Firstin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration userRegist = new Registration();
            userRegist.Show();
            logger.Info("успешно перешли в регистрацию");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Entry userLogin = new Entry();
            userLogin.Show();
            logger.Info("успешно перешли ко входу");

        }












































        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
