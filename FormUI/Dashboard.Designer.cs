
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
            this.SuspendLayout();
            // 
            // listbxPeopleFound
            // 
            this.listbxPeopleFound.FormattingEnabled = true;
            this.listbxPeopleFound.Location = new System.Drawing.Point(12, 85);
            this.listbxPeopleFound.Name = "listbxPeopleFound";
            this.listbxPeopleFound.Size = new System.Drawing.Size(204, 160);
            this.listbxPeopleFound.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listbxPeopleFound);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbxPeopleFound;
    }
}

