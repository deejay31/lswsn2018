using DTO.Return;
using Manager;
using Manager.Book;
using Manager.Return;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSWSN.Return
{
    public partial class Return : Form
    {
        #region Initialize
        Helper _helper = new Helper();
        dbaReturn dbareturn = new dbaReturn();
        dbaBook dbabook = new dbaBook();
        #endregion

        public Return()
        {
            InitializeComponent();
        }

        private void _reset()
        {
            _helper.traverseControlsAndSetTextEmpty(this);
            myDataGridView.Rows.Clear();
            myDataGridView.Refresh();
            borrowDate.Value = DateTime.Now;
            returnDate.Value = DateTime.Now;
            studentId.Enabled = true;
            studentId.Focus();
            accountName.Text = backend.Username;
        }

        private void filterStudent(string data)
        {
            try
            {
                var result = dbareturn.selectAllById(data).ToList();
                var filter = result.Where(f => f.isActive == 1).ToList();
                if (filter.Count > 0)
                {
                    decimal penalty = dbareturn.getPenalty();
                    studentId.Enabled = false;
                    name.Text = filter.FirstOrDefault().name;                   
                    foreach (var item in filter)
                    {
                        TimeSpan difference =  DateTime.Today.Date - item.returnDate.Date;
                        //double count = difference.TotalDays;
                        decimal penaltyFees = penalty * (decimal)difference.TotalDays;
                        decimal penaltyDisplay = penaltyFees < 1 ? 0.00m : penaltyFees;
                        myDataGridView.Rows.Add(
                            item.borrowId,
                            item.bookId,
                            item.isbn,
                            item.title,
                            item.borrowDate.ToShortDateString(),
                            item.returnDate.ToShortDateString(),
                            item.accountName,
                            penaltyDisplay
                            );
                    }

                    //compute total penalty.
                    computePenalty();

                    myDataGridView[1, 0].Selected = true;
                    myDataGridView.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Student Id found in borrow books!", "Message");
                    studentId.Clear();
                    studentId.Focus();
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

        private void myDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.myDataGridView.Rows[e.RowIndex];
                int selectedItem = (int)row.Cells["gridAccessionNo"].Value;

                var result = dbabook.selectAll().Where(c => c.accessionNo != 0 &&
                    c.accessionNo == selectedItem).ToList();
                var borrowResult = dbareturn.selectAllById(studentId.Text.Trim()).Where(
                    b => b.bookId == selectedItem).ToList();

                if (result.Count > 0)
                {
                    var item = result.FirstOrDefault();
                    accessionNo.Text = item.accessionNo.ToString();
                    isbn.Text = item.isbn.ToString();
                    category.Text = item.category;
                    title.Text = item.title;
                    author.Text = item.author;
                    edition.Text = item.edition;

                    var itemResult = borrowResult.FirstOrDefault();
                    borrowDate.Value = itemResult.borrowDate;
                    returnDate.Value = itemResult.returnDate;
                    //accountName.Text = itemResult.accountName;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            decimal penalty = dbareturn.getPenalty();
            lblPenalty.Text = "Overdue book has a penalty of " + penalty.ToString() + " Pesos per day";
            _reset();
        }

        private void computePenalty()
        {
            //compute total penalty.
            decimal total = myDataGridView.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["penalty"].Value));
            penaltyFee.Text = total > 0 ? total.ToString() : "0.00";
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
                    if(myDataGridView.Rows.Count == 0) _reset();
                    computePenalty();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void saveReturn()
        {
            try
            {
                ReturnDTO data = new ReturnDTO();
                List<ReturnDTO> datas = new List<ReturnDTO>();

                foreach (DataGridViewRow row in myDataGridView.Rows)
                {
                    data = new ReturnDTO();
                    data.studentId = studentId.Text;
                    data.bookId = Convert.ToInt32(row.Cells[1].Value);
                    data.borrowDate = borrowDate.Value;
                    data.returnDate = returnDate.Value;
                    data.accountName = accountName.Text;
                    data.transaction = "Return";
                    data.penalty = Convert.ToInt32(row.Cells[7].Value);
                    datas.Add(data);
                }
                dbareturn.insertReturn(datas);
                MessageBox.Show("Successfully Saved!", "Message");
                _reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveReturn();
        }
    }
}
