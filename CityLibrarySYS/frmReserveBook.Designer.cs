namespace CityLibrarySYS
{
    partial class lblResult1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblResult1));
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblReserveBook = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mnuBackStrip.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
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
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuBackStrip.Size = new System.Drawing.Size(884, 30);
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
            this.mnuBack.Size = new System.Drawing.Size(53, 20);
            this.mnuBack.Text = "BACK";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(128, 103);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberId.MaxLength = 15;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(150, 23);
            this.txtMemberId.TabIndex = 100;
            // 
            // lblReserveBook
            // 
            this.lblReserveBook.AutoSize = true;
            this.lblReserveBook.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveBook.Location = new System.Drawing.Point(33, 47);
            this.lblReserveBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReserveBook.Name = "lblReserveBook";
            this.lblReserveBook.Size = new System.Drawing.Size(199, 32);
            this.lblReserveBook.TabIndex = 99;
            this.lblReserveBook.Text = "Reserve Book";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(35, 108);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(77, 16);
            this.lblMemberId.TabIndex = 97;
            this.lblMemberId.Text = "Member ID";
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblMemberInfo);
            this.grpMemberInfo.Location = new System.Drawing.Point(508, 47);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberInfo.Size = new System.Drawing.Size(350, 100);
            this.grpMemberInfo.TabIndex = 101;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Info";
            this.grpMemberInfo.Visible = false;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberInfo.Location = new System.Drawing.Point(15, 20);
            this.lblMemberInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(14, 13);
            this.lblMemberInfo.TabIndex = 102;
            this.lblMemberInfo.Text = "0";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(128, 158);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.MaxLength = 13;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(582, 24);
            this.txtTitle.TabIndex = 110;
            this.txtTitle.Visible = false;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnSearchMember.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(733, 156);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(10);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(100, 30);
            this.btnSearchMember.TabIndex = 108;
            this.btnSearchMember.Text = "SEARCH";
            this.btnSearchMember.UseVisualStyleBackColor = false;
            this.btnSearchMember.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(44, 162);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 17);
            this.lblTitle.TabIndex = 109;
            this.lblTitle.Text = "Title";
            this.lblTitle.Visible = false;
            // 
            // grpCart
            // 
            this.grpCart.Location = new System.Drawing.Point(458, 385);
            this.grpCart.Margin = new System.Windows.Forms.Padding(2);
            this.grpCart.Name = "grpCart";
            this.grpCart.Padding = new System.Windows.Forms.Padding(2);
            this.grpCart.Size = new System.Drawing.Size(400, 150);
            this.grpCart.TabIndex = 118;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Book Cart";
            this.grpCart.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnConfirm.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(716, 505);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 30);
            this.btnConfirm.TabIndex = 122;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpResults
            // 
            this.grpResults.Location = new System.Drawing.Point(23, 214);
            this.grpResults.Margin = new System.Windows.Forms.Padding(2);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(2);
            this.grpResults.Size = new System.Drawing.Size(850, 150);
            this.grpResults.TabIndex = 124;
            this.grpResults.TabStop = false;
            this.grpResults.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 125;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblResult1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblReserveBook);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.mnuBackStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lblResult1";
            this.Text = "Reserve Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblReserveBook;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Button button1;
    }
}