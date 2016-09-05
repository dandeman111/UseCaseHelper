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
        List<Actor> actors;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            actors = new List<Actor>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        private void DrawPoppetje(int x, int y)
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

            
        }
        


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
        int klik = 0;
        Point p1 = new Point();
        Point p2 = new Point();
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (rbActor.Checked)// als de actor methode aan staat
            {
               actors.Add( new Actor("bob" ,me.X, me.Y ));
                DrawPoppetje(me.X,me.Y);
                
            }
           

            if (rbLine.Checked) // lijn mode
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
            if(rbSelect.Checked)
            {
                foreach(Actor a in actors)
                {
                    if(me.X > a.X && me.X < a.X+ a.Width) // goede x as is geslecteerd
                    {
                        if(me.Y > a.Y && me.Y < a.Y + Height)
                        {
                            Console.WriteLine("er is een actor geselecteerd");
                        }
                    }
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
