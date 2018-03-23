using LSWSN.Reports;
using Manager;
using Manager.Reports;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class Reports : Form
    {
        MySqlConnection con = new MySqlConnection(SqlDbConnect.connString);
        dbaReports dbareports = new dbaReports();

        public Reports()
        {
            InitializeComponent();
        }   

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetReport ds = new DataSetReport();
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT * FROM book WHERE isActive = 1", con);

                con.Open();
                adpt.Fill(ds.book);
                con.Close();

                reportBook rep = new reportBook();
                rep.SetDataSource(ds);

                Print frm = new Print();
                frm.crystalReportViewer1.ReportSource = rep;
                frm.crystalReportViewer1.RefreshReport();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
                con.Close();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetReport ds = new DataSetReport();
                MySqlDataAdapter adpt = new MySqlDataAdapter(@"SELECT * FROM `borrowbook`
                    LEFT JOIN book
                    ON borrowbook.bookId = book.accessionNo
                    WHERE borrowbook.transaction = 'Borrow'; ", con);

                con.Open();
                adpt.Fill(ds.borrowbook);
                adpt.Fill(ds.book);
                con.Close();

                reportBorrow rep = new reportBorrow();
                rep.SetDataSource(ds);

                Print frm = new Print();
                frm.crystalReportViewer1.ReportSource = rep;
                frm.crystalReportViewer1.RefreshReport();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
                con.Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetReport ds = new DataSetReport();
                MySqlDataAdapter adpt = new MySqlDataAdapter(@"SELECT * FROM `borrowbook`
                    LEFT JOIN book
                    ON borrowbook.bookId = book.accessionNo
                    WHERE borrowbook.transaction = 'Return'; ", con);

                con.Open();
                adpt.Fill(ds.borrowbook);
                adpt.Fill(ds.book);
                con.Close();

                reportReturn rep = new reportReturn();
                rep.SetDataSource(ds);

                Print frm = new Print();
                frm.crystalReportViewer1.ReportSource = rep;
                frm.crystalReportViewer1.RefreshReport();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
                con.Close();
            }
        }
    }
}
