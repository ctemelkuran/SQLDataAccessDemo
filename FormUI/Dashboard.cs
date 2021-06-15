using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {

            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            listbxPeopleFound.DataSource = people;
            listbxPeopleFound.DisplayMember = "FullInfo";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //we gonna call the database
            DataAccess db = new DataAccess();
            people = db.GetPeople(txtbxLastName.Text);
            UpdateBinding();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertPerson(txtbxFirstNameIns.Text, txtbxLastNameIns.Text, txtbxEmailIns.Text, txtbxPhoneNumberIns.Text);
            txtbxFirstNameIns.Text = "";
            txtbxLastNameIns.Text = "";
            txtbxEmailIns.Text = "";
            txtbxPhoneNumberIns.Text = "";
        }
    }
}
