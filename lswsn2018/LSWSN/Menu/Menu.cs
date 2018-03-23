using DTO.Base;
using Student;
using Manager;
using Manager.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSWSN.Book;
using LSWSN.Borrow;
using LSWSN.Return;

namespace Menu
{
    public partial class Menu : Form
    {
        Timer timer = new Timer();
        public Menu()
        {
            InitializeComponent();

            lblDate.Text = DateTime.Now.ToShortDateString();

            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = 1000;              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void accessLevel()
        {
            btnBook.Visible = false;
            btnSmsNotification.Visible = false;
            btnReports.Visible = false;
            btnAccounts.Visible = false;
            btnSettings.Visible = false;
            btnBorrow.Location = new Point(0, 164);
            btnReturn.Location = new Point(0, 216);
            btnAbout.Location = new Point(0, 268);
            btnLogout.Location = new Point(0, 320);
        }

        private void _init()
        {
            try
            {
                UsertypeDTO _usertype = new UsertypeDTO();
                _usertype = dbaMenu.userType(backend.UserAccountId);

                if (_usertype.id > 0)
                    lblLevel.Text = _usertype.userType;

                if (_usertype.id > 1) accessLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblaccount.Text = "Welcome " + backend.Username;

            _init();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Log Off",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                Login.Login frm = new Login.Login();
                frm.Show();
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            Account.Account frm = new Account.Account();
            frm.ShowDialog();
        }     

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About.About frm = new About.About();
            frm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports.Reports frm = new Reports.Reports();
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings.Settings frm = new Settings.Settings();
            frm.ShowDialog();
        }

        private void btnSmsNotification_Click(object sender, EventArgs e)
        {
            SMSNotification.SMSNotification frm = new SMSNotification.SMSNotification();
            frm.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student.Student frm = new Student.Student();
            frm.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Book frm = new Book();
            frm.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Borrow frm = new Borrow();
            frm.accountName.Text = backend.Username;
            frm.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return frm = new Return();
            frm.accountName.Text = backend.Username;
            frm.ShowDialog();
        }
    }
}
