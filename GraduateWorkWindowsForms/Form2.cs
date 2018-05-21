using System;
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
    public partial class PersonEditForm : Form
    {
        public static Form1 form1 = new Form1();
        //public static string personListChanges = "";
        string personType = "man \n people \n stranger \n ropers \n saddlers \n tanners \n bridle";
        //public bool button1WasClicked = false;

        public delegate void ChangeTextBox(string nText);
        public event ChangeTextBox ChangeTextBox1;

        public PersonEditForm(Form1 f1)
        {
            InitializeComponent();
            ChangeTextBox1 += f1.ChangeTextInPersonListUpd;
            PersonListEdit.Text = personType;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeTextBox1(PersonListEdit.Text);
        }



        private void Person_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
