﻿using System;
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
    public partial class frmUpdateMember : Form
    {
        frmMainManu parent;

        public frmUpdateMember()
        {
            InitializeComponent();
        }

        public frmUpdateMember(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void lblMemberId_Click(object sender, EventArgs e)
        {

        }
    }
}
