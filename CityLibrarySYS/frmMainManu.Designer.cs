namespace CityLibrarySYS
{
    partial class frmMainManu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainManu));
            this.mnuMainManu = new System.Windows.Forms.MenuStrip();
            this.mnuLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeregisterMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReserveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollectBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLibraryPopularity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenrePopularity = new System.Windows.Forms.ToolStripMenuItem();
            this.picWelcomeLibrary = new System.Windows.Forms.PictureBox();
            this.mnuMainManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcomeLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainManu
            // 
            this.mnuMainManu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainManu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainManu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLibrary,
            this.mnuMember,
            this.mnuBook,
            this.mnuLoan,
            this.mnuAnalysis});
            this.mnuMainManu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuMainManu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainManu.Name = "mnuMainManu";
            this.mnuMainManu.Size = new System.Drawing.Size(1179, 28);
            this.mnuMainManu.TabIndex = 0;
            this.mnuMainManu.Text = "Manu";
            // 
            // mnuLibrary
            // 
            this.mnuLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddLibrary,
            this.mnuUpdateLibrary,
            this.mnuQueryLibrary});
            this.mnuLibrary.Name = "mnuLibrary";
            this.mnuLibrary.Size = new System.Drawing.Size(82, 24);
            this.mnuLibrary.Text = "Library";
            this.mnuLibrary.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // mnuAddLibrary
            // 
            this.mnuAddLibrary.Name = "mnuAddLibrary";
            this.mnuAddLibrary.Size = new System.Drawing.Size(218, 26);
            this.mnuAddLibrary.Text = "Add Library";
            this.mnuAddLibrary.Click += new System.EventHandler(this.addLibraryToolStripMenuItem_Click);
            // 
            // mnuUpdateLibrary
            // 
            this.mnuUpdateLibrary.Name = "mnuUpdateLibrary";
            this.mnuUpdateLibrary.Size = new System.Drawing.Size(218, 26);
            this.mnuUpdateLibrary.Text = "Update Library";
            this.mnuUpdateLibrary.Click += new System.EventHandler(this.mnuUpdateLibrary_Click);
            // 
            // mnuQueryLibrary
            // 
            this.mnuQueryLibrary.Name = "mnuQueryLibrary";
            this.mnuQueryLibrary.Size = new System.Drawing.Size(218, 26);
            this.mnuQueryLibrary.Text = "Query Library";
            this.mnuQueryLibrary.Click += new System.EventHandler(this.mnuQueryLibrary_Click);
            // 
            // mnuMember
            // 
            this.mnuMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuUpdateMember,
            this.mnuDeregisterMember});
            this.mnuMember.Name = "mnuMember";
            this.mnuMember.Size = new System.Drawing.Size(92, 24);
            this.mnuMember.Text = "Member";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(256, 26);
            this.mnuAddMember.Text = "Add Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(256, 26);
            this.mnuUpdateMember.Text = "Update Member";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuDeregisterMember
            // 
            this.mnuDeregisterMember.Name = "mnuDeregisterMember";
            this.mnuDeregisterMember.Size = new System.Drawing.Size(256, 26);
            this.mnuDeregisterMember.Text = "Deregister Member";
            this.mnuDeregisterMember.Click += new System.EventHandler(this.mnuDeregisterMember_Click);
            // 
            // mnuBook
            // 
            this.mnuBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.mnuUpdateBook,
            this.mnuRemoveBook});
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Size = new System.Drawing.Size(65, 24);
            this.mnuBook.Text = "Book";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(209, 26);
            this.mnuAddBook.Text = "Add Book";
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(209, 26);
            this.mnuUpdateBook.Text = "Update Book";
            this.mnuUpdateBook.Click += new System.EventHandler(this.mnuUpdateBook_Click);
            // 
            // mnuRemoveBook
            // 
            this.mnuRemoveBook.Name = "mnuRemoveBook";
            this.mnuRemoveBook.Size = new System.Drawing.Size(224, 26);
            this.mnuRemoveBook.Text = "Remove Book";
            this.mnuRemoveBook.Click += new System.EventHandler(this.mnuRemoveBook_Click);
            // 
            // mnuLoan
            // 
            this.mnuLoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReserveBook,
            this.mnuCollectBook,
            this.mnuReturnBook});
            this.mnuLoan.Name = "mnuLoan";
            this.mnuLoan.Size = new System.Drawing.Size(63, 24);
            this.mnuLoan.Text = "Loan";
            // 
            // mnuReserveBook
            // 
            this.mnuReserveBook.Name = "mnuReserveBook";
            this.mnuReserveBook.Size = new System.Drawing.Size(208, 26);
            this.mnuReserveBook.Text = "Reserve Book";
            // 
            // mnuCollectBook
            // 
            this.mnuCollectBook.Name = "mnuCollectBook";
            this.mnuCollectBook.Size = new System.Drawing.Size(208, 26);
            this.mnuCollectBook.Text = "Collect Book";
            // 
            // mnuReturnBook
            // 
            this.mnuReturnBook.Name = "mnuReturnBook";
            this.mnuReturnBook.Size = new System.Drawing.Size(208, 26);
            this.mnuReturnBook.Text = "Return Book";
            // 
            // mnuAnalysis
            // 
            this.mnuAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLibraryPopularity,
            this.mnuGenrePopularity});
            this.mnuAnalysis.Name = "mnuAnalysis";
            this.mnuAnalysis.Size = new System.Drawing.Size(94, 24);
            this.mnuAnalysis.Text = "Analysis";
            // 
            // mnuLibraryPopularity
            // 
            this.mnuLibraryPopularity.Name = "mnuLibraryPopularity";
            this.mnuLibraryPopularity.Size = new System.Drawing.Size(243, 26);
            this.mnuLibraryPopularity.Text = "Library Popularity";
            // 
            // mnuGenrePopularity
            // 
            this.mnuGenrePopularity.Name = "mnuGenrePopularity";
            this.mnuGenrePopularity.Size = new System.Drawing.Size(243, 26);
            this.mnuGenrePopularity.Text = "Genre Popularity";
            // 
            // picWelcomeLibrary
            // 
            this.picWelcomeLibrary.Image = ((System.Drawing.Image)(resources.GetObject("picWelcomeLibrary.Image")));
            this.picWelcomeLibrary.Location = new System.Drawing.Point(0, 33);
            this.picWelcomeLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.picWelcomeLibrary.Name = "picWelcomeLibrary";
            this.picWelcomeLibrary.Size = new System.Drawing.Size(1179, 660);
            this.picWelcomeLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWelcomeLibrary.TabIndex = 1;
            this.picWelcomeLibrary.TabStop = false;
            this.picWelcomeLibrary.Click += new System.EventHandler(this.picLibraary_Click);
            // 
            // frmMainManu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.picWelcomeLibrary);
            this.Controls.Add(this.mnuMainManu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainManu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainManu";
            this.Text = "City Library";
            this.Load += new System.EventHandler(this.frmMainManu_Load);
            this.mnuMainManu.ResumeLayout(false);
            this.mnuMainManu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcomeLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainManu;
        private System.Windows.Forms.ToolStripMenuItem mnuLibrary;
        private System.Windows.Forms.ToolStripMenuItem mnuAddLibrary;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateLibrary;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryLibrary;
        private System.Windows.Forms.ToolStripMenuItem mnuMember;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuDeregisterMember;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuLoan;
        private System.Windows.Forms.ToolStripMenuItem mnuReserveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuCollectBook;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuLibraryPopularity;
        private System.Windows.Forms.ToolStripMenuItem mnuGenrePopularity;
        private System.Windows.Forms.PictureBox picWelcomeLibrary;
    }
}

