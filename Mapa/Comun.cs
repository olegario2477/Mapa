using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mapa
{
    class Comun
    {


        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.ShowInTaskbar = false;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static string valorBoton(PictureBox control, PaintEventArgs e, string valor, Color numero)
        {

            //using (Font fuente = new Font("Arial", 27, FontStyle.Bold))
            using (Brush pincel = new SolidBrush(numero))
            {
                float emSize = 12;
                Point posicion = new Point(12, 3);

                //switch (valor.Length)
                //{
                //    case 1:
                //        posicion = new Point(18, 12);
                //        break;
                //    case 2:
                //        posicion = new Point(8, 12);
                //        break;
                //    case 3:
                //        posicion = new Point(0, 14);
                //        emSize = 24;
                //        break;
                //    case 4:
                //        posicion = new Point(0, 18);
                //        emSize = 19;
                //        break;
                //    case 5:
                //        posicion = new Point(0, 22);
                //        emSize = 15;
                //        break;
                //    case 6:
                //        posicion = new Point(0, 23);
                //        emSize = 13;
                //        break;

                //}

                Font fuente = new Font("Courier", emSize, FontStyle.Regular);
                e.Graphics.DrawString(valor, fuente, pincel, posicion);
            }

            return valor;

        }



    }
}
