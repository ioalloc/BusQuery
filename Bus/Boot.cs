using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus
{
    public partial class Boot : Form
    {
        private UserQueryForm UQF = null;
        private AdminLogin AL = null;
        public Boot()
        {
            InitializeComponent();
        }

        private void Boot_Load(object sender, EventArgs e)
        {

        }

        private void User_Acess(object sender, EventArgs e)
        {

            if (UQF == null)
            {
                UQF = new UserQueryForm();
            }
            UQF.Show();
        }

        private void Admin_Acess(object sender, EventArgs e)
        {
            if (AL == null)
            {
                AL = new AdminLogin();
            }
            AL.Show();
        }
    }
}
