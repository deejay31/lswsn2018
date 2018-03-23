using DTO.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Student
{
    public class dbaStudent
    {
        SqlDbConnect con = new SqlDbConnect();
        public List<StudentDTO> selectAll()
        {
            List<StudentDTO> datas = new List<StudentDTO>();
            StudentDTO data = new StudentDTO();

            string query = "SELECT * FROM `student` WHERE isActive = 1";
            con.SqlQuery(query);
            con.NonQueryEx();
            foreach (DataRow row in con.QueryEx().Rows)
            {
                data = new StudentDTO();
                data.id = Convert.ToInt32(row["id"]);
                data.studentId = row["studentId"].ToString();
                data.name = row["name"].ToString();
                data.levelSection = row["levelSection"].ToString();
                data.gender = row["gender"].ToString();
                data.contactNo = row["contactNo"].ToString();
                data.address = row["address"].ToString();
                data.isActive = Convert.ToInt32(row["isActive"]);
                data.dateEntry = Convert.ToDateTime(row["dateEntry"]);
                datas.Add(data);
            }
            return datas;
        }

        public void insertStudent(StudentDTO data)
        {
            string query = @"Insert into student(studentId, name, levelSection, gender, contactNo, address)
                    values 
                    (@studentId, @name, @levelSection, @gender, @contactNo, @address);";
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@studentId", data.studentId);
            con.Cmd.Parameters.AddWithValue("@name", data.name);
            con.Cmd.Parameters.AddWithValue("@levelSection", data.levelSection);
            con.Cmd.Parameters.AddWithValue("@gender", data.gender);
            con.Cmd.Parameters.AddWithValue("@contactNo", data.contactNo);
            con.Cmd.Parameters.AddWithValue("@address", data.address);
            con.NonQueryEx();
        }

        public void updateStudent(StudentDTO data)
        {
            string query = @"Update student set studentId = @studentId, name = @name, levelSection = @levelSection, gender = @gender, contactNo = @contactNo, address = @address where id = " + data.id;
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@studentId", data.studentId);
            con.Cmd.Parameters.AddWithValue("@name", data.name);
            con.Cmd.Parameters.AddWithValue("@levelSection", data.levelSection);
            con.Cmd.Parameters.AddWithValue("@gender", data.gender);
            con.Cmd.Parameters.AddWithValue("@contactNo", data.contactNo);
            con.Cmd.Parameters.AddWithValue("@address", data.address);
            con.NonQueryEx();
        }

        public void deleteStudent(int id)
        {
            SqlDbConnect con = new SqlDbConnect();
            string query = @"Update student set isActive = @isactive where id = " + id;
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@isActive", 0);
            con.NonQueryEx();
        }

        public void isExist(bool add, string data, string selectedname)
        {
            string query = "SELECT * FROM student WHERE isActive = 1 AND name = '" + data + "' AND name <> @selectedname;";
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@selectedname", selectedname);
            con.NonQueryEx();
            int count = con.QueryEx().Rows.Count;
            if (add && count > 0 || add == false && count > 0)
                throw new Exception("Student name already exist!");
        }
    }
}
