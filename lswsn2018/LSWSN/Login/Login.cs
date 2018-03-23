using DTO.Login;
using Manager;
using Manager.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        dbaLogin _dbalogin = new dbaLogin();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlHelper _sqlhelper = new SqlHelper(SqlDbConnect.connString);
                if (_sqlhelper.isConnection)
                {
                    userLogin(txtUsername.Text, txtPassword.Text);
                }
            }
            catch (Exception)
            {
                alert.Error("Please check database connection.", "Connection Failed");
            }            
        }

        public void userLogin(string username, string password)
        {
            LoginDTO _logindto = new LoginDTO();
            _logindto = _dbalogin.userLogin(username, password);
            if(_logindto.id != 0)
            {
                backend.UserAccountId = _logindto.id;
                backend.Username = _logindto.userName;
                backend.UsertypeId = _logindto.userTypeId;
                Menu.Menu frm = new Menu.Menu();
                frm.lblTitle.Text = lblTitle.Text;
                frm.Show();
                this.Hide();
            }else
            {
                alert.Error("The username or password you entered is incorrect!", "Login Error");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void getSystems()
        {
            try
            {
                var result = _dbalogin.getSystem();
                if(result != null)
                {
                    lblTitle.Text = result.title;
                    string symbol = "©";
                    string copyright = "Copyright";
                    string year = result.year;
                    string arr = "All Rights Reserved";
                    string version = result.version;

                    string footer = symbol + " " +
                        copyright + " " +
                        year + " | " +
                        arr + " | " +
                        version;
                    lblFooter.Text = footer;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            getSystems();
        }
    }
}
