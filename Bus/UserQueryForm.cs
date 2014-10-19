using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus
{
    public partial class UserQueryForm : Form
    {
        const string conStr = @"Data Source = (localdb)\Projects;
                                Initial Catalog = BusQuery;
                                Integrated Security = true";
        SqlConnection  connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlCommandBuilder cmdBuilder;
        DataSet ds;
        DataTable dt;
        public UserQueryForm()
        {
            InitializeComponent();
        }

        private void UserQueryForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conStr);
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from test";
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
            cmdBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = cmdBuilder.GetInsertCommand();
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            adapter.Fill(ds);
            dt = ds.Tables["Table"];
        }

        private void button_Query_s2s_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows.Add(null,textBox_StartStation.Text,
                    textBox_EndStation.Text);
                adapter.Update(ds);
            }
            catch (System.Exception ep)
            {
                Console.WriteLine("Message = {0}", ep.Message);
            }
        }
    }
}
