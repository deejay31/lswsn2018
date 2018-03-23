using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public class Helper
    {
        //SqlConnection con = new SqlConnection();
        public bool passwordLength(int stringLength)
        {
            bool isValid = false;
            if (stringLength >= 6)
                isValid = true;
            return isValid;
        }

        public bool _isNullOrEmpty(string inputString)
        {
            bool isValid = false;
            if (string.IsNullOrEmpty(inputString))
                isValid = true;
            return isValid;
        }

        public bool isEmpty(Control control)
        {
            bool result = false;
            foreach (Control gb in control.Controls)
            {
                if (gb is Panel)
                {
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is TextBox)
                        {
                            TextBox textBox = tb as TextBox;
                            if (string.IsNullOrEmpty(textBox.Text))
                            {
                                result = true;
                                return result;
                            }
                        }
                    }
                }
             }
            return result;
        }              

        public bool _checkForEmail(string email)
        {
            bool isValid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
                isValid = true;
            return isValid;
        }

        public int CalculateAge(DateTime birthDay)
        {
            int years = DateTime.Now.Year - birthDay.Year;

            if ((birthDay.Month > DateTime.Now.Month) || (birthDay.Month == DateTime.Now.Month && birthDay.Day > DateTime.Now.Day))
                years--;

            return years;
        }

        //clear Textbox
        public void traverseControlsAndSetTextEmpty(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                traverseControlsAndSetTextEmpty(c);
            }
        }

        //false checkbox
        public void traverseControlsAndSetCheckFalse(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox) ((CheckBox)c).Checked = false;
                traverseControlsAndSetCheckFalse(c);
            }
        }

        //check if checked
        public bool isAllChecked(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control cb in c.Controls)
                    {
                        if (cb is CheckBox)
                        {
                            if(((CheckBox)cb).Checked == false)
                            return false;
                        }
                    }                        
                }
            }
            return true;
        }

        public void _hideColumn(DataGridView dg, int index)
        {
            dg.Columns[index].Visible = false;
        }

        //public bool _isExist(string tblName, string columnName, string whereName, string currentName)
        //{
        //    con.ConnectionString = SqlDbConnect.connString;
        //    bool isValid = false;
        //    if (currentName != whereName)
        //    {
        //        string query = @"SELECT * FROM " + tblName + " WHERE lower(" + columnName + ") = lower('" + whereName + "')";
        //        using (SqlCommand command = new SqlCommand(query, con))
        //        {
        //            con.Open();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                    isValid = true;
        //            }
        //            con.Close();
        //        }
        //    }
        //    return isValid;
        //}

        #region -- Accept Money/Percent --
        //if (!char.IsControl(e.KeyChar)
        //       && !char.IsDigit(e.KeyChar)
        //       && e.KeyChar != '.')
        //    {
        //        e.Handled = true;
        //    }

        //    // only allow one decimal point
        //    if (e.KeyChar == '.'
        //        && (sender as TextBox).Text.IndexOf('.') > -1)
        //    {
        //        e.Handled = true;
        //    }
        #endregion

    }
}
