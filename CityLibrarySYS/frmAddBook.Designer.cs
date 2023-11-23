namespace CityLibrarySYS
{
    partial class frmAddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBook));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboLibraryID = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLibraryID = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPublication = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPublication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(146, 278);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(306, 116);
            this.txtDescription.TabIndex = 75;
            // 
            // cboLibraryID
            // 
            this.cboLibraryID.FormattingEnabled = true;
            this.cboLibraryID.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.cboLibraryID.Location = new System.Drawing.Point(146, 418);
            this.cboLibraryID.Name = "cboLibraryID";
            this.cboLibraryID.Size = new System.Drawing.Size(306, 21);
            this.cboLibraryID.TabIndex = 74;
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "Fiction",
            "Non-Fiction",
            "Mystery",
            "Science Fiction",
            "Fantasy",
            "Romance",
            "Thriller",
            "Horror",
            "Adventure",
            "Historical Fiction",
            "Biography",
            "Autobiography",
            "Self-Help",
            "Science",
            "Philosophy"});
            this.cboGenre.Location = new System.Drawing.Point(146, 177);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(306, 21);
            this.cboGenre.TabIndex = 73;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(42, 179);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(41, 16);
            this.lblGenre.TabIndex = 72;
            this.lblGenre.Text = "Genre";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(146, 127);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(306, 27);
            this.txtAuthor.TabIndex = 71;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(42, 130);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 16);
            this.lblAuthor.TabIndex = 70;
            this.lblAuthor.Text = "Author";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSubmit.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(211, 484);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 43);
            this.btnSubmit.TabIndex = 69;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLibraryID
            // 
            this.lblLibraryID.AutoSize = true;
            this.lblLibraryID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryID.Location = new System.Drawing.Point(42, 420);
            this.lblLibraryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibraryID.Name = "lblLibraryID";
            this.lblLibraryID.Size = new System.Drawing.Size(61, 16);
            this.lblLibraryID.TabIndex = 68;
            this.lblLibraryID.Text = "Library ID";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(146, 34);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(306, 27);
            this.txtISBN.TabIndex = 66;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(42, 37);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(36, 16);
            this.lblISBN.TabIndex = 65;
            this.lblISBN.Text = "ISBN";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(146, 79);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(306, 27);
            this.txtTitle.TabIndex = 64;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(42, 82);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 16);
            this.lblTitle.TabIndex = 63;
            this.lblTitle.Text = "Title";
            // 
            // txtPublication
            // 
            this.txtPublication.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublication.Location = new System.Drawing.Point(146, 227);
            this.txtPublication.Margin = new System.Windows.Forms.Padding(2);
            this.txtPublication.Name = "txtPublication";
            this.txtPublication.Size = new System.Drawing.Size(306, 27);
            this.txtPublication.TabIndex = 62;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(42, 281);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 16);
            this.lblDescription.TabIndex = 60;
            this.lblDescription.Text = "Description";
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublication.Location = new System.Drawing.Point(42, 230);
            this.lblPublication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(69, 16);
            this.lblPublication.TabIndex = 61;
            this.lblPublication.Text = "Publication";
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboLibraryID);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblLibraryID);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPublication);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPublication);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddBook";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboLibraryID;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLibraryID;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPublication;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPublication;
    }
}