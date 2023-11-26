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
    public partial class frmQueryLibrary : Form
    {
        frmMainManu parent;

        public frmQueryLibrary()
        {
            InitializeComponent();
        }

        public frmQueryLibrary(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpLibraryInfo_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void rtbLibraryInfo_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = cboLibraryID.SelectedIndex;

            // Clear grpLibraryInfo controls
            grpLibraryInfo.Controls.Clear();

            switch (selectedIndex)
            {
                case 0:
                    // Display information for City Central Library
                    grpLibraryInfo.Text = "City Central Library";
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Address: Maple Avenue, Galway City" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Phone: 0655512345" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Email: central.library@city.library.ie" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Supervisor: John Smith" });
                    break;
                case 1:
                    // Display information for County Library
                    grpLibraryInfo.Text = "County Library";
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Address: Main Street, Ennis, Clare" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Phone: 0655812345" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Email: county.library@city.library.ie" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Supervisor: Zelda Hyrule" });
                    break;
                case 2:
                    // Display information for Suburb Reading Haven
                    grpLibraryInfo.Text = "Suburb Reading Haven";
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Address: High Street, Limerick" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Phone: 0655912345" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Email: reading.haven@city.library.ie" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Supervisor: Maria Rossi" });
                    break;
                case 3:
                    // Display information for Village Library
                    grpLibraryInfo.Text = "Village Library";
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Address: Church Street, Kilrush, Clare" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Phone: 0655712345" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Email: village.library@city.library.ie" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Supervisor: Max Mustermann" });
                    break;
                case 4:
                    // Display information for Riverbank Library
                    grpLibraryInfo.Text = "Riverbank Library";
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Address: Riverside Avenue, Castleconnell, Limerick" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Phone: 0655591234" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Email: riverbank.library@city.library.ie" });
                    grpLibraryInfo.Controls.Add(new Label() { Text = "Supervisor: Luigi Bros" });
                    break;
                default:
                    grpLibraryInfo.Text = "";
                    grpLibraryInfo.Controls.Clear();
                    break;
            }

            // Update grpLibraryInfo group box
            grpLibraryInfo.Update();
        }
    }
}
