using DTO.Borrow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Borrow
{
    public class dbaBorrow
    {
        SqlDbConnect con = new SqlDbConnect();
        public void insertBorrow(List<BorrowDTO> data)
        {
            foreach(var item in data)
            {
                string query = @"Insert into borrowbook(studentId, bookId, borrowDate, returnDate, accountName)
                    values 
                    (@studentId, @bookId, @borrowDate, @returnDate, @accountName); 
                    UPDATE book set status = @status WHERE accessionNo = @bookId";
                con.SqlQuery(query);
                con.Cmd.Parameters.AddWithValue("@studentId", item.studentId);
                con.Cmd.Parameters.AddWithValue("@bookId", item.bookId);
                con.Cmd.Parameters.AddWithValue("@borrowDate", item.borrowDate);
                con.Cmd.Parameters.AddWithValue("@returnDate", item.returnDate);
                con.Cmd.Parameters.AddWithValue("@accountName", item.accountName);
                con.Cmd.Parameters.AddWithValue("@transaction", item.transaction);
                con.Cmd.Parameters.AddWithValue("@status", "Unavailable");
                con.NonQueryEx();
            }
        }
    }
}
