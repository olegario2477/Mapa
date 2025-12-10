using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa
{

    public class ProgressStackBar : Panel
    {
        private List<ProgressSegment> segments = new List<ProgressSegment>();
        private int BAR_HEIGHT;
        private const int MARGIN = 1;

        public class ProgressSegment
        {

            public string Label { get; set; }
            public double Value { get; set; }
            public Color Color { get; set; }

            public ProgressSegment(string label, double value, Color color)
            {
                Label = label;
                Value = value;
                Color = color;
            }
        }

        public void SetAltura(int bar_height)
        {
            BAR_HEIGHT = bar_height;
        }

        public ProgressStackBar()
        {
            this.DoubleBuffered = true;
            this.Height = BAR_HEIGHT + (MARGIN * 2);
            this.Paint += ProgressStackBar_Paint;
        }

        public void AddSegment(string label, double value, Color color)
        {
            segments.Add(new ProgressSegment(label, value, color));
            this.Invalidate();
        }

        public void ClearSegments()
        {
            segments.Clear();
            this.Invalidate();
        }

        public void SetSegments(List<ProgressSegment> newSegments)
        {
            segments = new List<ProgressSegment>(newSegments);
            this.Invalidate();
        }

        private void ProgressStackBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Calcular el total
            double total = 0;
            foreach (var segment in segments)
            {
                total += segment.Value;
            }

            if (total == 0) return;

            int barWidth = this.Width - (MARGIN * 2);
            float currentX = MARGIN;

            // Dibujar cada segmento horizontalmente
            foreach (var segment in segments)
            {
                float segmentWidth = (float)((segment.Value / total) * barWidth);

                if (segmentWidth > 1)
                {
                    // Dibujar segmento con bordes redondeados en los extremos
                    RectangleF segmentRect = new RectangleF(currentX, MARGIN,
                        segmentWidth, BAR_HEIGHT);

                    using (SolidBrush brush = new SolidBrush(segment.Color))
                    {
                        g.FillRectangle(brush, segmentRect);
                    }

                    // Borde entre segmentos
                    using (Pen pen = new Pen(Color.Transparent, 0))
                    {
                        if (currentX > MARGIN)
                        {
                            g.DrawLine(pen, currentX, MARGIN, currentX, MARGIN + BAR_HEIGHT);
                        }
                    }

                    // Dibujar texto si hay espacio suficiente
                    if (segmentWidth > 90)
                    {
                        double percentage = (segment.Value / total) * 100;
                        string text = $"{segment.Label}\n{percentage:F1}%";

                        using (Font font = new Font("Courier", 10, FontStyle.Regular))
                        {
                            SizeF textSize = g.MeasureString(text, font);
                            PointF textPos = new PointF(
                                currentX + (segmentWidth - textSize.Width) / 2,
                                MARGIN + (BAR_HEIGHT - textSize.Height) / 2
                            );

                            // Sombra del texto para mejor legibilidad
                            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                            {
                                g.DrawString(text, font, shadowBrush,
                                    textPos.X + 1, textPos.Y + 1);
                            }
                            g.DrawString(text, font, Brushes.Black, textPos);
                        }
                    }
                    else //if (segmentWidth > 0)
                    {
                        // Solo mostrar porcentaje si el espacio es limitado
                        double percentage = (segment.Value / total) * 100;
                        string text = $"{segment.Label}\n{percentage:F1}%";

                        using (Font font = new Font("Courier", 9, FontStyle.Bold))
                        {
                            SizeF textSize = g.MeasureString(text, font);
                            PointF textPos = new PointF(
                                currentX + (segmentWidth - textSize.Width) / 2,
                                MARGIN + (BAR_HEIGHT - textSize.Height) / 2
                            );
                            g.DrawString(text, font, Brushes.Black, textPos);
                        }
                    }

                    currentX += segmentWidth;
                }
            }

            // Dibujar borde exterior
            Rectangle containerRect = new Rectangle(MARGIN, MARGIN,
                this.Width - (MARGIN * 2), BAR_HEIGHT);
            using (Pen borderPen = new Pen(Color.WhiteSmoke, 1))
            {
                g.DrawRectangle(borderPen, containerRect);
            }
        }
    }

}
