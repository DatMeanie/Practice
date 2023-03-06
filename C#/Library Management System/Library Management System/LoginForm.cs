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

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        AdminForm adminForm;
        bool isAdmin = false;

        private void AdminCheckbox_CheckedChanged( object sender, EventArgs e )
        {
            isAdmin = AdminCheckbox.Checked;
        }

        private void LoginBtn_Click( object sender, EventArgs e )
        {
            if( adminForm == null && isAdmin )
            {
                adminForm = new AdminForm();
                adminForm.Show();
            }
        }

        private void RegisterBtn_Click( object sender, EventArgs e )
        {
            String str;
            SqlConnection myConn = new SqlConnection( "Server=localhost;Integrated security=SSPI;database=master" );

            str = "CREATE DATABASE MyDatabase ON PRIMARY " +
             "(NAME = MyDatabase_Data, " +
             "FILENAME = 'C:\\MyDatabaseData.mdf', " +
             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             "LOG ON (NAME = MyDatabase_Log, " +
             "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
             "SIZE = 1MB, " +
             "MAXSIZE = 5MB, " +
             "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand( str, myConn );
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show( "DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            catch ( System.Exception ex )
            {
                MessageBox.Show( ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }
    }
}
