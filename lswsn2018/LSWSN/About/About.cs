using Manager.About;
using Manager.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace About
{
    public partial class About : Form
    {
        dbaAbout about = new dbaAbout();
        dbaLogin dbalogin = new dbaLogin();
        public About()
        {
            InitializeComponent();
        }

        private void getAbout()
        {
            try
            {
                var result = about.getAbout().ToList();
                if (result != null)
                {
                    string strResult = "";
                    foreach (var row in result)
                        strResult += row.name + System.Environment.NewLine;
                    lblNames.Text = strResult;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSystems()
        {
            try
            {
                var result = dbalogin.getSystem();
                if (result != null)
                {
                    lblTitle.Text = result.title;
                    lblSubTitle.Text = result.subtitle;
                    lblVersion.Text = result.code + " " + result.version;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            getAbout();
            getSystems();
        }
    }
}
