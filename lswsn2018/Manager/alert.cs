using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public class alert
    {
        public static void message(string title, string message, bool result)
        {
            if(result)
                MessageBox.Show(title, message,  MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void insert(bool result)
        {
            if (result)
                MessageBox.Show("Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("The data was not saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void update(bool result)
        {
            if (result)
                MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("The data was not saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void delete(bool result)
        {
            if (result)
                MessageBox.Show("Successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("The data was not deleted!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Success(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
