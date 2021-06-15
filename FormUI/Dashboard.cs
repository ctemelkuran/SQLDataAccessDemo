﻿using System;
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
    }
}
