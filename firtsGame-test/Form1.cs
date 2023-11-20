using System.Numerics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firtsGame_test
{
    public partial class Form1 : Form
    {
        int contadorMovimientos = 1;
        bool volarArriba = false;
        int distancia = 0;
        Random posicionRandom = new Random();
        private List<Image> frames = new List<Image>();
        private int frameActual = 0;
        private float velocidadSalto = 0f;
        private float gravedad = 0.3f;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            iniciarJuego();
            CargarFrames();
        }
        public void iniciarJuego()
        {
            Player.Location = new Point(19, 255);
            distancia = posicionRandom.Next(-160, 118);
            TuboArriba.Location = new Point(270, -173 - distancia);
            TuboAbajo.Location = new Point(270, 319 - distancia);
            Puntaje.Text = "0";


        }
        private void CargarFrames()
        {
            int numeroDeFrames = 7;

            for (int i = 1; i <= numeroDeFrames; i++)
            {
                frames.Add(item: (Image)Properties.Resources.ResourceManager.GetObject($"fr{i}"));
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("timer1_Tick ejecutado");
            int cantMovimientos = 5;
            if (contadorMovimientos <= cantMovimientos)
            {
                Player.Image = frames[frameActual];
                contadorMovimientos++;
            }
            if ((contadorMovimientos > cantMovimientos / 2) && (contadorMovimientos <= cantMovimientos * 2))
            {
                contadorMovimientos++;
            }
            contadorMovimientos = (contadorMovimientos > cantMovimientos * 2) ? 0 : contadorMovimientos;

            int ly = Player.Location.Y;
            int lx = Player.Location.X;


            if (volarArriba)
            {

                velocidadSalto = -6f;
                volarArriba = false;
            }
            else
            {
                velocidadSalto += gravedad;
            }

            ly = (int)(ly + velocidadSalto);

            Player.Location = new Point(Player.Location.X, ly);

            if ((Player.Bounds.IntersectsWith(Barra.Bounds)) || (Player.Bounds.IntersectsWith(TuboAbajo.Bounds)) || (Player.Bounds.IntersectsWith(TuboArriba.Bounds)))
            {
                iniciarJuego();
            }

            if (Math.Abs(TuboArriba.Location.X - Player.Location.X) < 2)
            {
                Console.WriteLine("Puntaje incrementado"); 
                this.Invoke((MethodInvoker)delegate
                {
                    Puntaje.Text = (Convert.ToInt32(Puntaje.Text) + 1).ToString();
                });
            }
            frameActual = (frameActual + 1) % frames.Count;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                volarArriba = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TuboAbajo.Location.X > -140)
            {
                TuboAbajo.Location = new Point((TuboAbajo.Location.X) - 2, TuboAbajo.Location.Y);
                TuboArriba.Location = new Point((TuboArriba.Location.X) - 2, TuboArriba.Location.Y);
            }
            else
            {
                distancia = posicionRandom.Next(-170, 118);
                int nuevaDistancia = posicionRandom.Next(-170, 118);
                TuboAbajo.Location = new Point(400, 319 + nuevaDistancia);
                TuboArriba.Location = new Point(400, -173 + nuevaDistancia);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Barra.Location = (Barra.Location.X > -480) ? new Point((Barra.Location.X) - 1, Barra.Location.Y) : Barra.Location = new Point(-9, Barra.Location.Y);
        }
    }
}