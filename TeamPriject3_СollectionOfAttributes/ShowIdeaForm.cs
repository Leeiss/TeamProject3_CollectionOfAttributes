using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPriject3_СollectionOfAttributes
{
    public partial class ShowIdeaForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ShowIdeaForm(string url)
        {
            InitializeComponent();
            Url = url;
        }
        private string Url;
        private async void ShowIdeaForm_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Url);
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    picture.Image = Bitmap.FromStream(stream);

                }
            }
        }

    }
}

