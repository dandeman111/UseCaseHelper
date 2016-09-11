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

                for (int c = 0; c < clbActors.Items.Count; c++) // loopt door alle checked list box entries
                {
                    foreach(Actor a in Actors)
                    {
                        if(clbActors.Items[c].ToString() == a.Name)
                        {
                            selectedActors.Add(a);
                        }
                    }


                    /*if (clbActors.GetItemChecked(c)) //kijkt of het item in de loop is gechecked
                    {
                        foreach (Actor a in Actors) // loopt door alle actors
                        {
                            for(int f =0; c< clbActors.SelectedItems.Count; c++)
                            {
                                if(a.Name == clbActors.Items[f].ToString())
                                {
                                    if (a != null)
                                    {
                                        selectedActors.Add(a); // voegt hem toe
                                    }
                                }
                            }
                            
                        }
                    }*/
                }
                gereed1 = true;
                this.Hide();
            }
            else { MessageBox.Show("Vul alle velden in"); }

            



        }
    }
}
