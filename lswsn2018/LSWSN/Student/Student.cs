using DTO.Student;
using Manager.Student;
using Student;
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
    public partial class Student : Form
    {
        Timer timer = new Timer();
        dbaStudent dbastudent = new dbaStudent();
        public Student()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //if (backend.isreset)
            //{
            //    timer.Stop();
            //    backend.isreset = false;
            //    _init();
            //}
        }

        private void _init()
        {
            try
            {
                var result = dbastudent.selectAll();
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        myDataGridView.Rows.Add(
                            item.id,
                            item.studentId,
                            item.name,
                            item.levelSection,
                            item.gender,
                            item.contactNo,
                            item.address
                            );
                    }
                    myDataGridView[1, 0].Selected = true;
                    myDataGridView.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filter(string data)
        {
            try
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Refresh();
                var result = dbastudent.selectAll();
                var filter = result.Where(c => c.name != null && c.name.ToLower().Contains(data.ToLower()) || 
                c.studentId != null && c.studentId.Contains(data)).ToList();
                if (filter.Count > 0)
                {
                    foreach (var item in filter)
                    {
                        myDataGridView.Rows.Add(
                            item.id,
                            item.studentId,
                            item.name,
                            item.levelSection,
                            item.gender,
                            item.contactNo,
                            item.address
                            );
                    }
                    myDataGridView[1, 0].Selected = true;
                    myDataGridView.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _reset()
        {
            myDataGridView.Rows.Clear();
            myDataGridView.Refresh();
            _init();
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _reset();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new EStudent();
            form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            _reset();
        }

        private void myDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnNew.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int _row = myDataGridView.CurrentCell.RowIndex;
                DataGridViewRow row = this.myDataGridView.Rows[_row];
                EStudent frm = new EStudent();
                frm.id = (int)row.Cells["id"].Value;
                frm.studentId.Text = row.Cells["studentId"].Value.ToString();
                frm.studentId.SelectionStart = frm.studentId.Text.Length;
                frm.name.Text = row.Cells["studentName"].Value.ToString();
                frm.selected = row.Cells["studentId"].Value.ToString();
                frm.levelSection.Text = row.Cells["levelSection"].Value.ToString();
                string gender = row.Cells["gender"].Value.ToString();
                if (gender.Equals("Male")) frm.radioButton1.Checked = true; else frm.radioButton2.Checked = true;
                frm.contactNo.Text = row.Cells["contactNo"].Value.ToString();
                frm.address.Text = row.Cells["address"].Value.ToString();
                frm.Text = "Edit Student";

                this.Hide();
                frm.Closed += (s, args) => this.Close();
                frm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Delete?", "Delete Student",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int _row = myDataGridView.CurrentCell.RowIndex;
                    DataGridViewRow row = this.myDataGridView.Rows[_row];
                    int userId = (int)row.Cells["id"].Value;
                    dbastudent.deleteStudent(userId);
                    MessageBox.Show("Successfully Deleted!", "Message");
                    _reset();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter(txtFilter.Text.Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }
    }
}
