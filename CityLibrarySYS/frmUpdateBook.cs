using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CityLibrarySYS
{
    public partial class frmUpdateBook : Form
    {
        frmMainManu parent;

        public frmUpdateBook()
        {
            InitializeComponent();
        }

        public frmUpdateBook(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmUpdateBook_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBookId.Text.Length < 8 && (txtBookId.Text != "A0000000" ||
                txtBookId.Text != "A0000001" || txtBookId.Text != "A0000002"
                || txtBookId.Text != "A0000002"))
            {
                MessageBox.Show("Invalid BookId!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtBookId.Focus();
                return;
            }
            else
            {
                // Enable text boxes
                grpUpdate.Visible = true;

                if (txtBookId.Text == "A0000000")
                {
                    txtISBN.Text = "9788129116123";
                    txtTitle.Text = "Animal Farm";
                    txtAuthor.Text = "George Orwell";
                    cboGenre.Text = "Novel";
                    dtpPublication.Text = "17/08/1945";
                    txtDescription.Text = "Animal Farm is a beast fable, in the form of a satirical allegorical novella";
                    cboLibraryId.Text = "01";
                }
                else if (txtBookId.Text == "A0000001")
                {
                    txtISBN.Text = "978-1368051477";
                    txtTitle.Text = "Percy Jackson & the Olympians";
                    txtAuthor.Text = "Rick Riordan";
                    cboGenre.Text = "Finction";
                    dtpPublication.Text = "28/06/2005";
                    txtDescription.Text = "Twelve-year-old Percy Jackson is on the most dangerous quest of his life.";
                    cboLibraryId.Text = "02";
                }
                else if (txtBookId.Text == "A0000002")
                {
                    txtISBN.Text = "9780739420416";
                    txtTitle.Text = "The Surgeon";
                    txtAuthor.Text = "Tess Gerritsen";
                    cboGenre.Text = "Crime";
                    dtpPublication.Text = "01/01/2001";
                    txtDescription.Text = "A killer who targets lone women, who breaks into their apartments and performs terrifying ritualistic acts of torture on them before finishing them off.";
                    cboLibraryId.Text = "02";
                }
                else if (txtBookId.Text == "A0000003")
                {
                    txtISBN.Text = "9780099419785";
                    txtTitle.Text = "To Kill a Mockingbird";
                    txtAuthor.Text = "Harper Lee";
                    cboGenre.Text = "Novel";
                    dtpPublication.Text = "11/07/1960";
                    txtDescription.Text = "Set in small-town Alabama, the novel is a bildungsroman, or coming-of-age story, and chronicles the childhood of Scout and Jem Finch as their father Atticus defends a Black man falsely accused of rape.";
                    cboLibraryId.Text = "03";
                }
            }
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
                cboLibraryId.Text.Equals(""))
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

            // Validate if Title, Author and Description are valid
            else if (txtTitle.Text.All(char.IsDigit))
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

            else if (txtDescription.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid description! Description must not be numeric!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDescription.Focus();
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
                dtpPublication.Text = "";
                txtDescription.Clear();
                cboLibraryId.Items.Clear();
            }
        }
    }
}
