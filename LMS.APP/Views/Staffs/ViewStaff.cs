
using LMS.DAO.Staff;
using LMS.Entities.Staff;
using LMS.Services.Staff;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LMS.APP.Views.Staff
{
    public partial class ViewStaff : UserControl
    {
    
        StaffService staffService = new StaffService();
        int currentPage = 1;
        int totalPageCount;
        DataView dv;
        DataTable dt;
        int pageSize = 7;
        int staff_id;
        public ViewStaff()
        {
            InitializeComponent();
        }
        private void dgvViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int staff_id = Convert.ToInt32(dgvViewStaff.Rows[e.RowIndex].Cells["gcStaffID"].Value);
                if (e.ColumnIndex == dgvViewStaff.Columns["gcStaffID"].Index)
                {
                    AddStaff addStaff = new AddStaff();
                    addStaff.ID = staff_id.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(addStaff);

                }

            }

        }
        private void BindGrid()
        {

            DataTable dt = staffService.GetAll();
            dgvViewStaff.DataSource = dt;

        }
        private void ViewStaff_Load(object sender, EventArgs e)
        {
            BindGrid();

            dv = new DataView(dt = staffService.GetAll());

            int totalItemCount = dv.Count; 
            totalPageCount = (int)Math.Ceiling((double)totalItemCount / pageSize);

            UpdatePageCountLabel();

        }
        //Pagination 
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                UpdatePageCountLabel();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPageCount)
            {
                currentPage++;
                UpdatePageCountLabel();
            }
        }

        private void UpdatePageCountLabel()
        {
        
            int sIndex = (currentPage - 1) * pageSize;
            int eIndex = sIndex + pageSize - 1;
            if (eIndex >= dv.Count)
            {
                eIndex = dv.Count - 1;
            }

            DataTable Page = dv.ToTable().Clone();
            for (int i = sIndex; i <= eIndex; i++)
            {
               Page.ImportRow(dv.ToTable().Rows[i]);
            }
            lblPageNumber.Text = currentPage + "/ " + totalPageCount;
        
        dgvViewStaff.DataSource = Page;
        }



        //Export StaffData to Excel
        private void btnViewStaffExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Worksheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "StaffData";

            for (int i = 1; i <= dgvViewStaff.Columns.Count -1; i++)
            {
                worksheet.Cells[i, 1] = dgvViewStaff.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgvViewStaff.Rows.Count -1; i++)
            {
                for (int j = 0; j < dgvViewStaff.Columns.Count -1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvViewStaff.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the file
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "StaffListing01";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Export successful");
            }

            //Exit from the application
            app.Quit();

        }

        //Search data
        private void btnviewStaffSearch_Click(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();

            DataTable dt = staffService.Search(txtViewStaffSearch.Text);
            if (dt.Rows.Count > 0)
            {
                txtViewStaffSearch.Text = "";
                dgvViewStaff.DataSource = dt;
              
            }
            else
            {
                txtViewStaffSearch.Text = "";
                MessageBox.Show("Staff Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString();
                txtViewStaffSearch.Focus(); 
            }

        }

        private void deleteStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewStaff.Columns[e.ColumnIndex].HeaderText == "Operation")
            {
                DialogResult confirm = MessageBox.Show("Are you sure? \n You want to delete this row.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                
                    staff_id = Convert.ToInt32(dgvViewStaff.Rows[e.RowIndex].Cells["gcStaffID"].Value);
                    StaffService staffService = new StaffService();
                    bool success = staffService.Delete(staff_id);
                    if (success)
                    {
                        MessageBox.Show("Successfully Deleted.", "Success", MessageBoxButtons.OK);
                    }
                    this.Controls.Clear();
                    ViewStaff viewStaff = new ViewStaff();
                    this.Controls.Add(viewStaff);
                }
            }


        }
    }
}
