namespace CityLibrarySYS
{
    partial class frmRemoveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveBook));
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboLibraryID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBookInfoInfo = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblLibraryInfo = new System.Windows.Forms.Label();
            this.mnuBackStrip.SuspendLayout();
            this.grpBookInfoInfo.SuspendLayout();
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
            this.mnuBackStrip.TabIndex = 86;
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
            // cboLibraryID
            // 
            this.cboLibraryID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLibraryID.FormattingEnabled = true;
            this.cboLibraryID.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.cboLibraryID.Location = new System.Drawing.Point(352, 130);
            this.cboLibraryID.Name = "cboLibraryID";
            this.cboLibraryID.Size = new System.Drawing.Size(150, 24);
            this.cboLibraryID.TabIndex = 102;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(520, 125);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 103;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(267, 133);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(65, 17);
            this.lblBookId.TabIndex = 105;
            this.lblBookId.Text = "Book ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 104;
            this.label1.Text = "Remove Book";
            // 
            // grpBookInfoInfo
            // 
            this.grpBookInfoInfo.Controls.Add(this.btnOk);
            this.grpBookInfoInfo.Controls.Add(this.lblLibraryInfo);
            this.grpBookInfoInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookInfoInfo.Location = new System.Drawing.Point(117, 200);
            this.grpBookInfoInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookInfoInfo.Name = "grpBookInfoInfo";
            this.grpBookInfoInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookInfoInfo.Size = new System.Drawing.Size(650, 300);
            this.grpBookInfoInfo.TabIndex = 106;
            this.grpBookInfoInfo.TabStop = false;
            this.grpBookInfoInfo.Text = "Book Information";
            this.grpBookInfoInfo.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(285, 240);
            this.btnOk.Margin = new System.Windows.Forms.Padding(10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 30);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // lblLibraryInfo
            // 
            this.lblLibraryInfo.AutoSize = true;
            this.lblLibraryInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryInfo.Location = new System.Drawing.Point(90, 50);
            this.lblLibraryInfo.Name = "lblLibraryInfo";
            this.lblLibraryInfo.Size = new System.Drawing.Size(18, 18);
            this.lblLibraryInfo.TabIndex = 1;
            this.lblLibraryInfo.Text = "0";
            // 
            // frmRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.grpBookInfoInfo);
            this.Controls.Add(this.cboLibraryID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuBackStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRemoveBook";
            this.Text = "Remove Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpBookInfoInfo.ResumeLayout(false);
            this.grpBookInfoInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboLibraryID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBookInfoInfo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblLibraryInfo;
    }
}