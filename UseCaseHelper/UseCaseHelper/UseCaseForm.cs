using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class UseCaseForm : Form
    {
        public UseCase UsecaseInForm { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Actor> selectedActors{ get; set; }
        public bool gereed1 { get; set; }

        public UseCaseForm( List<Actor> actors)
        {
            InitializeComponent();
            foreach (Actor a in actors)
            {
                clbActors.Items.Add(a.Name);
            }
            UsecaseInForm = new UseCase();
            Actors = new List<Actor>();
            Actors.AddRange(actors);
            gereed1 = false;
        }
        public UseCaseForm(List<Actor> actors, UseCase uc)
        {
            InitializeComponent();
            Actors = new List<Actor>();
            Actors.AddRange(actors);
            foreach (Actor a in Actors) //zet alle actors in de checkedlistbox
            {
                clbActors.Items.Add(a);
            }
            UsecaseInForm = new UseCase(uc);
            tbNaam.Text = UsecaseInForm.Naam;
            tbSamenvatting.Text = UsecaseInForm.Samenvatting;
            tbAanname.Text = UsecaseInForm.Aanname;
            tbOmschrijving.Text = UsecaseInForm.Beschrijving;
            tbResultaat.Text = UsecaseInForm.Resultaat;
            tbUItzondering.Text = UsecaseInForm.Uitzondering;
            tbResultaat.Text = UsecaseInForm.Resultaat;
            gereed1 = false;

        }

        private void btnKlaar_Click(object sender, EventArgs e)
        {

            if (tbNaam.Text != null && tbAanname.Text != "" && tbOmschrijving.Text != "" && tbResultaat.Text != "" && tbSamenvatting.Text != "" && tbUItzondering.Text != "") // kijkt of alles is ingevuld
            {
                
                UsecaseInForm.Naam = tbNaam.Text;
                UsecaseInForm.Samenvatting = tbSamenvatting.Text;
                UsecaseInForm.Aanname = tbAanname.Text;
                UsecaseInForm.Beschrijving = tbOmschrijving.Text;
                UsecaseInForm.Resultaat = tbResultaat.Text;
                UsecaseInForm.Uitzondering = tbUItzondering.Text;
                UsecaseInForm.Actors = new List<Actor>();
                
                foreach(object s in clbActors.CheckedItems)
                {
                    foreach(Actor a in Actors)
                    {
                        if(s.ToString() == a.Name)
                        {
                            UsecaseInForm.Actors.Add(a);
                        }
                    }
                }
                gereed1 = true;
                this.Hide();
            }
            else { MessageBox.Show("Vul alle velden in"); }

            



        }
    }
}
