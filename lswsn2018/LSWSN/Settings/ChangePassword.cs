using Manager;
using Manager.Logs;
using Manager.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPHCIS.Settings
{
    public partial class ChangePassword : Form
    {        
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCurrent.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(txtCurrent.Text.Trim()))
            {
                alert.Error("Please fill all fields!", "Message");
                return;
            }

            if (!txtPassword.Text.Trim().Equals(txtRetype.Text.Trim()))
            {
                alert.Error("Password did not match!", "Message");
                return;
            }

            if (!backend.Password.Equals(txtCurrent.Text.Trim()))
            {
                alert.Error("Incorrect current password!", "Message");
                return;
            }

            bool result = dbaSettings.updatePassword(txtPassword.Text.Trim());
            if (result)
            {
                alert.Success("New password successfully updated!", "Message");
                dbaLogs log = new dbaLogs();
                log.insertLogs(backend.UserAccountId, "Change password updated");
                this.Close();
            }

        }
    }
}
