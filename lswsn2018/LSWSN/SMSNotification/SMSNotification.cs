using Manager;
using Manager.SMSNotification;
using SendSmsStick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSNotification
{
    public partial class SMSNotification : Form
    {
        dbaSMSNotification dbasmsnotification = new dbaSMSNotification();
        public SMSNotification()
        {
            InitializeComponent();
        }

        private void _init()
        {
            try
            {
                var result = dbasmsnotification.selectBooking();
                var today = DateTime.Today;
                var booking = result.Where(a => a.returnDate.AddDays(-1) <= today && a.returnDate >= today); // 
                if (booking.Any())
                {
                    //myDataGridView.DataSource = result.ToList();                    
                    myDataGridView.DataSource = booking.ToList();
                    btnSend.Enabled = true;
                    //dgProperties();
                }
                else
                {
                    myDataGridView.DataSource = null;
                    btnSend.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void SMSNotification_Load(object sender, EventArgs e)
        {
            _init();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                Device.DeviceConnected();

                string port = Device.Port;
                string description = Device.Description;

                List<SmsDTO> datas = new List<SmsDTO>();
                SmsDTO data = new SmsDTO();

                foreach (DataGridViewRow row in myDataGridView.Rows)
                {
                    data = new SmsDTO();

                    string number = row.Cells[2].Value.ToString();
                    string name = row.Cells[1].Value.ToString();
                    string date = Convert.ToDateTime(row.Cells[3].Value).ToShortDateString();
                    string finalMessage = "Hello " + name + " Please return the book at the library before " + date + " Thank you From: Belison National School.";
                    //string finalMessage = "Hello " + name + " We would like to remind you that the due date of your borrowed is " + date + " Please return at the library, Thank you From: Belison National School.";
                    data.number = number;
                    data.message = finalMessage;

                    datas.Add(data);
                }

                string output = Sms.SendSms(datas);
                MessageBox.Show("SMS Successfully sent!", "Message");
                btnSend.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
