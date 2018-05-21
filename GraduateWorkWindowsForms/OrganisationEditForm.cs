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
    public partial class ArtifactEditForm : Form
    {
        public static Form1 form1 = new Form1();
        string organisationType = "The Fox";

        public delegate void ChangeTextBox(string nText);
        public event ChangeTextBox ChangeTextBox1;

        public ArtifactEditForm(Form1 f1)
        {
            InitializeComponent();
            ChangeTextBox1 += f1.ChangeTextInArtifactUpd;
            OrganisationList.Text = organisationType;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ChangeTextBox1(OrganisationList.Text);
        }
    }
}
