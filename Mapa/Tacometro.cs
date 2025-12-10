using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Mapa
{

    public class Tacometro
    {
        /// <summary>
        /// Dibuja un tacómetro en el panel especificado
        /// </summary>
        /// <param name="panel">Panel donde se dibujará el tacómetro</param>
        /// <param name="porcentaje">Porcentaje de la aguja (0-100)</param>
        public static void DibujarTacometro(Panel panel, float porcentaje)
        {
            // Validar porcentaje
            porcentaje = Math.Max(0, Math.Min(100, porcentaje));

            // Crear gráfico del panel
            using (Graphics g = panel.CreateGraphics())
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(panel.BackColor);

                // Dimensiones
                int ancho = panel.Width;
                int alto = panel.Height;
                int centroX = ancho / 2;
                int centroY = alto - 20;
                int radio = Math.Min(ancho, alto * 2) / 2 - 30;

                // Dibujar arco del tacómetro (de 180° a 0°)
                Rectangle rectArco = new Rectangle(centroX - radio, centroY - radio, radio * 2, radio * 2);

                // Arco de fondo
                using (Pen penFondo = new Pen(Color.LightGray, 15))
                {
                    g.DrawArc(penFondo, rectArco, 180, 180);
                }

                // Arco de progreso (verde a rojo según porcentaje)
                float angulo = 180 * (porcentaje / 100f);
                Color colorProgreso = ObtenerColorGradiente(porcentaje);
                using (Pen penProgreso = new Pen(colorProgreso, 15))
                {
                    g.DrawArc(penProgreso, rectArco, 180, angulo);
                }

                // Dibujar marcas de escala
                DibujarMarcas(g, centroX, centroY, radio);

                // Dibujar aguja
                DibujarAguja(g, centroX, centroY, radio - 20, porcentaje);

                // Dibujar centro
                using (SolidBrush brushCentro = new SolidBrush(Color.DarkGray))
                {
                    g.FillEllipse(brushCentro, centroX - 10, centroY - 10, 20, 20);
                }

                // Dibujar texto del porcentaje
                string textoValor = $"{porcentaje:F1}%";
                using (Font font = new Font("Arial", 16, FontStyle.Bold))
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    SizeF tamTexto = g.MeasureString(textoValor, font);
                    g.DrawString(textoValor, font, brush,
                        centroX - tamTexto.Width / 2, centroY + 20);
                }
            }
        }

        /// <summary>
        /// Dibuja las marcas de escala del tacómetro
        /// </summary>
        private static void DibujarMarcas(Graphics g, int centroX, int centroY, int radio)
        {
            using (Pen penMarca = new Pen(Color.White, 2))
            using (Font font = new Font("Arial", 8))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                for (int i = 0; i <= 10; i++)
                {
                    double angulo = Math.PI - (Math.PI * i / 10);

                    // Marca grande cada 10%
                    int longitudMarca = (i % 2 == 0) ? 15 : 8;

                    int x1 = centroX + (int)(radio * Math.Cos(angulo));
                    int y1 = centroY - (int)(radio * Math.Sin(angulo));
                    int x2 = centroX + (int)((radio - longitudMarca) * Math.Cos(angulo));
                    int y2 = centroY - (int)((radio - longitudMarca) * Math.Sin(angulo));

                    g.DrawLine(penMarca, x1, y1, x2, y2);

                    // Dibujar número cada 20%
                    if (i % 2 == 0)
                    {
                        string texto = (i * 10).ToString();
                        int xTexto = centroX + (int)((radio - 30) * Math.Cos(angulo));
                        int yTexto = centroY - (int)((radio - 30) * Math.Sin(angulo));
                        SizeF tamTexto = g.MeasureString(texto, font);
                        g.DrawString(texto, font, brush,
                            xTexto - tamTexto.Width / 2, yTexto - tamTexto.Height / 2);
                    }
                }
            }
        }

        /// <summary>
        /// Dibuja la aguja del tacómetro
        /// </summary>
        private static void DibujarAguja(Graphics g, int centroX, int centroY, int longitud, float porcentaje)
        {
            double angulo = Math.PI - (Math.PI * porcentaje / 100);

            int xPunta = centroX + (int)(longitud * Math.Cos(angulo));
            int yPunta = centroY - (int)(longitud * Math.Sin(angulo));

            using (Pen penAguja = new Pen(Color.Red, 3))
            {
                penAguja.StartCap = LineCap.Round;
                penAguja.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(penAguja, centroX, centroY, xPunta, yPunta);
            }
        }

        /// <summary>
        /// Obtiene un color gradiente de verde a rojo según el porcentaje
        /// </summary>
        private static Color ObtenerColorGradiente(float porcentaje)
        {
            if (porcentaje < 50)
            {
                // Verde a amarillo
                int r = (int)(255 * porcentaje / 50);
                return Color.FromArgb(r, 255, 0);
            }
            else
            {
                // Amarillo a rojo
                int g = (int)(255 * (100 - porcentaje) / 50);
                return Color.FromArgb(255, g, 0);
            }
        }
    }

    // Ejemplo de uso en un Form:
    public partial class FormEjemplo : Form
    {
        private Panel panelTacometro;
        private TrackBar trackBar;
        private Timer timer;

        public FormEjemplo()
        {

            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Panel para el tacómetro
            panelTacometro = new Panel
            {
                Location = new Point(20, 20),
                Size = new Size(400, 250),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            this.Controls.Add(panelTacometro);

            // TrackBar para controlar el valor
            trackBar = new TrackBar
            {
                Location = new Point(20, 280),
                Size = new Size(400, 45),
                Minimum = 0,
                Maximum = 100,
                Value = 50,
                TickFrequency = 10
            };
            trackBar.ValueChanged += (s, e) =>
            {
                Tacometro.DibujarTacometro(panelTacometro, trackBar.Value);
            };
            this.Controls.Add(trackBar);

            // Timer para actualizar el tacómetro al redimensionar
            timer = new Timer { Interval = 100 };
            timer.Tick += (s, e) =>
            {
                Tacometro.DibujarTacometro(panelTacometro, trackBar.Value);
                timer.Stop();
            };

            panelTacometro.Resize += (s, e) =>
            {
                timer.Stop();
                timer.Start();
            };

            // Dibujar inicial
            this.Load += (s, e) =>
            {
                Tacometro.DibujarTacometro(panelTacometro, trackBar.Value);
            };
        }
    }

}
