﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateWorkWindowsForms
{
    public partial class LocationEditForm : Form
    {
        public static Form1 form1 = new Form1();
        public static string locationListChanges = "";
        string locationType = "north \n Ropers Gate \n street \n tavern \n Old Narakort Inn";

        public delegate void ChangeTextBox(string nText);
        public event ChangeTextBox ChangeTextBox1;


        public LocationEditForm(Form1 f1)
        {
            InitializeComponent();
            ChangeTextBox1 += f1.ChangeTextInLocationListUpd;
            LocationListEdit.Text = locationType;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ChangeTextBox1(LocationListEdit.Text);
        }
    }
}
