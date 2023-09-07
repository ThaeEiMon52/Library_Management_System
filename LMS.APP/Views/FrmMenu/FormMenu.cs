using LMS.APP.Views.Book;
using LMS.APP.Views.Staff;
using LMS.APP.Views.User;
using LMS.Entities.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.APP.Views.FrmMenu
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            // Set the StartPosition property of the form to CenterScreen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UCUsers ucUser = new UCUsers();
            PnUC.Controls.Clear();
            PnUC.Controls.Add(ucUser);
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

     


        private void userMenu_DropDownClick(object sender, ToolStripItemClickedEventArgs e)
        {
            booksToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFBB0C");
            usersToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#F4E402");
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            PnUC.Controls.Clear();
            PnUC.Controls.Add(addStaff);
        }

        private void viewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStaff viewStaff = new ViewStaff();
            PnUC.Controls.Clear();
            PnUC.Controls.Add(viewStaff);

        }
        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UCBook ucbook = new UCBook();
            PnUC.Controls.Clear();
            PnUC.Controls.Add(ucbook);
        }

        private void BookMenu_DropDownClick(object sender, ToolStripItemClickedEventArgs e)
        {
            usersToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFBB0C");
            booksToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#F4E402");
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if(LoginEntity.role == 1) {
                addStaffToolStripMenuItem.Visible = true;
                viewStaffToolStripMenuItem.Visible = true;
            }else
            {
                addStaffToolStripMenuItem.Visible = false;
                viewStaffToolStripMenuItem.Visible = false;
            }
            
        }

        private void rentBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRentBook ucbook = new UCRentBook();
            PnUC.Controls.Clear();
            PnUC.Controls.Add(ucbook);
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCReturnBook ucbook = new UCReturnBook();
            PnUC.Controls.Clear();
            PnUC.Controls.Add(ucbook);
        }

        private void rentalHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRentalHistory ucbook = new UCRentalHistory();
            PnUC.Controls.Clear();
            PnUC.Controls.Add(ucbook);
        }
    }
}

