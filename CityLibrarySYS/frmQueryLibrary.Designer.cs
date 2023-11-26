namespace CityLibrarySYS
{
    partial class frmQueryLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryLibrary));
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboLibraryID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLibaryId = new System.Windows.Forms.Label();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLibraryInfo = new System.Windows.Forms.GroupBox();
            this.rtbLibraryInfo = new System.Windows.Forms.RichTextBox();
            this.mnuBackStrip.SuspendLayout();
            this.grpLibraryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(741, 161);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 49);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboLibraryID
            // 
            this.cboLibraryID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLibraryID.FormattingEnabled = true;
            this.cboLibraryID.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.cboLibraryID.Location = new System.Drawing.Point(494, 170);
            this.cboLibraryID.Margin = new System.Windows.Forms.Padding(4);
            this.cboLibraryID.Name = "cboLibraryID";
            this.cboLibraryID.Size = new System.Drawing.Size(200, 28);
            this.cboLibraryID.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 41);
            this.label1.TabIndex = 83;
            this.label1.Text = "Query Library";
            // 
            // lblLibaryId
            // 
            this.lblLibaryId.AutoSize = true;
            this.lblLibaryId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibaryId.Location = new System.Drawing.Point(359, 175);
            this.lblLibaryId.Name = "lblLibaryId";
            this.lblLibaryId.Size = new System.Drawing.Size(95, 20);
            this.lblLibaryId.TabIndex = 82;
            this.lblLibaryId.Text = "Library ID";
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Size = new System.Drawing.Size(1179, 34);
            this.mnuBackStrip.TabIndex = 85;
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
            // grpLibraryInfo
            // 
            this.grpLibraryInfo.Controls.Add(this.rtbLibraryInfo);
            this.grpLibraryInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLibraryInfo.Location = new System.Drawing.Point(160, 250);
            this.grpLibraryInfo.Name = "grpLibraryInfo";
            this.grpLibraryInfo.Size = new System.Drawing.Size(850, 350);
            this.grpLibraryInfo.TabIndex = 86;
            this.grpLibraryInfo.TabStop = false;
            this.grpLibraryInfo.Text = "Library Information";
            this.grpLibraryInfo.Enter += new System.EventHandler(this.grpLibraryInfo_Enter);
            // 
            // rtbLibraryInfo
            // 
            this.rtbLibraryInfo.Location = new System.Drawing.Point(77, 50);
            this.rtbLibraryInfo.Name = "rtbLibraryInfo";
            this.rtbLibraryInfo.Size = new System.Drawing.Size(700, 250);
            this.rtbLibraryInfo.TabIndex = 0;
            this.rtbLibraryInfo.Text = "";
            this.rtbLibraryInfo.TextChanged += new System.EventHandler(this.rtbLibraryInfo_TextChanged);
            // 
            // frmQueryLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.mnuBackStrip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboLibraryID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLibaryId);
            this.Controls.Add(this.grpLibraryInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQueryLibrary";
            this.Text = "Query Library";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpLibraryInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboLibraryID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLibaryId;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpLibraryInfo;
        private System.Windows.Forms.RichTextBox rtbLibraryInfo;
    }
}