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
        List<Actor> selectedActors{ get; set; }

        public UseCaseForm( List<Actor> actors)
        {
            InitializeComponent();
            foreach (Actor a in actors)
            {
                clbActors.Items.Add(a.Name);
            }
            Actors = new List<Actor>();
            Actors.AddRange(actors);
            
        }

        private void btnKlaar_Click(object sender, EventArgs e)
        {
            if (tbNaam != null && tbAanname != null && tbOmschrijving != null && tbResultaat != null && tbSamenvatting != null && tbUItzondering != null) // kijkt of alles is ingevuld
            {
                Naam = tbNaam.Text;
                Samenvatting = tbSamenvatting.Text;
                Aanname = tbAanname.Text;
                Omschrijving = tbOmschrijving.Text;
                Resultaat = tbResultaat.Text;
                Uitzondering = tbUItzondering.Text;

                for (int c = 0; c < clbActors.Items.Count; c++) // loopt door alle checked list box entries
                {
                    if (clbActors.GetItemChecked(c)) //kijkt of het item in de loop is gechecked
                    {
                        foreach (Actor a in Actors) // loopt door alle actors
                        {
                            if (a.Name == clbActors.GetItemChecked(c).ToString()) // als de naam gelijk is wordt de actor toegevoegd
                            {
                                selectedActors.Add(a); // voegt hem toe
                            }
                        }
                    }
                }
            }
            else { MessageBox.Show("Vul alle velden in"); }





        }
    }
}
