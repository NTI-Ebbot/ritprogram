using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ritboken
{
    
    public partial class Form1 : Form
    {
        //Skapa pensel objelt samt sätta valda formen/verktyget till vanlig penna
        private Brush brush = new Brush();
        private int selectedShape = 100; 
        //Deklarerar boolean om ifall former ska vara ifyllda och sätter den till false som startvärde
        private bool filled = false;

        //Skapa ändringshistoriken för undo
        Stack<Bitmap> history = new Stack<Bitmap>();

        // Deklarera en bitmap för att lagra ritområdet
        private Bitmap drawingSurface = new Bitmap(800, 600);
        public Form1()
        {
            InitializeComponent();

            //Färger
            Color c1 = Color.DeepSkyBlue;
            Color c2 = Color.SkyBlue;

            this.BackColor = c1;
            pbxLogo.BackColor = c2;
            grbCurrentTool.BackColor = c2;
            grbShapes.BackColor = c2;
            grbOther.BackColor = c2;

            // Kör metoden för att skapa ett ritområdet genom att rensa det till vit färg
            InitializeDrawingSurface();
        }
            
        

        // Metod för att skapa ett ritområde genom att rensa det till vit färg.
        private void InitializeDrawingSurface()
        {
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                g.Clear(Color.White);
            }
        }



        // Händelsehanterare som aktiveras när användaren klickar ned musknappen för att börja rita.
        private void pxbPaper_MouseDown(object sender, MouseEventArgs e)
        {
            brush.mouseDown(e, pxbPaper, drawingSurface);
        }
        


        // Händelsehanterare som aktiveras när användaren rör musen och ritningen pågår.
        private void pxbPaper_MouseMove(object sender, MouseEventArgs e)
        {
           brush.Draw(nupLineWeigth, pbxCurrentColor.BackColor, drawingSurface, pxbPaper, e, selectedShape, filled);
        }
        


        // Händelsehanterare som aktiveras när användaren släpper musknappen.
        private void pxbPaper_MouseUp(object sender, MouseEventArgs e)
        {
            brush.mouseUp(pxbPaper);
        }
        


        private void pxbPaper_Paint(object sender, PaintEventArgs e)
        {
            // Rita ritområdet på PictureBox
            e.Graphics.DrawImage(drawingSurface, Point.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbxCurrentColor.BackColor = Color.Black; //Sätter svart som standard färg vid start
            
        }


        //Skapar färgdialogen. Är utanför on click funktionen för att spara egna färger.
        ColorDialog colorDialog = new ColorDialog();
        //Sätter penfäegen till användarvald färg från färgdialogen.
        private void pbxCurrentColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                pbxCurrentColor.BackColor = colorDialog.Color;
            }
        }

      
        private void grbShapes_Enter(object sender, EventArgs e)
        {

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            //Sätter valt verktyg till penna
            selectedShape = 100;
            //Visar vilken knapp som är vald. Finns säkert bättre/enklare sätt att göra
            btnLine.BackColor = Color.LightBlue;
            btnRectangle.BackColor = Color.White;
            btnElipse.BackColor = Color.White;

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            //Sätter valt verktyg till rektangel
            selectedShape = 010;

            btnLine.BackColor = Color.White;
            btnRectangle.BackColor = Color.LightBlue;
            btnElipse.BackColor = Color.White;
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            //Sätter valt verktyg till elips
            selectedShape = 001;

            btnLine.BackColor = Color.White;
            btnRectangle.BackColor = Color.White;
            btnElipse.BackColor = Color.LightBlue;
        }

        //Återgår till den senaste sparade ritytan i historiken
        private void btnUndo_Click(object sender, EventArgs e)
        {
            drawingSurface = brush.undo(drawingSurface);
            pxbPaper.Invalidate();
        }

        //Checkbox ifall former ska vara ifyllda
        private void chkFilled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilled.Checked)
            {
                filled = true;
            } else
            {
                filled = false;
            }
        }
    }


    //Deklarerar brush klassen
    //Att förbättra?: Verktyg bestäms när objektet skapas istället för med argument till funktioner
    public class Brush 
   {
        private bool isDrawing = false;     // En flagga som indikerar om användaren är i färd med att rita eller inte.
        private Point previousPoint;        // Håller koll på den tidigare muspositionen för att rita linjer.

        //Skapa ändringshistoriken för undo
        Stack<Bitmap> history = new Stack<Bitmap>();

        //Definerar en bitmap för att visa en preview över vad som kommer målas
        private Bitmap preview;

        public void mouseDown(MouseEventArgs e, PictureBox canvas, Bitmap drawingSurface)
        {
            isDrawing = true;                   // Användaren har börjat rita
            previousPoint = e.Location;         // Sparar positionen där muspekaren befann sig när ritningen påbörjades i previousPoint 
            canvas.Cursor = Cursors.Cross;      // Ändrar muspekaren för att tydligare visa att man målar

            Bitmap temp = new Bitmap(drawingSurface);
            history.Push(temp);

            if (drawingSurface != null)
            {
                preview = (Bitmap)drawingSurface.Clone();
            }

        }

        public void Draw(NumericUpDown nupLineWeigth, Color color, Bitmap drawingSurface, PictureBox pxbPaper, MouseEventArgs e, int selectedShape, bool filled)
        {
            int lineWeigth = (int)nupLineWeigth.Value; //Linjetjocklek
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
             // Skapa en penna med färg och tjocklek
             Pen pen = new Pen(color, lineWeigth);  
            //Skapa en solid pensel med färg för ifyllda former
            SolidBrush solidBrush = new SolidBrush(color);
             if (isDrawing)
             {
                switch (selectedShape)
                    {
                /*          Linje           */
                case 100:


                    // Rita en linje från föregående musposition till nuvarande musposition med pennan
                    g.DrawLine(pen, previousPoint, e.Location);
                    previousPoint = e.Location;

                    // Uppdatera PictureBox för att visa de ändringar som gjorts på 
                    break;

                /*          Rektangel           */
                case 010:

                    //Målar en rektangel samt viasr en preview av rektangeln innan man släpper 
                    if (preview != null)
                    {
                        g.Clear(Color.White);
                        g.DrawImageUnscaled(preview, 0, 0);
                        //Ifyllda rektanglar om filled = true annars icke-ifyllda
                        if (filled == false)
                        {
                            g.DrawRectangle(pen, Math.Min(e.X, previousPoint.X), Math.Min(e.Y, previousPoint.Y), Math.Abs(e.X - previousPoint.X), Math.Abs(e.Y - previousPoint.Y));
                        } else
                        {
                            g.FillRectangle(solidBrush, Math.Min(e.X, previousPoint.X), Math.Min(e.Y, previousPoint.Y), Math.Abs(e.X - previousPoint.X), Math.Abs(e.Y - previousPoint.Y));
                        }
                        
                    }
                    
                    
                    break;


                /*          Elips           */
                case 001:
                    //Målar en elips samt viasr en preview av rektangeln innan man släpper 
                    if (preview != null)
                    {
                        g.Clear(Color.White);
                        g.DrawImageUnscaled(preview, 0, 0);
                        //Ifyllda elipser om filled = true annars icke-ifyllda
                        if (filled == false)
                        {
                            g.DrawEllipse(pen, Math.Min(e.X, previousPoint.X), Math.Min(e.Y, previousPoint.Y), Math.Abs(e.X - previousPoint.X), Math.Abs(e.Y - previousPoint.Y));
                        } else
                        {
                            g.FillEllipse(solidBrush, Math.Min(e.X, previousPoint.X), Math.Min(e.Y, previousPoint.Y), Math.Abs(e.X - previousPoint.X), Math.Abs(e.Y - previousPoint.Y));
                        }
                    }
                    break;
                    }  
                pxbPaper.Invalidate();
                }
            }  
        }
        public void mouseUp(PictureBox canvas)
        {
            isDrawing = false;          // Användaren har slutat rita och släppt musknappen
            canvas.Cursor = Cursors.Default; //Byter tillbaka till default muspekare
        }

        public Bitmap undo(Bitmap drawingSurface)
        {
            //Returnerar den senaste sparade ritytan i historiken ifall det finns någon.
            if (history.Count > 0)
            {
                return history.Pop();
            }
            return drawingSurface;
        }

   }
}