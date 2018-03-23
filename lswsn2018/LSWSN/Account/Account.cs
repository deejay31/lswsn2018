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
    public partial class Account : Form
    {
        Timer timer = new Timer();
                    
        public Account()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Enabled = true;
        }

        private void _init()
        {
            try
            {
                var result = dbaAccount.selectAll().ToList();
                if (result != null)
                {
                    myDataGridView.DataSource = result;
                    dgProperties();
                }
                else
                {
                    myDataGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgProperties()
        {
            myDataGridView.Columns[0].Visible = false;
            myDataGridView.Columns[2].Visible = false;
            myDataGridView.Columns[3].Visible = false;
            myDataGridView.Columns[4].Visible = false;
            myDataGridView.Columns[6].Visible = false;

            myDataGridView.Columns["userName"].HeaderText = "Username";
            myDataGridView.Columns["date_entry"].HeaderText = "Date Entry";
            myDataGridView.Columns["userType"].HeaderText = "Type";

            myDataGridView[1, 0].Selected = true;
            myDataGridView.ClearSelection();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (backend.isreset)
            {
                timer.Stop();
                backend.isreset = false;
                _init();
            }
        }

        private void _reset()
        {
            _init();
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            _init();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EAccount frm = new EAccount();
            timer.Start();
            frm.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _reset();
        }

        private void myDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.myDataGridView.Rows[e.RowIndex];
                //backend.SelectedId = (int)row.Cells["id"].Value;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnNew.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Delete Account",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int _row = myDataGridView.CurrentCell.RowIndex;
                DataGridViewRow row = this.myDataGridView.Rows[_row];
                int userId = (int)row.Cells["id"].Value;
                bool result = dbaAccount.deleteUser(userId);
                alert.delete(result);
                if (result)
                    _reset();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //int _row = myDataGridView.CurrentCell.RowIndex;
            //DataGridViewRow row = this.myDataGridView.Rows[_row];
            //EAccount frm = new EAccount();
            //frm.comboBoxId = (int)row.Cells["userTypeId"].Value;
            //backend.SelectedId = (int)row.Cells["id"].Value;
            //frm.txtUsername.Text = row.Cells["userName"].Value.ToString();
            //frm.txtPassword.Text = row.Cells["userPass"].Value.ToString();
            //frm.txtRetype.Text = row.Cells["userPass"].Value.ToString();
            //frm.comboTypes.Text = row.Cells["userType"].Value.ToString();
            //frm.txtFullName.Text = row.Cells["name"].Value.ToString();
            //frm.txtFullName.SelectionStart = frm.txtFullName.TextLength;
            //frm.txtPassword.Visible = false;
            //frm.txtRetype.Visible = false;
            //frm.lblPassword.Visible = false;
            //frm.lblRetype.Visible = false;

            //frm.comboTypes.Location = new Point(88, 74); 
            //frm.lblType.Location = new Point(7, 78);

            //timer.Start();
            //frm.ShowDialog();
        }
    }
}
