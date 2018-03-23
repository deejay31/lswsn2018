using Manager.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSWSN.Book
{
    public partial class Book : Form
    {
        dbaBook dbabook = new dbaBook();
        public Book()
        {
            InitializeComponent();
        }

        private void _init()
        {
            try
            {
                var result = dbabook.selectAll();
                if (result.Count > 0)
                {
                    myDataGridView.Rows.Clear();
                    myDataGridView.Refresh();

                    foreach (var item in result)
                    {
                        myDataGridView.Rows.Add(
                            item.id,
                            item.accessionNo,
                            item.isbn,
                            item.category,
                            item.title,
                            item.author,
                            item.edition,
                            item.status
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

                var result = myDataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["title"].Value.ToString() != null && r.Cells["title"].Value.ToString().ToLower().Contains(data.ToLower()) ||
                    r.Cells["isbn"].Value.ToString() != null && r.Cells["isbn"].Value.ToString().ToLower().Contains(data.ToLower())                   
                    ).ToList();

                if (result.Count > 0)
                {
                    myDataGridView.Rows.Clear();
                    myDataGridView.Refresh();

                    foreach (var item in result)
                    {
                        myDataGridView.Rows.Add(
                            item.Cells[0].Value,
                            item.Cells[1].Value,
                            item.Cells[2].Value,
                            item.Cells[3].Value,
                            item.Cells[4].Value,
                            item.Cells[5].Value,
                            item.Cells[6].Value,
                            item.Cells[7].Value
                            );
                    }
                    myDataGridView[1, 0].Selected = true;
                    myDataGridView.ClearSelection();
                }
                if (String.IsNullOrEmpty(data))
                {
                    comboBox1.Items.Insert(0, "-Select Filter-");
                    comboBox1.SelectedIndex = 0;
                    _reset();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterAvailability(string data)
        {
            try
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Refresh();

                var result = dbabook.selectAll();
                var filter = result.Where(c => c.status.ToLower().Equals(data.ToLower()) 
                //|| c.isbn.ToString() != null && c.isbn.ToString().Contains(data)
                    ).ToList();
                if (filter.Count > 0)
                {
                    foreach (var item in filter)
                    {
                        myDataGridView.Rows.Add(
                            item.id,
                            item.accessionNo,
                            item.isbn,
                            item.category,
                            item.title,
                            item.author,
                            item.edition,
                            item.status
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

        private void Book_Load(object sender, EventArgs e)
        {
            _reset();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            filter(txtFilter.Text.Trim());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new EBook();
            form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
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
            catch (Exception ex)
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
                EBook frm = new EBook();
                frm.id = (int)row.Cells["id"].Value;
                frm.accessionNo.Text = row.Cells["accessionNo"].Value.ToString();
                frm.isbn.Text = row.Cells["isbn"].Value.ToString();
                frm.accessionNo.SelectionStart = frm.accessionNo.Text.Length;
                frm.comboBox1.Text = row.Cells["category"].Value.ToString();
                frm.selectItem = row.Cells["isbn"].Value.ToString();
                frm.title.Text = row.Cells["title"].Value.ToString();
                frm.author.Text = row.Cells["author"].Value.ToString();
                frm.edition.Text = row.Cells["edition"].Value.ToString();
                frm.Text = "Edit Book";

                this.Hide();
                frm.Closed += (s, args) => this.Close();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int _row = myDataGridView.CurrentCell.RowIndex;
                DataGridViewRow row = this.myDataGridView.Rows[_row];
                if (row.Cells["status"].Value.Equals("Unavailable"))
                    throw new Exception("Cannot delete borrowed book!");

                if (MessageBox.Show("Are you sure you want to Delete?", "Delete Book",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int id = (int)row.Cells["id"].Value;
                    dbabook.deleteBook(id);
                    MessageBox.Show("Successfully Deleted!", "Message");
                    _reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count > 2)
                comboBox1.Items.RemoveAt(0);
            filterAvailability(comboBox1.Text);
        }
    }
}
