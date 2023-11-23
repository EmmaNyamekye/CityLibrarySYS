using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibrarySYS
{
    public partial class frmAddLibrary : Form
    {
        public frmAddLibrary()
        {
            InitializeComponent();
        }

        private void txtSupervisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validate if all fields are entered
            if (txtName.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") ||
                txtCounty.Text.Equals("") || txtEircode.Text.Equals("") || txtPhone.Text.Equals("") ||
                txtEmail.Text.Equals("") || txtSupervisor.Equals(""))
            {
                MessageBox.Show("All Fiels Must Be Entered!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            //Validate length of fields are valid
            else if (txtName.Text.Length > 20)
            {
                MessageBox.Show("The leght of the Name cannot be longer then 20 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            else if (txtStreet.Text.Length > 20)
            {
                MessageBox.Show("The leght of the Street cannot be longer then 20 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            else if (txtTown.Text.Length > 15)
            {
                MessageBox.Show("The leght of the Twon cannot be longer then 15 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }
            else if (txtCounty.Text.Length > 15)
            {
                MessageBox.Show("The leght of the County cannot be longer then 15 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }
            else if (txtSupervisor.Text.Length > 20)
            {
                MessageBox.Show("The leght of the Supervisor cannot be longer then 20 characters!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSupervisor.Focus();
                return;
            }

            //Validate if Name, Street, Town, County and Supervisor are Not Numeric
            if (txtName.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Name cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            else if (txtStreet.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            else if (txtTown.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }
            else if (txtCounty.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }
            else if (txtSupervisor.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtSupervisor.Focus();
                return;
            }

            //Validate if Eircode is valid
            string eircode = txtEircode.Text;

            //Define the regular expression pattern for Eircode validation
            string eircodePattern = @"^([ACDEFHKNPRTVWXY][0-9]{2}|D6W)[ ][ACDEFHKNPRTVWXY0-9]{4}$";
            // https://stackoverflow.com/questions/33391412/validation-for-irish-eircode

            if (!System.Text.RegularExpressions.Regex.IsMatch(eircode, eircodePattern))
            {
                MessageBox.Show("Invalid Eircode format!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            //Validate if Phone is numeric, lenght 10 and starts with '06'
            if (txtPhone.Text.Length != 10 || txtPhone.Text.All(char.IsDigit) || !txtPhone.Text.StartsWith("06"))
            {
                MessageBox.Show("Phone number is invalid! It has to be all 10 char long and all digits",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            //Email validation

        }
    }
}
