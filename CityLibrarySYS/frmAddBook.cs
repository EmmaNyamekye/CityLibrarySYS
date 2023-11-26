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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            //Validate if all fields are entered
            if (txtISBN.Text.Equals("") || txtTitle.Text.Equals("") || txtAuthor.Text.Equals("") ||
                cboGenre.Text.Equals("") || dtpPublication.Text.Equals("") || txtDescription.Text.Equals("") ||
                cboLibraryID.Text.Equals(""))
            {
                MessageBox.Show("All Fields Must Be Entered!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validate if ISBN is valid

            else if (txtISBN.Text.Length != 10 && txtISBN.Text.Length != 13)
            {
                MessageBox.Show("Invalid ISBN length! ISBN must be between 10 and 13 digits long!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            else if (!txtISBN.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid ISBN format! ISBN must be all digits!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int checksum = 0;

            for (int i = 0; i < txtISBN.Text.Length - 1; i++)
            {
                int digit = int.Parse(txtISBN.Text[i].ToString());

                if (i % 2 == 0)
                {
                    checksum += digit * 10;
                }
                else
                {
                    checksum += digit * 3;
                }
            }

            checksum = 10 - checksum % 10;

            if (int.Parse(txtISBN.Text[txtISBN.Text.Length - 1].ToString()) != checksum)
            {
                MessageBox.Show("Invalid ISBN! Invalid final value!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Validate if Title and Author are valid
            else if  (txtTitle.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid title! Title must not be numeric!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtTitle.Focus();
                return;
            }

            else if (txtAuthor.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid author! Author must not be numeric!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAuthor.Focus();
                return;
            }

            else
            {
                MessageBox.Show("Book has been added to Books File",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtISBN.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                cboGenre.Items.Clear();
                dtpPublication.Value = DateTime.MinValue;
                txtDescription.Clear();
                cboLibraryID.Items.Clear();
            }

        }
    }
}
