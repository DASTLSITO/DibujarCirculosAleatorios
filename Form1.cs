using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace P222310540TM
{
    public partial class Form1 : Form
    {
        int centroX = 0;
        int centroY = 0;
        bool cancelar = false;
        int radioGrande = 240;
        Graphics g;
        Pen color;

        byte circulos = 0;

        double angulo = 0;

        int vecesLlamado = 0;

        public Form1()
        {
            InitializeComponent();
            centroX = panel1.Width / 2;
            centroY = panel1.Height / 2;
            color = new Pen(Color.FromArgb(0, 0, 0));
            g = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PintarCirculoPadre();
        }

        protected async Task PintarCirculoPadre()
        {
            g.Clear(Color.FromArgb(252, 224, 155));
            g.DrawEllipse(color, centroX - radioGrande, centroY - radioGrande, radioGrande * 2, radioGrande * 2);

            circulos = Convert.ToByte(numericUpDown1.Value);
            vecesLlamado = Convert.ToInt32(numericUpDown2.Value);

            angulo = Math.PI * 2 / circulos;
            cancelar = false;
            await PintarCirculosHijos(radioGrande, centroX, centroY, vecesLlamado);
            button1.Enabled = true;
        }

        public async Task PintarCirculosHijos(float radioGrande, float centroX, float centroY, int nivel)
        {
            button1.Enabled = false;
            if (nivel == 0)
                return;

            float hipotenusa = 0;
            float radioChiquito = 0;

            PointF[] puntos = new PointF[circulos];

            radioChiquito = (float)(radioGrande * Math.Sin(angulo / 2) / (Math.Sin(angulo / 2) + 1));
            hipotenusa = (float)(radioChiquito / Math.Sin(angulo / 2));

            for (int i = 0; i < circulos; i++)
            {
                if (!cancelar)
                {
                    puntos[i] = new PointF((float)(centroX + hipotenusa * Math.Cos(Math.PI + angulo * i)), (float)(centroY + hipotenusa * Math.Sin(Math.PI + angulo * i)));
                    g.DrawEllipse(color, puntos[i].X - radioChiquito, puntos[i].Y - radioChiquito, radioChiquito * 2, radioChiquito * 2);
                    await Task.Delay(16);
                    await PintarCirculosHijos(radioChiquito, puntos[i].X, puntos[i].Y, nivel - 1);
                }
            }
        }

        public void CancelarDibujos()
        {
            button1.Enabled = true;
            cancelar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CancelarDibujos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color.Color = colorDialog.Color;
            }
        }
    }
}