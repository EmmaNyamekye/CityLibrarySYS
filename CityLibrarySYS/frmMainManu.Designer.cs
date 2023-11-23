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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryPopularityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genrePopularityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLibrary = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.loanToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLibraryToolStripMenuItem,
            this.updateLibraryToolStripMenuItem,
            this.queryLibraryToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // addLibraryToolStripMenuItem
            // 
            this.addLibraryToolStripMenuItem.Name = "addLibraryToolStripMenuItem";
            this.addLibraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addLibraryToolStripMenuItem.Text = "Add Library";
            // 
            // updateLibraryToolStripMenuItem
            // 
            this.updateLibraryToolStripMenuItem.Name = "updateLibraryToolStripMenuItem";
            this.updateLibraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateLibraryToolStripMenuItem.Text = "Update Library";
            // 
            // queryLibraryToolStripMenuItem
            // 
            this.queryLibraryToolStripMenuItem.Name = "queryLibraryToolStripMenuItem";
            this.queryLibraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryLibraryToolStripMenuItem.Text = "Query Library";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.updateMemberToolStripMenuItem,
            this.deregisterMemberToolStripMenuItem});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            // 
            // updateMemberToolStripMenuItem
            // 
            this.updateMemberToolStripMenuItem.Name = "updateMemberToolStripMenuItem";
            this.updateMemberToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.updateMemberToolStripMenuItem.Text = "Update Member";
            // 
            // deregisterMemberToolStripMenuItem
            // 
            this.deregisterMemberToolStripMenuItem.Name = "deregisterMemberToolStripMenuItem";
            this.deregisterMemberToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deregisterMemberToolStripMenuItem.Text = "Deregister Member";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.updateBookToolStripMenuItem,
            this.removeBookToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            // 
            // updateBookToolStripMenuItem
            // 
            this.updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            this.updateBookToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.updateBookToolStripMenuItem.Text = "Update Book";
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.removeBookToolStripMenuItem.Text = "Remove Book";
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserveBookToolStripMenuItem,
            this.collectBookToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loanToolStripMenuItem.Text = "Loan";
            // 
            // reserveBookToolStripMenuItem
            // 
            this.reserveBookToolStripMenuItem.Name = "reserveBookToolStripMenuItem";
            this.reserveBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reserveBookToolStripMenuItem.Text = "Reserve Book";
            // 
            // collectBookToolStripMenuItem
            // 
            this.collectBookToolStripMenuItem.Name = "collectBookToolStripMenuItem";
            this.collectBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.collectBookToolStripMenuItem.Text = "Collect Book";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryPopularityToolStripMenuItem,
            this.genrePopularityToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // libraryPopularityToolStripMenuItem
            // 
            this.libraryPopularityToolStripMenuItem.Name = "libraryPopularityToolStripMenuItem";
            this.libraryPopularityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libraryPopularityToolStripMenuItem.Text = "Library Popularity";
            // 
            // genrePopularityToolStripMenuItem
            // 
            this.genrePopularityToolStripMenuItem.Name = "genrePopularityToolStripMenuItem";
            this.genrePopularityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genrePopularityToolStripMenuItem.Text = "Genre Popularity";
            // 
            // picLibrary
            // 
            this.picLibrary.Image = ((System.Drawing.Image)(resources.GetObject("picLibrary.Image")));
            this.picLibrary.Location = new System.Drawing.Point(0, 27);
            this.picLibrary.Name = "picLibrary";
            this.picLibrary.Size = new System.Drawing.Size(884, 536);
            this.picLibrary.TabIndex = 1;
            this.picLibrary.TabStop = false;
            this.picLibrary.Click += new System.EventHandler(this.picLibraary_Click);
            // 
            // frmMainManu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.picLibrary);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainManu";
            this.Text = "City Library";
            this.Load += new System.EventHandler(this.frmMainManu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryPopularityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genrePopularityToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLibrary;
    }
}

