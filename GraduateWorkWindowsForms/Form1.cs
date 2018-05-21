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
    public partial class Form1 : Form
    {

         string text = "";

        string personType = "";
        string locationType = "";
        string organisationType = "";
        string otherType = "";
        string consumerGoodType = "";
        string workOfArt = "";
        string type;

        TextAnalyze textAnalyze = new TextAnalyze();
         static Dictionary<string, string> forAnalyze = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        public void ChangeTextInPersonListUpd(string newText)
        {
            PersonListUpd.Text = newText;
        }

        public void ChangeTextInLocationListUpd(string newText)
        {
            LocationListUpd.Text = newText;
        }

        public void ChangeTextInArtifactUpd(string newText)
        {
            ArtefactList.Text = newText;
        }

        public void ChangeTextInTimeVal(string newText)
        {
            TimeVal.Text = newText;
        }


        /*
        public void ChangeTextInConsumerGoodList(string newText)
        {
            ConsumerGoodList.Text = newText;
        }
        */



        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm personEditForm = new PersonEditForm(this);
            personEditForm.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            LocationEditForm locationEditForm = new LocationEditForm(this);
            locationEditForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           

        }


        /*
        private void button10_Click(object sender, EventArgs e)
        {
            ConsumerGoodEditList consumerGoodEditList = new ConsumerGoodEditList(this);
            consumerGoodEditList.Show();
        }
        */

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ArtifactEditForm organisationEditForm = new ArtifactEditForm(this);
            organisationEditForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OtherEditForm otherEditForm = new OtherEditForm(this);
            otherEditForm.Show();
        }

        private void OtherListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonListUpd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exampleLabel.Text = "man \n people \n stranger \n ropers \n saddlers \n tanners \n bridle";
            //string[] personType = { "man", "people", "stranger", "ropers", "saddlers", "tanners", "bridle" };
            //string[] locationType = { "man", "people", "stranger", "ropers", "saddlers", "tanners", "bridle" };
            //string[] organisationType = { "man", "people", "stranger", "ropers", "saddlers", "tanners", "bridle" };
            //string[] otherType = { "man", "people", "stranger", "ropers", "saddlers", "tanners", "bridle" };
            //string[] consumerGoodType = { "man", "people", "stranger", "ropers", "saddlers", "tanners", "bridle" };

            //PersonListView.Items.AddRange(personType);
            //LocationListView.Items.AddRange(locationType);
            //OrganisationListView.Items.AddRange(organisationType);
            //OtherListView.Items.AddRange(otherType);
            //ConsumerGoodListView.Items.AddRange(consumerGoodType);
            

            text = FullText.Text;
            forAnalyze = textAnalyze.AnalyzeEntitiesFromText(text);

            foreach (KeyValuePair<string, string> kvp in forAnalyze)
            {
                type = kvp.Value;
                if (kvp.Value == "Other")
                    otherType = otherType + kvp.Key + "\n";
                if (kvp.Value == "Person")
                    personType = personType + kvp.Key + "\n";
                if (kvp.Value == "WorkOfArt")
                    workOfArt = workOfArt + kvp.Key + "\n";
                if (kvp.Value == "Location")
                    locationType = locationType + kvp.Key + "\n";
                if (kvp.Value == "ConsumerGood")
                    consumerGoodType = consumerGoodType + kvp.Key + "\n";
                if (kvp.Value == "Organisation")
                    organisationType = organisationType + kvp.Key + "\n";
               
            }



            PersonList.Text = personType;
            LocationList.Text = locationType;
            OrganisationList.Text = organisationType;
            OtherList.Text = otherType;
            ConsumerGoodList.Text = consumerGoodType;


        }

        private void showPrototype (object sender, EventArgs e)
        {
            PresentationForm presentationForm = new PresentationForm();
            presentationForm.Show();
        }
    }
}
