﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonationCampWindowsForms
{
    public partial class Operations : Form
    {
        public Operations()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Save s = new Save();
            s.Show();
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.Show();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            this.Hide();
        }
    }
}
