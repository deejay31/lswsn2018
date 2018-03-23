using DTO.SMSNotification;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.SMSNotification
{
    public class dbaSMSNotification
    {
        SqlDbConnect con = new SqlDbConnect();
        public List<SMSNotificationDTO> selectBooking()
        {
            SMSNotificationDTO data = new SMSNotificationDTO();
            List<SMSNotificationDTO> datas = new List<SMSNotificationDTO>();

            string query = @"SELECT student.id AS 'Id Number', student.name AS 'Student Name', student.contactNo AS 'Contact No.', borrowbook.returnDate AS 'Due Date' FROM `student`
                INNER JOIN borrowbook
                ON borrowbook.studentId = student.studentId
                WHERE borrowbook.transaction = 'Borrow' AND borrowbook.isActive = 1;";

            con.SqlQuery(query);
            con.NonQueryEx();

            foreach (DataRow row in con.QueryEx().Rows)
            {
                data = new SMSNotificationDTO();

                data.id = Convert.ToInt32(row[0]);
                data.name = row[1].ToString();
                data.ContactNo = row[2].ToString();
                data.returnDate = Convert.ToDateTime(row[3]);
                datas.Add(data);
            }
            return datas;
        }
    }
}
