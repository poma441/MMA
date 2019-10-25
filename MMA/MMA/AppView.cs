using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMA
{
    public partial class AppView : Form
    {
        public AppView()
        {
            InitializeComponent();
        }

        private void AppView_Load(object sender, EventArgs e)
        {
            LINQtoSQLdbDataContext context = new LINQtoSQLdbDataContext();

            IEnumerable<UsersTable> users = from user in context.UsersTable
                                            where user.login != ""
                                            select user;
            dataGridView1.DataSource = users;
        }

        private void AddUser_Click(object sender, EventArgs e)
        {

        }


    }
}
