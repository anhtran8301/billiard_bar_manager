using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBida
{
    public partial class AdminBackUpData : Form
    {
        
        public AdminBackUpData()
        {
            InitializeComponent();
        }

        string selectedPath;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-RMPS3KRL\\SQLEXPRESS01;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True");


        //private void btnBrowse_Click(object sender, EventArgs e)
        //{
        //    FolderBrowserDialog fd = new FolderBrowserDialog();


        //    txtPath.Text = fd.SelectedPath;

        //}

       

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "BACKUP DATABASE ["+conn.Database+"] TO  DISK = N'"+txtPath.Text+"\\"+conn.Database+".bak'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Backup successfully done");
                btnBackup.Enabled = false;
            } catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            var t = new Thread((ThreadStart)(() =>
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.Cancel)
                    return;

                selectedPath = fbd.SelectedPath;
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            txtPath.Text = selectedPath;
            btnBackup.Enabled = true;
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup File(*.bak) | *.bak";
            ofd.Title = "Select backup File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = ofd.FileName;
                btnRestore.Enabled = true;
            }
           
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "USE [master]\r\nRESTORE DATABASE ["+conn.Database+"] FROM  DISK = N'"+txtRestore.Text+"' WITH  FILE = 2;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Restore successfully done");
                btnRestore.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminBackUpData_Load(object sender, EventArgs e)
        {
            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
        }
    }
}
