using DTO.Book;
using Manager;
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
    public partial class EBook : Form
    {
        dbaBook dbabook = new dbaBook();
        public int id = 0;
        public string selectItem = String.Empty;

        public EBook()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getCategory()
        {
            try
            {
                var result = dbabook.getCategory().ToList();
                if (result != null)
                {
                    foreach (var i in result)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = i.description;
                        item.Value = i.id;
                        comboBox1.Items.Add(item);
                    }
                    comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EBook_Load(object sender, EventArgs e)
        {
            getCategory();
        }

        private void saveBook()
        {
            try
            {
                BookDTO data = new BookDTO();
                data.id = id;
                data.accessionNo = Convert.ToInt32(accessionNo.Text.Trim());
                data.isbn = Convert.ToInt32(isbn.Text.Trim());
                data.category = comboBox1.Text;
                data.title = title.Text.Trim();
                data.author = author.Text.Trim();
                data.edition = edition.Text.Trim();

                bool type = id == 0 ? true : false;
                dbabook.isExist(type, data.isbn.ToString(), selectItem);
                if (type)
                    dbabook.insertBook(data);
                else
                    dbabook.updateBook(data);

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
            if (MessageBox.Show("Are you sure you want to Save?", "Save Book",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                saveBook();
            }
        }
    }
}
