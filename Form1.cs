using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace P222310540TM
{
    public partial class Form1 : Form
    {
        int centroX = 0;
        int centroY = 0;
        Graphics g;

        byte circulos = 0;

        double angulo = 0;

        int vecesLlamado = 0;

        public Form1()
        {
            InitializeComponent();
            centroX = panel1.Width / 2;
            centroY = panel1.Height / 2;

            g = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PintarCirculoPadre();
        }

        protected void PintarCirculoPadre()
        {
            g.Clear(Color.FromArgb(252, 224, 155));

            int radioGrande = 240;
            g.DrawEllipse(Pens.Black, centroX - radioGrande, centroY - radioGrande, radioGrande * 2, radioGrande * 2);

            circulos = Convert.ToByte(numericUpDown1.Value);
            vecesLlamado = Convert.ToInt32(numericUpDown2.Value);

            angulo = Math.PI * 2 / circulos;
            PintarCirculosHijosMasChingona(radioGrande, centroX, centroY, vecesLlamado);
        }

        public void PintarCirculosHijos(float radioGrande, float centroX, float centroY, int nivel)
        {
            //Acaba el metodo si ya no hay veces
            if (nivel != 0)
            {
                float hipotenusa = 0;
                float radioChiquito = 0;
                float cateto = 0;

                float punto1x = 0;
                float punto2x = 0;
                float punto3x = 0;

                float punto1y = 0;
                float punto2y = 0;
                float punto3y = 0;

                radioChiquito = (float)(radioGrande * Math.Sin((Math.PI) / 3) / (Math.Sin((Math.PI) / 3) + 1));
                hipotenusa = (float)(radioChiquito / Math.Sin((Math.PI) / 3));
                cateto = (float)((radioGrande * Math.Cos((Math.PI) / 3)) / (Math.Sin((Math.PI) / 3) + 1));

                punto1x = centroX - radioChiquito;
                punto1y = centroY - cateto;

                punto2x = centroX + radioChiquito;
                punto2y = centroY - cateto;

                punto3x = centroX;
                punto3y = centroY + hipotenusa;

                g.DrawEllipse(Pens.Black, punto1x - radioChiquito, punto1y - radioChiquito, radioChiquito * 2, radioChiquito * 2);
                g.DrawEllipse(Pens.Black, punto2x - radioChiquito, punto2y - radioChiquito, radioChiquito * 2, radioChiquito * 2);
                g.DrawEllipse(Pens.Black, punto3x - radioChiquito, punto3y - radioChiquito, radioChiquito * 2, radioChiquito * 2);

                PintarCirculosHijos(radioChiquito, punto1x, punto1y, nivel - 1);
                PintarCirculosHijos(radioChiquito, punto2x, punto2y, nivel - 1);
                PintarCirculosHijos(radioChiquito, punto3x, punto3y, nivel - 1);
            }
        }

        public void PintarCirculosHijosMasChingona(float radioGrande, float centroX, float centroY, int nivel)
        {
            if (nivel == 0)
                return;

            float hipotenusa = 0;
            float radioChiquito = 0;

            PointF[] puntos = new PointF[circulos];

            radioChiquito = (float)(radioGrande * Math.Sin(angulo / 2) / (Math.Sin(angulo / 2) + 1));
            hipotenusa = (float)(radioChiquito / Math.Sin(angulo / 2));

            for (int i = 0; i < circulos; i++)
            {
                puntos[i] = new PointF((float)(centroX + hipotenusa * Math.Cos(Math.PI + angulo * i)), (float)(centroY + hipotenusa * Math.Sin(Math.PI + angulo * i)));
                g.DrawEllipse(Pens.Black, puntos[i].X - radioChiquito, puntos[i].Y - radioChiquito, radioChiquito * 2, radioChiquito * 2);
                PintarCirculosHijosMasChingona(radioChiquito, puntos[i].X, puntos[i].Y, nivel - 1);
            }
        }
    }
}