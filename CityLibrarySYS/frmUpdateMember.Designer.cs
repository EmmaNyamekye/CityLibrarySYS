namespace CityLibrarySYS
{
    partial class frmUpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMember));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSubmit.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(631, 43);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 43);
            this.btnSubmit.TabIndex = 59;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(262, 53);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(306, 27);
            this.txtMemberId.TabIndex = 58;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(138, 56);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(69, 16);
            this.lblMemberId.TabIndex = 57;
            this.lblMemberId.Text = "Member ID";
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblMemberId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateMember";
            this.Text = "Update Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
    }
}