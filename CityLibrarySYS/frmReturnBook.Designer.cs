namespace CityLibrarySYS
{
    partial class frmReturnBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnBook));
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMemberID = new System.Windows.Forms.Button();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblReturnBook = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.grpBookCart = new System.Windows.Forms.GroupBox();
            this.lblBookCart = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.chkBook4 = new System.Windows.Forms.CheckBox();
            this.chkBook3 = new System.Windows.Forms.CheckBox();
            this.chkBook2 = new System.Windows.Forms.CheckBox();
            this.chkBook1 = new System.Windows.Forms.CheckBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuBackStrip.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
            this.grpBookCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuBackStrip.Size = new System.Drawing.Size(1179, 34);
            this.mnuBackStrip.TabIndex = 77;
            this.mnuBackStrip.Text = "Back";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(104)))));
            this.mnuBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(71, 24);
            this.mnuBack.Text = "BACK";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // btnMemberID
            // 
            this.btnMemberID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnMemberID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberID.Location = new System.Drawing.Point(379, 156);
            this.btnMemberID.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnMemberID.Name = "btnMemberID";
            this.btnMemberID.Size = new System.Drawing.Size(133, 37);
            this.btnMemberID.TabIndex = 144;
            this.btnMemberID.Text = "SEARCH";
            this.btnMemberID.UseVisualStyleBackColor = false;
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblMemberInfo);
            this.grpMemberInfo.Location = new System.Drawing.Point(586, 72);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMemberInfo.Size = new System.Drawing.Size(533, 123);
            this.grpMemberInfo.TabIndex = 143;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Info";
            this.grpMemberInfo.Visible = false;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberInfo.Location = new System.Drawing.Point(20, 25);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(17, 17);
            this.lblMemberInfo.TabIndex = 102;
            this.lblMemberInfo.Text = "0";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(193, 163);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberId.MaxLength = 7;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(151, 27);
            this.txtMemberId.TabIndex = 140;
            // 
            // lblReturnBook
            // 
            this.lblReturnBook.AutoSize = true;
            this.lblReturnBook.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBook.Location = new System.Drawing.Point(59, 79);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(230, 41);
            this.lblReturnBook.TabIndex = 142;
            this.lblReturnBook.Text = "Return Book";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(66, 169);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(105, 20);
            this.lblMemberId.TabIndex = 141;
            this.lblMemberId.Text = "Member ID";
            // 
            // grpBookCart
            // 
            this.grpBookCart.Controls.Add(this.lblBookCart);
            this.grpBookCart.Controls.Add(this.btnConfirm);
            this.grpBookCart.Location = new System.Drawing.Point(611, 428);
            this.grpBookCart.Name = "grpBookCart";
            this.grpBookCart.Size = new System.Drawing.Size(507, 185);
            this.grpBookCart.TabIndex = 150;
            this.grpBookCart.TabStop = false;
            this.grpBookCart.Text = "Book Cart";
            this.grpBookCart.Visible = false;
            // 
            // lblBookCart
            // 
            this.lblBookCart.AutoSize = true;
            this.lblBookCart.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCart.Location = new System.Drawing.Point(20, 25);
            this.lblBookCart.Name = "lblBookCart";
            this.lblBookCart.Size = new System.Drawing.Size(15, 20);
            this.lblBookCart.TabIndex = 123;
            this.lblBookCart.Text = " ";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnConfirm.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(358, 133);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 37);
            this.btnConfirm.TabIndex = 122;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // chkBook4
            // 
            this.chkBook4.AutoSize = true;
            this.chkBook4.Location = new System.Drawing.Point(1097, 348);
            this.chkBook4.Margin = new System.Windows.Forms.Padding(4);
            this.chkBook4.Name = "chkBook4";
            this.chkBook4.Size = new System.Drawing.Size(18, 17);
            this.chkBook4.TabIndex = 149;
            this.chkBook4.UseVisualStyleBackColor = true;
            this.chkBook4.Visible = false;
            // 
            // chkBook3
            // 
            this.chkBook3.AutoSize = true;
            this.chkBook3.Location = new System.Drawing.Point(1097, 323);
            this.chkBook3.Margin = new System.Windows.Forms.Padding(4);
            this.chkBook3.Name = "chkBook3";
            this.chkBook3.Size = new System.Drawing.Size(18, 17);
            this.chkBook3.TabIndex = 148;
            this.chkBook3.UseVisualStyleBackColor = true;
            this.chkBook3.Visible = false;
            // 
            // chkBook2
            // 
            this.chkBook2.AutoSize = true;
            this.chkBook2.Location = new System.Drawing.Point(1097, 296);
            this.chkBook2.Margin = new System.Windows.Forms.Padding(4);
            this.chkBook2.Name = "chkBook2";
            this.chkBook2.Size = new System.Drawing.Size(18, 17);
            this.chkBook2.TabIndex = 147;
            this.chkBook2.UseVisualStyleBackColor = true;
            this.chkBook2.Visible = false;
            // 
            // chkBook1
            // 
            this.chkBook1.AutoSize = true;
            this.chkBook1.Location = new System.Drawing.Point(1097, 270);
            this.chkBook1.Margin = new System.Windows.Forms.Padding(4);
            this.chkBook1.Name = "chkBook1";
            this.chkBook1.Size = new System.Drawing.Size(18, 17);
            this.chkBook1.TabIndex = 146;
            this.chkBook1.UseVisualStyleBackColor = true;
            this.chkBook1.Visible = false;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colAuthor,
            this.colLocation});
            this.dgvResults.Location = new System.Drawing.Point(60, 237);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.Size = new System.Drawing.Size(1033, 168);
            this.dgvResults.TabIndex = 145;
            this.dgvResults.Visible = false;
            // 
            // colId
            // 
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colTitle
            // 
            this.colTitle.Frozen = true;
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 200;
            // 
            // colAuthor
            // 
            this.colAuthor.Frozen = true;
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 200;
            // 
            // colLocation
            // 
            this.colLocation.Frozen = true;
            this.colLocation.HeaderText = "Location";
            this.colLocation.MinimumWidth = 6;
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 200;
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.grpBookCart);
            this.Controls.Add(this.chkBook4);
            this.Controls.Add(this.chkBook3);
            this.Controls.Add(this.chkBook2);
            this.Controls.Add(this.chkBook1);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnMemberID);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblReturnBook);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.mnuBackStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReturnBook";
            this.Text = "Return Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.grpBookCart.ResumeLayout(false);
            this.grpBookCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnMemberID;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblReturnBook;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.GroupBox grpBookCart;
        private System.Windows.Forms.Label lblBookCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox chkBook4;
        private System.Windows.Forms.CheckBox chkBook3;
        private System.Windows.Forms.CheckBox chkBook2;
        private System.Windows.Forms.CheckBox chkBook1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
    }
}