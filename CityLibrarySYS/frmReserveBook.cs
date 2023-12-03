using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CityLibrarySYS
{
    public partial class lblResult1 : Form
    {
        frmMainManu parent;

        public lblResult1()
        {
            InitializeComponent();
        }

        public lblResult1(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "A000000" || txtMemberId.Text == "A000001" ||
                txtMemberId.Text == "A000002" || txtMemberId.Text == "A000003")
            {
                // Enable text boxes
                grpMemberInfo.Visible = true;
                lblTitle.Visible = true;
                txtTitle.Visible = true;
                btnSearchMember.Visible = true;

                if (txtMemberId.Text == "A000000")
                {
                    lblMemberInfo.Text = "Name: Sophia Loren        Phone: 0612345678" +
                        "\n\nAddress:  Galway Street 1, A65F4E2, Galway, Galway City" +
                        "\n\nEmail: not.sophia.loren@gmail.it";
                }
                else if (txtMemberId.Text == "A000001")
                {
                    lblMemberInfo.Text = "Name: Mario Rossi         Phone: 0687654321" +
                        "\n\nAddress: Tenth Street 2, A65F4E1, Limerick, Munster" +
                        "\n\nEmail: mariorossin1@gmail.com";
                }
                else if (txtMemberId.Text == "A000002")
                {
                    lblMemberInfo.Text = "Name: Luigi Bros          Phone: 0611223344" +
                        "\n\nAddress: Bros Street 3, A65F4E3, Shannon, Munster" +
                        "\n\nEmail: luigibros@yahoo.com";
                }
                else if (txtMemberId.Text == "A000003")
                {
                    lblMemberInfo.Text = "Name: Mario Bros          Phone: 0611113333" +
                        "\n\nAdddress: Clare Street 5, A65F4E7, Kilrush, Clare" +
                        "\n\nEmail: mariobros1@gmail.com";
                }

            }
            else
            {
                MessageBox.Show("Invalid MemberId!",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtMemberId.Focus();
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        { 
            if (txtTitle.Text.ToLower().Contains("farm"))
            {
                dgvResults.Visible = true;
                dgvResults.Rows.Clear();
                dgvResults.ReadOnly = true;
                dgvResults.Rows.Add("A0000000", "Animal Farm", "George Orwell", "City Central Library");
                dgvResults.Rows.Add("A0003456", "Farm Life", "Jane Doe", "Town Library");
            }
            else if (txtTitle.Text.ToLower().Contains("the"))
            {
                dgvResults.Visible = true;
                dgvResults.Rows.Clear();
                dgvResults.Rows.Add("A0000101", "The Martian", "Andy Weir", "County Library");
                dgvResults.Rows.Add("A0002100", "The Firm", "John Grisham", "Riverbank Library");
                dgvResults.Rows.Add("A0002340", "The Inferno", "Dante Alighieri", "Village Library");
                dgvResults.Rows.Add("A0015678", "The Great Gatsby", "F. Scott Fitzgerald", "County Library");
                dgvResults.Rows.Add("A0017890", "Alexander the Great", "Robin Lane Fox", "National Library");
            }
            else if (txtTitle.Text.ToLower().Contains("great"))
            {
                dgvResults.Visible = true;
                dgvResults.Rows.Clear();
                dgvResults.Rows.Add("A0012345", "Great Expectations", "Charles Dickens", "City Library");
                dgvResults.Rows.Add("A0015678", "The Great Gatsby", "F. Scott Fitzgerald", "County Library");
                dgvResults.Rows.Add("A0017890", "Alexander the Great", "Robin Lane Fox", "National Library");
            }
            else
            {
                dgvResults.Visible = false;
                dgvResults.Rows.Clear();
                MessageBox.Show("No Book found with this title!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            txtTitle.Focus();
                            return;
            }

            

        }
    }
}
