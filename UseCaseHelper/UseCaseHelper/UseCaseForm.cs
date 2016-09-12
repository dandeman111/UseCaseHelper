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
        public String Naam { get; set; }
        public String Samenvatting { get; set; }
        private List<Actor> UsecaseActors { get; set; }
        public String Aanname { get; set; }
        public String Omschrijving { get; set; }
        public String Uitzondering { get; set; }
        public String Resultaat { get; set; }
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
            selectedActors = new List<Actor>();
            Actors = new List<Actor>();
            Actors.AddRange(actors);
            gereed1 = false;
        }

        private void btnKlaar_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text != null && tbAanname.Text != "" && tbOmschrijving.Text != "" && tbResultaat.Text != "" && tbSamenvatting.Text != "" && tbUItzondering.Text != "") // kijkt of alles is ingevuld
            {
                Naam = tbNaam.Text;
                Samenvatting = tbSamenvatting.Text;
                Aanname = tbAanname.Text;
                Omschrijving = tbOmschrijving.Text;
                Resultaat = tbResultaat.Text;
                Uitzondering = tbUItzondering.Text; 
                foreach(String s in clbActors.CheckedItems)
                {
                    foreach(Actor a in Actors)
                    {
                        if(s == a.Name)
                        {
                            selectedActors.Add(a);
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
