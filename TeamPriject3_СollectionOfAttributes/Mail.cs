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
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Entry_Click(object sender, EventArgs e)
        {
            String codeUser = Code.Text;
            if (codeUser == "1234")
            {
                MainForm mainForm = new MainForm(codeUser);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Плох");
            }
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
