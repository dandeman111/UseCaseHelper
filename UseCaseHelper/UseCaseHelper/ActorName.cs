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
    public partial class ActorName : Form
    {
        public String ActorNaam {get;set;}
        public Boolean Gereed { get; set; }
    public ActorName()
        {
            InitializeComponent();
            Gereed = false;
        }
    private void btnKlaar_Click(object sender, EventArgs e)
        {
            ActorNaam = tbActorName.Text;
            if(tbActorName.Text.Length > 0)
            {
                Gereed = true;
            }
            this.Close();
        }
    }
}
