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
    public partial class Profile : Form
    {
        private string login;
        private string password;
        private string mail;



        public Profile()
        {
            InitializeComponent();
        }
        public Profile(string login, string password, string mail)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            this.mail = mail;
        }
    }
}
