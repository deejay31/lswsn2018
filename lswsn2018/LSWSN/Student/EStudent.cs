using DTO.Student;
using Manager.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class EStudent : Form
    {
        dbaStudent dbastudent = new dbaStudent();
        public int id = 0;
        public string selectname = String.Empty;

        public EStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveStudent()
        {
            try
            {
                StudentDTO data = new StudentDTO();
                data.id = id;
                data.studentId = studentId.Text.Trim();
                data.name = name.Text.Trim();
                data.levelSection = levelSection.Text.Trim();
                data.gender = radioButton1.Checked ? "Male" : "Female";
                data.contactNo = contactNo.Text.Trim();
                data.address = address.Text.Trim();

                bool type = id == 0 ? true : false;
                dbastudent.isExist(type, data.name, selectname);
                if (type)
                    dbastudent.insertStudent(data);
                else
                    dbastudent.updateStudent(data);
                    
                MessageBox.Show("Successfully Saved!", "Message");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if(String.IsNullOrEmpty(BaptismParish.Text.Trim()) || String.IsNullOrEmpty(BaptismAddress.Text.Trim()))
            //{
            //    MessageBox.Show("Baptism is required!", "Message");
            //    return;
            //}
            if (MessageBox.Show("Are you sure you want to Save?", "Save Student",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                saveStudent();
            }
        }        

        private void EStudent_Load(object sender, EventArgs e)
        {
            if(id == 0) radioButton1.Checked = true;
        }
    }
}
