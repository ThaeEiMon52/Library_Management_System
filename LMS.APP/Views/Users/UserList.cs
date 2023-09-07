using LMS.Services.User;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.APP.Views.User
{
    public partial class UserList : UserControl
    {
        int pageSize = 5;
        int currentPage = 1;
        int totalPages;

        DataView dataView;
        DataTable dt;
        UserService userService = new UserService();
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            BindGrid();
            //Add Delete Column in data grid view
            dgvUserList.AllowUserToAddRows = false;
            DataGridViewButtonColumn btndel = new DataGridViewButtonColumn();
            dgvUserList.Columns.Insert(7, btndel);
            btndel.HeaderText = "Operation";
            btndel.Text = "Delete Row";
            btndel.Name = "Delete";
            btndel.Width = 100;
            btndel.UseColumnTextForButtonValue = true;
            dgvUserList.AutoGenerateColumns = false;
            //UserDgv.Columns.Add(btndel);
            if (dgvUserList.Columns.Contains(btndel.Name = "Delete"))
            {

            }
            else
            {
                dgvUserList.Columns.Add(btndel);
            }


            // create a DataView from the DataTable
            dataView = new DataView(dt = userService.GetAll());
            // calculate the total number of pages
            totalPages = (int)Math.Ceiling((double)dataView.Count / pageSize);
            lblPagesCount.Text = string.Format("{0} / {1}", currentPage, totalPages);
            // bind the data to the DataGridView
            BindData();

        }


        //Bind Data for pagination
        private void BindData()
        {
            // calculate the starting index and the ending index of the current page
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = startIndex + pageSize - 1;
            if (endIndex >= dataView.Count)
            {
                endIndex = dataView.Count - 1;
            }

            // create a new DataTable and copy the rows from the DataView to the DataTable
            DataTable pageData = dataView.ToTable().Clone();
            for (int i = startIndex; i <= endIndex; i++)
            {
                pageData.ImportRow(dataView.ToTable().Rows[i]);
            }

            // bind the DataTable to the DataGridView
            dgvUserList.DataSource = pageData;
        }

        private void BindGrid()
        {
            DataTable dt = userService.GetAll();
            dgvUserList.DataSource = dt;
            dgvUserList.RowTemplate.Height = 30;

        }

        //Delete Row in datagridview
        private void dgvDelete_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserList.Columns[e.ColumnIndex].HeaderText == "Operation")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["gcUserID"].Value);
                    UserService userService = new UserService();
                    bool success = userService.Delete(id);
                    if (success)
                    {
                        MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
                    }
                    this.Controls.Clear();
                    UserList userList = new UserList();
                    this.Controls.Add(userList);
                }
            }

        }
        private void dgvUserList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int userID = Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["gcUserID"].Value);
                if (e.ColumnIndex == dgvUserList.Columns["gcUserID"].Index)
                {
                    UCUsers ucUser = new UCUsers();
                    ucUser.ID = userID.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(ucUser);

                }
            }
        }

        //Export excel file
        private void btnExport_Click_1(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            // create a new Excel package
            using (var package = new ExcelPackage())
            {
                // add a new worksheet to the package
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // add data from the DataGridView to the worksheet
                for (int i = 0; i < dgvUserList.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvUserList.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j + 1].Value = dgvUserList.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // format the worksheet
                worksheet.Cells.AutoFitColumns();

                // save the Excel file
                package.SaveAs(new FileInfo(@"C:\Users.xlsx"));
                MessageBox.Show("Export Data Successful");
            }


        }

        //Search in datagridview
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            System.Data.DataTable dt = userService.Search(txtSearch.Text);
            if (dt.Rows.Count > 0)
            {
                dgvUserList.DataSource = dt;
                txtSearch.Text = "";
            }
            else
            {
                MessageBox.Show("data not found");
                txtSearch.Text = "";
            }

        }

        //Buttons for pagination
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // go to the previous page
            if (currentPage > 1)
            {
                currentPage--;
                lblPagesCount.Text = string.Format("{0}/{1}", currentPage, totalPages);
                // Disable the Previous button if the current page is the first page
                btnPrevious.Enabled = (currentPage > 1);
                btnNext.Enabled = true;
                BindData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // go to the next page
            if (currentPage < totalPages)
            {
                currentPage++;
                lblPagesCount.Text = string.Format("{0}/{1}", currentPage, totalPages);
                // Disable the Next button if the current page is the last page
                btnNext.Enabled = (currentPage < totalPages);
                btnPrevious.Enabled = true;
                BindData();
            }
        }
    }
}

    

