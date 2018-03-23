using DTO.Account;
using DTO.Base;
using Manager;
using Manager.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class EAccount : Form
    {
        Helper _helper = new Helper();
        public int comboBoxId = 0;

        dbaAccount dbaaccount = new dbaAccount();

        public EAccount()
        {
            InitializeComponent();
        }

        public void _init()
        {
            //try
            //{
            //    DataTable dt = dbaAccount.getUserType();                

            //    if (dt.Rows.Count > 0)
            //    {
            //        comboTypes.DisplayMember = "Text";
            //        comboTypes.ValueMember = "Value";
            //        List<ComboboxItem> list = new List<ComboboxItem>();
            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            ComboboxItem item = new ComboboxItem();
            //            item.Text = dt.Rows[i][1].ToString();
            //            item.Value = Convert.ToInt32(dt.Rows[i][0].ToString());
            //            list.Add(item);
            //        }
            //        comboTypes.DataSource = list;
            //        comboTypes.SelectedIndex = 1;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void _reset()
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRetype.Clear();
            comboTypes.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (_helper.isEmpty(this))
            //{
            //    alert.message("You must fill in all of the fields!", "Warning", false);
            //    return;
            //}

            if (!_helper.passwordLength(txtUsername.Text.Length) || !_helper.passwordLength(txtPassword.Text.Length))
            {
                alert.message("Username/Password must be atleast 6 character!", "Warning", false);
                txtUsername.Focus();
                return;
            }

            //if (backend.SelectedId == 0)
                _add();
            //else
            //    _update();
        }

        private void _add()
        {
            //if (!txtPassword.Text.Equals(txtRetype.Text))
            //{
            //    alert.message("Password Not Match!", "Warning", false);
            //    return;
            //}

            //int checkExist = dbaAccount.isExist(txtUsername.Text);
            //if (checkExist == 1)
            //{
            //    alert.message("Username already exist!", "Warning", false);
            //    txtUsername.Focus();
            //    return;
            //}

            UsersDTO users = new UsersDTO();
            users.userName = txtUsername.Text.Trim();
            users.userPass = txtPassword.Text.Trim();
            users.userTypeId = Convert.ToInt32(comboTypes.SelectedValue);
            //users.name = txtFullName.Text.Trim();

            bool result = dbaaccount.insertUser(users);
            alert.insert(result);
            this.Close();
        }

        private void _update()
        {
            //int checkExist = dbaAccount.isExist(txtUsername.Text);
            //if (checkExist > 1)
            //{
            //    alert.message("Username already exist!", "Warning", false);
            //    txtUsername.Focus();
            //    return;
            //}

            //UsersDTO users = new UsersDTO();
            //users.id = backend.SelectedId;
            //users.userName = txtUsername.Text;
            //users.userTypeId = Convert.ToInt32(comboTypes.SelectedValue);
            //users.name = txtFullName.Text;

            //bool result = dbaAccount.updatetUser(users);
            //alert.update(result);
            //this.Hide();
        }

        private void EAccount_Load(object sender, EventArgs e)
        {
            _init();

            //if (backend.SelectedId != 0)
            //comboTypes.SelectedValue = comboBoxId;
            comboTypes.SelectedIndex = 0;
        }

        private void EAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            backend.SelectedId = 0;
            comboBoxId = 0;
            backend.isreset = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _reset();
            this.Hide();
        }
    }
}
