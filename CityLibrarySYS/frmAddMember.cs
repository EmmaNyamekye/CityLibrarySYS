using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibrarySYS
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate if all fields are entered
            if (txtForename.Text.Equals("") || txtSurname.Text.Equals("") || txtDateBirth.Text.Equals("") ||
                txtStreet.Text.Equals("") || txtTown.Text.Equals("") || txtCounty.Text.Equals("") ||
                txtEircode.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validate length of fields
            if (txtForename.Text.Length > 20)
            {
                MessageBox.Show("The length of the Forename cannot be longer than 20 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            else if (txtSurname.Text.Length > 20)
            {
                MessageBox.Show("The length of the Surname cannot be longer than 20 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            else if (txtDateBirth.Text.Length != 10 || !DateTime.TryParseExact(txtDateBirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Date of Birth format must be dd/mm/yyyy!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtDateBirth.Focus();
                return;
            }
            else if (txtStreet.Text.Length > 10)
            {
                MessageBox.Show("The length of the Street cannot be longer than 10 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            else if (txtTown.Text.Length > 10)
            {
                MessageBox.Show("The length of the Town cannot be longer than 10 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }
            else if (txtCounty.Text.Length > 10)
            {
                MessageBox.Show("The length of the County cannot be longer than 10 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }

            // Validate if fields are not numeric
            if (txtForename.Text.All(char.IsDigit))
            {
                MessageBox.Show("Forename cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            else if (txtSurname.Text.All(char.IsDigit))
            {
                MessageBox.Show("Surname cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            else if (txtStreet.Text.All(char.IsDigit))
            {
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            else if (txtTown.Text.All(char.IsDigit))
            {
                MessageBox.Show("Town cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }
            else if (txtCounty.Text.All(char.IsDigit))
            {
                MessageBox.Show("County cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }

            // Validate Eircode
            string eircode = txtEircode.Text;
            string eircodePattern = @"^([ACDEFHKNPRTVWXY][0-9]{2}|D6W)[ ][ACDEFHKNPRTVWXY0-9]{4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(eircode, eircodePattern))
            {
                MessageBox.Show("Invalid Eircode format!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            // Validate Phone and Email
            if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit) || !txtPhone.Text.StartsWith("06"))
            {
                MessageBox.Show("Phone number is invalid!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
        }
    }
}
