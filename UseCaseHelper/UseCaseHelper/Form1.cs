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
    public partial class Form1 : Form
    {
        Graphics g;
        public List<Actor> actors;
        List<UseCase> useCases;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics(); //maakt graphics
            actors = new List<Actor>(); //maakt een lijst met actoren
            useCases = new List<UseCase>();
        }

        private void groupBox1_Enter(object sender, EventArgs e) //random groupbox
        {

        }

       
        private void DrawPoppetje(int x, int y, String naam) //functie om een poppetje te tekenen
        {
            
            Pen p = new Pen(Color.Black);
            p.Width = 2;
            
            Point p1 = new Point(30 + x, 42 + y);  // lichaam boven
            Point p2 = new Point(30 + x, 80 + y); //lichaam onder
            Point p3 = new Point(10 + x, 100 + y); //linker voet
            Point p4 = new Point(50 + x, 100 + y); // rechter voet
            Point p5 = new Point(10 + x, 55 + y); // linker hand
            Point p6 = new Point(50 + x, 55 + y); //rechter hand
            g.DrawLine(p, p1, p2); // teken romp
            g.DrawLine(p, p2, p3); // teken linker been
            g.DrawLine(p, p2, p4); // teken rechter been
            g.DrawLine(p, p1, p5); // linker arm
            g.DrawLine(p, p1, p6); // rechter arm

            g.DrawEllipse(p, 15 + x,10 + y, 30,30); //hoofd tekenen


            //naam invoeren
            g.DrawString(naam, DefaultFont, Brushes.Black, 10 + x, 100 + y);


        }
        private void DrawUsecase(int x, int y, String naam , List<Actor> actors)
        {
            Pen p = new Pen(Color.Black);
            p.Width = 2;
            Point p1 = new Point(x +20 , y+25);
            
            g.DrawEllipse(p, 15 + x, 10 + y,  100, 30 );
            g.DrawString(naam, DefaultFont, Brushes.Black, 27 + x , 17 + y);
            Point p2 = new Point();

         foreach(Actor a in actors)
            {
                Console.WriteLine(a.Name);
                p2.X = a.X + 50;
                p2.Y = a.Y + 55;
                g.DrawLine(p, p1, p2);
            }

            



        }
        


        private void pictureBox1_Paint(object sender, PaintEventArgs e) //nutteloos event
        {

        }
        int klik = 0; //variabelen voor muiskliks
        Point p1 = new Point();
        Point p2 = new Point();
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (rbActor.Checked)// als de actor methode aan staat
            {
                ActorName an = new ActorName(); //maakt een form voor actor naam
                Boolean gereed2 = true; //boolean voor locatie van actor
                foreach (Actor a in actors) // gaat alle actors na
                {
                    if (me.X > a.X && me.X < a.X + a.Width) // goede x as is geslecteerd
                    {
                        if (me.Y > a.Y && me.Y < a.Y + a.Height) // goede y as is geselecteerd
                        {
                            MessageBox.Show("er staat al een actor");
                            gereed2 = false; // kan geen actor geplaats worden
                        }
                    }
                }
                
                    an.ShowDialog(); // opent het form
                if (an.Gereed == true && gereed2 == true) //kijkt naar het variabel in het form om te kijken of hij geplaats kan worden
                {
                    actors.Add(new Actor(an.ActorNaam, me.X, me.Y)); // voegt een actor toe aan de lijst
                    DrawPoppetje(me.X, me.Y, an.ActorNaam); // tekent de actor
                }
                    
                
                


            }
           

            if (rbLine.Checked) // lijn mode, maar die gaat mischien weg
            {
                
                if (klik == 1)
                {

                    klik = 0;
                    p2 = me.Location;
                    Graphics g = pictureBox1.CreateGraphics();
                    Pen p = new Pen(Color.Black);
                    p.Width = 2;
                    g.DrawLine(p, p1, p2);

                } else if (klik == 0)
                {
                    p1 = me.Location;
                    klik = 1;

                }   
            }
            if(rbSelect.Checked) // select mode
            {
                foreach(Actor a in actors)
                {
                    if(me.X > a.X & me.X < a.X+ a.Width) // goede x as is geslecteerd
                    {
                        if(me.Y > a.Y & me.Y < a.Y + a.Height)
                        {
                            Console.WriteLine(a.Name);

                        }
                    }
                }

            }
            if(rbUseCase.Checked) // use case mode
            {
                bool gereed2 = true;
                UseCaseForm uf = new UseCaseForm(actors);
                
                uf.ShowDialog();
            
                if(gereed2 == true&& uf.gereed1 == true)
                {
                    
                    useCases.Add(new UseCase(uf.Naam, uf.Samenvatting, uf.selectedActors, uf.Omschrijving, uf.Uitzondering, uf.Resultaat, me.X, me.Y));
                    DrawUsecase(me.X, me.Y, uf.Naam,uf.selectedActors);
                }

                


            }
        }

        private void btnClear_Click(object sender, EventArgs e) //clear knop
        {
            actors.Clear(); // maakt de lijst van actors leeg
            g.Clear(Color.White); // maakt het canvas leeg
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
