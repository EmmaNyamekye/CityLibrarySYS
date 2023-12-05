using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
                grpMemberInfo.Visible = false;
                lblTitle.Visible = false;
                txtTitle.Visible = false;
                btnSearchMember.Visible = false;
                return;
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        { 
            if (txtTitle.Text.ToLower().Contains("the"))
            {
                dgvResults.Visible = true;
                dgvResults.Rows.Clear();
                dgvResults.Rows.Add("A0002340", "The Book Thief", "Markus Zusak", "National Library");
                dgvResults.Rows.Add("A0015678", "The Fault in Our Stars", "John Green", "County Library");
                dgvResults.Rows.Add("A0017890", "The Inferno", "Dante Alighieri", "Village Library");
                dgvResults.Rows.Add("A0017892", "Oliver Twist or, The Parish Boys Progress", "Charles Dickens", "Village Library");

                chkBook1.Visible = true;
                chkBook2.Visible = true;
                chkBook3.Visible = true;
                chkBook4.Visible = true;
                grpCart.Visible = true;
            }
            else
            {
                dgvResults.Visible = false;
                chkBook1.Visible = false;
                chkBook2.Visible = false;
                chkBook3.Visible = false;
                chkBook4.Visible = false;
                dgvResults.Rows.Clear();
                MessageBox.Show("No Book found with this title!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            txtTitle.Focus();
                            return;
            }
        }

        private void chkBook1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBook1.Checked)
            {
                grpCart.Visible = true;
                dgvCheckOut.Rows.Add("The Book Thief", "Markus Zusak");
            }
            else
            {
                if (dgvCheckOut.Columns.Contains("The Book Thief"))
                {
                    //string text = "The Book Thief";
                    //int position = dgvCheckOut.Rows.IndexOf(text);
                    //dgvCheckOut.Rows.Remove(position);
                }
            }
        }

        private void chkBook2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBook2.Checked)
            {
                grpCart.Visible = true;
                dgvCheckOut.Rows.Add("The Fault in Our Stars", "John Green");
            }
            else
                dgvCheckOut.Rows.RemoveAt(1);
        }

        private void chkBook3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBook3.Checked)
            {
                grpCart.Visible = true;
                dgvCheckOut.Rows.Add("The Inferno", "Dante Alighieri");
            }
            else
                dgvCheckOut.Rows.RemoveAt(2);
        }

        private void chkBook4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBook4.Checked)
            {
                grpCart.Visible = true;
                dgvCheckOut.Rows.Add("The Inferno", "Dante Alighieri");
            }
            else
                dgvCheckOut.Rows.RemoveAt(3);
        }
    }
}
