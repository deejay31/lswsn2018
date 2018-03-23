using DTO.Return;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Return
{
    public class dbaReturn
    {
        SqlDbConnect con = new SqlDbConnect();

        public List<ReturnDTO> selectAllById(string studentId)
        {
            List<ReturnDTO> datas = new List<ReturnDTO>();
            ReturnDTO data = new ReturnDTO();

            //string query = @"SELECT student.name, book.isbn, book.title, borrowbook.* FROM `borrowbook`
            //    LEFT JOIN student
            //    ON borrowbook.studentId = student.studentId
            //    LEFT JOIN book 
            //    ON book.accessionNo = borrowbook.bookId 
            //    WHERE borrowbook.studentId = " + Convert.ToInt32(studentId);
            string query = @"SELECT student.name, book.isbn, book.title, borrowbook.* from student
                LEFT JOIN borrowbook
                ON student.studentId = borrowbook.studentId
                LEFT JOIN book
                ON book.accessionNo = borrowbook.bookId
                WHERE borrowbook.studentId = '"+ studentId + "'";
            con.SqlQuery(query);
            con.NonQueryEx();
            foreach (DataRow row in con.QueryEx().Rows)
            {
                data = new ReturnDTO();
                data.name = row["name"].ToString();
                data.isbn = Convert.ToInt32(row["isbn"]);
                data.title = row["title"].ToString();
                data.borrowId = Convert.ToInt32(row["id"]);
                data.studentId = row["studentId"].ToString();
                data.bookId = Convert.ToInt32(row["bookId"]);
                data.borrowDate = Convert.ToDateTime(row["borrowDate"]);
                data.returnDate = Convert.ToDateTime(row["returnDate"]);
                data.accountName = row["accountName"].ToString();
                data.transaction = row["transaction"].ToString();
                data.isActive = Convert.ToInt32(row["isActive"]);
                data.dateEntry = Convert.ToDateTime(row["dateEntry"]);
                data.penalty = Convert.ToDecimal(row["penalty"]);
                datas.Add(data);
            }
            return datas;
        }


        public decimal getPenalty()
        {
            string query = @"SELECT price FROM penalty WHERE isActive = 1;";
            con.SqlQuery(query);
            con.NonQueryEx();
            return Convert.ToDecimal(con.QueryEx().Rows[0]["price"]);
        }

        public void insertReturn(List<ReturnDTO> data)
        {
            foreach (var item in data)
            {
                string query = @"Insert into borrowbook(studentId, bookId, borrowDate, returnDate, accountName, transaction, penalty)
                    values 
                    (@studentId, @bookId, @borrowDate, @returnDate, @accountName, @transaction, @penalty); 
                    UPDATE borrowbook set isActive = 0 WHERE bookId = @bookId; 
                    UPDATE book set status = @status WHERE accessionNo = @bookId";
                con.SqlQuery(query);
                con.Cmd.Parameters.AddWithValue("@studentId", item.studentId);
                con.Cmd.Parameters.AddWithValue("@bookId", item.bookId);
                con.Cmd.Parameters.AddWithValue("@borrowDate", item.borrowDate);
                con.Cmd.Parameters.AddWithValue("@returnDate", item.returnDate);
                con.Cmd.Parameters.AddWithValue("@accountName", item.accountName);
                con.Cmd.Parameters.AddWithValue("@transaction", item.transaction);
                con.Cmd.Parameters.AddWithValue("@penalty", item.penalty);
                con.Cmd.Parameters.AddWithValue("@status", "Available");
                con.NonQueryEx();
            }
        }
    }
}
