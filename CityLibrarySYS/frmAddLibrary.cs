using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CityLibrarySYS
{
    public partial class frmAddLibrary : Form
    {
        frmMainManu parent;

        public frmAddLibrary()
        {
            InitializeComponent();
        }

        public frmAddLibrary(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
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
                MessageBox.Show("All Fields Must Be Entered!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            
            //Validate if Name, Street, Town, County and Supervisor are Not Numeric
            else if (txtName.Text.All(c => char.IsDigit(c)))
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

            //Define Pattern for Eircode Validation
            string eircodePattern = @"^[AC-Y]{1}[0-9]{1}[0-9W]{1}[ \-]?[0-9AC-Y]{4}$";
            /*
             Title: Validation for Irish Eircode
             Author:
             Site ownwer/sponcer:
             Date:
             Availability: 
             (Accessed 25/11/2023)*/

            if (!System.Text.RegularExpressions.Regex.IsMatch(eircode, eircodePattern))
            {
                MessageBox.Show("Invalid Eircode format!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            //Validate if Phone is numeric and starts with '06'
            else if (txtPhone.Text.All(char.IsDigit) || !txtPhone.Text.StartsWith("06"))
            {
                MessageBox.Show("Phone number is invalid! Phone has to be all digits and start with 06",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            // Validate if email is valid
            string email = txtEmail.Text;

            // Define Pattern for email validation
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            else
            {
                MessageBox.Show("Library Has Been Added To The Libraries File",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtName.Clear();
                txtStreet.Clear();
                txtTown.Clear();
                txtCounty.Clear();
                txtEircode.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtSupervisor.Clear();
            }
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;

        }

        private void frmAddLibrary_Load(object sender, EventArgs e)
        {

        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTown_Click(object sender, EventArgs e)
        {

        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCounty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEircode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSupervisor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
