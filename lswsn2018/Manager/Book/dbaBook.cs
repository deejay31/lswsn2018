using DTO.Book;
using DTO.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Book
{
    public class dbaBook
    {
        SqlDbConnect con = new SqlDbConnect();
        public List<BookDTO> selectAll()
        {
            List<BookDTO> datas = new List<BookDTO>();
            BookDTO data = new BookDTO();

            string query = "SELECT * FROM `book` WHERE isActive = 1";
            con.SqlQuery(query);
            con.NonQueryEx();
            foreach (DataRow row in con.QueryEx().Rows)
            {
                data = new BookDTO();
                data.id = Convert.ToInt32(row["id"]);
                data.accessionNo = Convert.ToInt32(row["accessionNo"]);
                data.isbn = Convert.ToInt32(row["isbn"]);
                data.category = row["category"].ToString();
                data.title = row["title"].ToString();
                data.author = row["author"].ToString();
                data.edition = row["edition"].ToString();
                data.status = row["status"].ToString();
                data.isActive = Convert.ToInt32(row["isActive"]);
                data.dateEntry = Convert.ToDateTime(row["dateEntry"]);
                datas.Add(data);
            }
            return datas;
        }

        public void insertBook(BookDTO data)
        {
            string query = @"Insert into book(accessionNo, isbn, category, title, author, edition)
                    values 
                    (@accessionNo, @isbn, @category, @title, @author, @edition);";
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@accessionNo", data.accessionNo);
            con.Cmd.Parameters.AddWithValue("@isbn", data.isbn);
            con.Cmd.Parameters.AddWithValue("@category", data.category);
            con.Cmd.Parameters.AddWithValue("@title", data.title);
            con.Cmd.Parameters.AddWithValue("@author", data.author);
            con.Cmd.Parameters.AddWithValue("@edition", data.edition);
            con.NonQueryEx();
        }

        public void updateBook(BookDTO data)
        {
            string query = @"Update book set accessionNo = @accessionNo, isbn = @isbn, category = @category, title = @title, author = @author, edition = @edition where id = " + data.id;
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@accessionNo", data.accessionNo);
            con.Cmd.Parameters.AddWithValue("@isbn", data.isbn);
            con.Cmd.Parameters.AddWithValue("@category", data.category);
            con.Cmd.Parameters.AddWithValue("@title", data.title);
            con.Cmd.Parameters.AddWithValue("@author", data.author);
            con.Cmd.Parameters.AddWithValue("@edition", data.edition);
            con.NonQueryEx();
        }

        public void deleteBook(int id)
        {
            SqlDbConnect con = new SqlDbConnect();
            string query = @"Update book set isActive = @isactive where id = " + id;
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@isActive", 0);
            con.NonQueryEx();
        }

        public void isExist(bool add, string data, string selected)
        {
            string query = "SELECT * FROM book WHERE isActive = 1 AND accessionNo = '" + data + "' AND accessionNo <> @selected;";
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@selected", selected);
            con.NonQueryEx();
            int count = con.QueryEx().Rows.Count;
            if (add && count > 0 || add == false && count > 0)
                throw new Exception("Accession No. already exist!");
        }

        public List<CategoryDTO> getCategory()
        {
            List<CategoryDTO> datas = new List<CategoryDTO>();
            CategoryDTO data = new CategoryDTO();

            string query = "SELECT * FROM `bookcategory` WHERE isActive = 1;";
            con.SqlQuery(query);
            con.NonQueryEx();
            foreach (DataRow row in con.QueryEx().Rows)
            {
                data = new CategoryDTO();
                data.id = Convert.ToInt32(row["id"]);
                data.classes = row["classes"].ToString();
                data.description = row["description"].ToString();
                data.dateEntry = Convert.ToDateTime(row["dateEntry"]);
                data.isActive = Convert.ToInt32(row["isActive"]);

                datas.Add(data);
            }
            return datas;
        }
    }
}
