
namespace FormUI
{
    partial class Dashboard
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
            this.listbxPeopleFound = new System.Windows.Forms.ListBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFirstNameIns = new System.Windows.Forms.Label();
            this.txtbxFirstNameIns = new System.Windows.Forms.TextBox();
            this.lblLastNameIns = new System.Windows.Forms.Label();
            this.txtbxLastNameIns = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberIns = new System.Windows.Forms.Label();
            this.txtbxPhoneNumberIns = new System.Windows.Forms.TextBox();
            this.lblEmailAdressIns = new System.Windows.Forms.Label();
            this.txtbxEmailIns = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbxPeopleFound
            // 
            this.listbxPeopleFound.FormattingEnabled = true;
            this.listbxPeopleFound.Location = new System.Drawing.Point(24, 100);
            this.listbxPeopleFound.Name = "listbxPeopleFound";
            this.listbxPeopleFound.Size = new System.Drawing.Size(204, 160);
            this.listbxPeopleFound.TabIndex = 0;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(85, 26);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(143, 20);
            this.txtbxLastName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(21, 29);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(117, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFirstNameIns
            // 
            this.lblFirstNameIns.AutoSize = true;
            this.lblFirstNameIns.Location = new System.Drawing.Point(21, 284);
            this.lblFirstNameIns.Name = "lblFirstNameIns";
            this.lblFirstNameIns.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameIns.TabIndex = 5;
            this.lblFirstNameIns.Text = "First Name";
            // 
            // txtbxFirstNameIns
            // 
            this.txtbxFirstNameIns.Location = new System.Drawing.Point(101, 280);
            this.txtbxFirstNameIns.Name = "txtbxFirstNameIns";
            this.txtbxFirstNameIns.Size = new System.Drawing.Size(143, 20);
            this.txtbxFirstNameIns.TabIndex = 4;
            // 
            // lblLastNameIns
            // 
            this.lblLastNameIns.AutoSize = true;
            this.lblLastNameIns.Location = new System.Drawing.Point(21, 310);
            this.lblLastNameIns.Name = "lblLastNameIns";
            this.lblLastNameIns.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameIns.TabIndex = 7;
            this.lblLastNameIns.Text = "Last Name";
            // 
            // txtbxLastNameIns
            // 
            this.txtbxLastNameIns.Location = new System.Drawing.Point(101, 306);
            this.txtbxLastNameIns.Name = "txtbxLastNameIns";
            this.txtbxLastNameIns.Size = new System.Drawing.Size(143, 20);
            this.txtbxLastNameIns.TabIndex = 6;
            // 
            // lblPhoneNumberIns
            // 
            this.lblPhoneNumberIns.AutoSize = true;
            this.lblPhoneNumberIns.Location = new System.Drawing.Point(21, 361);
            this.lblPhoneNumberIns.Name = "lblPhoneNumberIns";
            this.lblPhoneNumberIns.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumberIns.TabIndex = 11;
            this.lblPhoneNumberIns.Text = "Phone Number";
            // 
            // txtbxPhoneNumberIns
            // 
            this.txtbxPhoneNumberIns.Location = new System.Drawing.Point(101, 358);
            this.txtbxPhoneNumberIns.Name = "txtbxPhoneNumberIns";
            this.txtbxPhoneNumberIns.Size = new System.Drawing.Size(143, 20);
            this.txtbxPhoneNumberIns.TabIndex = 10;
            // 
            // lblEmailAdressIns
            // 
            this.lblEmailAdressIns.AutoSize = true;
            this.lblEmailAdressIns.Location = new System.Drawing.Point(21, 336);
            this.lblEmailAdressIns.Name = "lblEmailAdressIns";
            this.lblEmailAdressIns.Size = new System.Drawing.Size(35, 13);
            this.lblEmailAdressIns.TabIndex = 9;
            this.lblEmailAdressIns.Text = "E mail";
            // 
            // txtbxEmailIns
            // 
            this.txtbxEmailIns.Location = new System.Drawing.Point(101, 332);
            this.txtbxEmailIns.Name = "txtbxEmailIns";
            this.txtbxEmailIns.Size = new System.Drawing.Size(143, 20);
            this.txtbxEmailIns.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(137, 384);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblPhoneNumberIns);
            this.Controls.Add(this.txtbxPhoneNumberIns);
            this.Controls.Add(this.lblEmailAdressIns);
            this.Controls.Add(this.txtbxEmailIns);
            this.Controls.Add(this.lblLastNameIns);
            this.Controls.Add(this.txtbxLastNameIns);
            this.Controls.Add(this.lblFirstNameIns);
            this.Controls.Add(this.txtbxFirstNameIns);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.listbxPeopleFound);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbxPeopleFound;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFirstNameIns;
        private System.Windows.Forms.TextBox txtbxFirstNameIns;
        private System.Windows.Forms.Label lblLastNameIns;
        private System.Windows.Forms.TextBox txtbxLastNameIns;
        private System.Windows.Forms.Label lblPhoneNumberIns;
        private System.Windows.Forms.TextBox txtbxPhoneNumberIns;
        private System.Windows.Forms.Label lblEmailAdressIns;
        private System.Windows.Forms.TextBox txtbxEmailIns;
        private System.Windows.Forms.Button btnInsert;
    }
}

