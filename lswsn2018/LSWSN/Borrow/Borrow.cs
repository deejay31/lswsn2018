using DTO.Borrow;
using FluentDateTime;
using Manager;
using Manager.Book;
using Manager.Borrow;
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

namespace LSWSN.Borrow
{
    public partial class Borrow : Form
    {
        Helper _helper = new Helper();
        dbaStudent dbastudent = new dbaStudent();
        dbaBook dbabook = new dbaBook();
        dbaBorrow dbaborrow = new dbaBorrow();
        public Borrow()
        {
            InitializeComponent();
        }

        private void _reset()
        {
            _helper.traverseControlsAndSetTextEmpty(this);
            myDataGridView.Rows.Clear();
            myDataGridView.Refresh();
            borrowDate.Value = DateTime.Now;
            studentId.Enabled = true;
            accessionNo.Enabled = true;
            studentId.Focus();
            accountName.Text = backend.Username;
            btnAdd.Enabled = false;
            accessionNo.Enabled = false;
        }

        private void borrowDate_ValueChanged(object sender, EventArgs e)
        {
            var dateTime = borrowDate.Value.AddBusinessDays(3);
            returnDate.Value = dateTime;
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            var dateTime = borrowDate.Value.AddBusinessDays(3);
            returnDate.Value = dateTime;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _reset();
        }

        private void filterStudent(string data)
        {
            try
            {
                var result = dbastudent.selectAll();
                var filter = result.Where(c => c.studentId != null && c.studentId.ToLower().Equals(data.ToLower()) 
                //|| c.studentId != null && c.studentId.Contains(data)
                ).ToList();
                if (filter.Count > 0)
                {
                    name.Text = filter.FirstOrDefault().name;
                    studentId.Enabled = false;
                    accessionNo.Enabled = true;
                    accessionNo.Focus();
                }
                else
                {
                    MessageBox.Show("No Student Id Found!", "Message");
                    name.Clear();
                    studentId.Clear();
                    studentId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterBook(string data)
        {
            try
            {
                var result = dbabook.selectAll();
                var filter = result.Where(c => c.accessionNo != 0 && c.accessionNo.ToString().ToLower().Equals(data.ToLower()) 
                //&& c.status.Equals("Available")
                //|| c.isbn.ToString() != null && c.isbn.ToString().Contains(data)
                ).ToList();
                if (filter.Count > 0)
                {
                    var item = filter.FirstOrDefault();
                    if (item.status.Equals("Unavailable"))
                    {
                        MessageBox.Show("Book is unavailable", "Message");
                        return;
                    }
                    isbn.Text = item.isbn.ToString();
                    category.Text = item.category;
                    title.Text = item.title;
                    author.Text = item.author;
                    edition.Text = item.edition;
                    accessionNo.Enabled = false;
                    btnAdd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No Accession Id Found!", "Message");
                    accessionNo.Clear();
                    accessionNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filterStudent(studentId.Text.Trim());
            }
        }

        private void accessionNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filterBook(accessionNo.Text.Trim());
            }
        }

        private void CleanForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Panel && c.Name.Equals("panelBook"))
                {
                    foreach (Control cb in c.Controls)
                    {
                        if (cb is TextBox)
                        {
                            ((TextBox)cb).Text = String.Empty;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numRows = myDataGridView.Rows.Count;
            if(numRows == 3)
            {
                MessageBox.Show("Borrow books is maximum of 3 books only!", "Message");
                return;
            }

            foreach (DataGridViewRow row in myDataGridView.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(accessionNo.Text))
                {
                    MessageBox.Show("Accession no.: " + accessionNo.Text + " already selected", "Message");
                    CleanForm(this);
                    accessionNo.Enabled = true;
                    accessionNo.Focus();
                    return;
                }
            }

            myDataGridView.Rows.Add(
                            null,
                            accessionNo.Text,
                            isbn.Text,
                            title.Text
                            );
            myDataGridView[1, 0].Selected = true;
            myDataGridView.ClearSelection();

            CleanForm(this);
            accessionNo.Enabled = true;
            accessionNo.Focus();
            btnAdd.Enabled = false;
        }

        private void saveBorrow()
        {
            try
            {
                BorrowDTO data = new BorrowDTO();
                List<BorrowDTO> datas = new List<BorrowDTO>();

                foreach (DataGridViewRow row in myDataGridView.Rows)
                {
                    data = new BorrowDTO();
                    data.studentId = studentId.Text;
                    data.bookId = Convert.ToInt32(row.Cells[1].Value);
                    data.borrowDate = borrowDate.Value;
                    data.returnDate = returnDate.Value;
                    data.accountName = accountName.Text;
                    datas.Add(data);                    
                }
                dbaborrow.insertBorrow(datas);
                MessageBox.Show("Successfully Added!", "Message");
                _reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Save?", "Save Book",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                saveBorrow();
            }            
        }

        private void myDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    Int32 selectedRowCount = myDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            myDataGridView.Rows.RemoveAt(myDataGridView.SelectedRows[0].Index);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }            
        }
    }
}
