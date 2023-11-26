using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CityLibrarySYS
{
    public partial class frmAddBook : Form
    {
        frmMainManu parent;

        public frmAddBook()
        {
            InitializeComponent();
        }

        public frmAddBook(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validate if all fields are entered
            if (txtISBN.Text.Equals("") || txtTitle.Text.Equals("") || txtAuthor.Text.Equals("") ||
                cboGenre.Text.Equals("") || txtPublication.Text.Equals("") || txtDescription.Text.Equals("") ||
                cboLibraryID.Text.Equals(""))
            {
                MessageBox.Show("All Fields Must Be Entered!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
