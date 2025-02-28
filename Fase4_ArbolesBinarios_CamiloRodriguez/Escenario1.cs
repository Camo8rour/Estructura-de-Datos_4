using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4_ArbolesBinarios_CamiloRodriguez
{
    public partial class Escenario1 : Form
    {
        public Escenario1()
        {
            InitializeComponent();
        }

        private void Escenario1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu men = new menu();
            men.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Esta seguro que desea salir", "Salir De La Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics node;
            node = CreateGraphics();
            node.FillEllipse(Brushes.Blue, 263, 75, 40, 40);
            node.DrawString("70", Font, Brushes.Black, 273, 90);
            Pen linea = new Pen(Color.Red, 2);
            node.DrawLine(linea, 266, 104, 182, 152);

            node.FillEllipse(Brushes.Blue, 148, 146, 40, 40);
            node.DrawString("20", Font, Brushes.Black, 158, 159);
            Pen linea0 = new Pen(Color.Red, 2);
            node.DrawLine(linea0, 302, 102, 404, 154);

            node.FillEllipse(Brushes.Blue, 400, 146, 40, 40);
            node.DrawString("98", Font, Brushes.Black, 410, 159);
            Pen linea1 = new Pen(Color.Red, 2);
            node.DrawLine(linea1, 153, 180, 133, 206);

            node.FillEllipse(Brushes.Blue, 100, 200, 40, 40);
            node.DrawString("15", Font, Brushes.Black, 110, 213);
            Pen linea2 = new Pen(Color.Red, 2);
            node.DrawLine(linea2, 181, 180, 196, 202);

            node.FillEllipse(Brushes.Blue, 186, 200, 40, 40);
            node.DrawString("59", Font, Brushes.Black, 196, 213);
            Pen linea3 = new Pen(Color.Red, 2);
            node.DrawLine(linea3, 406, 180, 390, 205);

            node.FillEllipse(Brushes.Blue, 358, 200, 40, 40);
            node.DrawString("77", Font, Brushes.Black, 368, 213);
            Pen linea4 = new Pen(Color.Red, 2);
            node.DrawLine(linea4, 107, 234, 83, 269);

            node.FillEllipse(Brushes.Blue, 52, 266, 40, 40);
            node.DrawString("10", Font, Brushes.Black, 62, 279);
            Pen linea5 = new Pen(Color.Red, 2);
            node.DrawLine(linea5, 192, 235, 176, 269);

            node.FillEllipse(Brushes.Blue, 148, 266, 40, 40);
            node.DrawString("29", Font, Brushes.Black, 158, 279);
            Pen linea6 = new Pen(Color.Red, 2);
            node.DrawLine(linea6, 221, 234, 245, 266);

            node.FillEllipse(Brushes.Blue, 234, 266, 40, 40);
            node.DrawString("69", Font, Brushes.Black, 244, 279);
            Pen linea7 = new Pen(Color.Red, 2);
            node.DrawLine(linea7, 366, 236, 345, 271);

            node.FillEllipse(Brushes.Blue, 312, 266, 40, 40);
            node.DrawString("75", Font, Brushes.Black, 322, 279);
            Pen linea8 = new Pen(Color.Red, 2);
            node.DrawLine(linea8, 390, 236, 412, 268);

            node.FillEllipse(Brushes.Blue, 400, 266, 40, 40);
            node.DrawString("91", Font, Brushes.Black, 410, 279);
            Pen linea9 = new Pen(Color.Red, 2);
            node.DrawLine(linea9, 60, 302, 36, 336);

            node.FillEllipse(Brushes.Blue, 4, 332, 40, 40);
            node.DrawString("2", Font, Brushes.Black, 14, 345);
            Pen linea10 = new Pen(Color.Red, 2);
            node.DrawLine(linea10, 409, 302, 384, 336);

            node.FillEllipse(Brushes.Blue, 352, 332, 40, 40);
            node.DrawString("78", Font, Brushes.Black, 362, 345);
            Pen linea11 = new Pen(Color.Red, 2);
            node.DrawLine(linea11, 385, 365, 407, 383);

            node.FillEllipse(Brushes.Blue, 400, 378, 40, 40);
            node.DrawString("86", Font, Brushes.Black, 410, 391);
        }

        private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preor;
            preor = CreateGraphics();
            preor.DrawString("PreOrden", Font, Brushes.Blue, 0, 470);

            Pen miPreor = new Pen(Color.Red, 1);
            preor.DrawEllipse(miPreor, 60, 458, 35, 35);
            preor.DrawString("70", Font, Brushes.Black, 70, 470);

            preor.DrawEllipse(miPreor, 100, 458, 35, 35);
            preor.DrawString("20", Font, Brushes.Black, 110, 470);

            preor.DrawEllipse(miPreor, 140, 458, 35, 35);
            preor.DrawString("15", Font, Brushes.Black, 150, 470);

            preor.DrawEllipse(miPreor, 180, 458, 35, 35);
            preor.DrawString("10", Font, Brushes.Black, 190, 470);

            preor.DrawEllipse(miPreor, 220, 458, 35, 35);
            preor.DrawString("2", Font, Brushes.Black, 230, 470);

            preor.DrawEllipse(miPreor, 260, 458, 35, 35);
            preor.DrawString("59", Font, Brushes.Black, 270, 470);

            preor.DrawEllipse(miPreor, 300, 458, 35, 35);
            preor.DrawString("29", Font, Brushes.Black, 310, 470);

            preor.DrawEllipse(miPreor, 340, 458, 35, 35);
            preor.DrawString("69", Font, Brushes.Black, 350, 470);

            preor.DrawEllipse(miPreor, 380, 458, 35, 35);
            preor.DrawString("98", Font, Brushes.Black, 390, 470);

            preor.DrawEllipse(miPreor, 420, 458, 35, 35);
            preor.DrawString("77", Font, Brushes.Black, 430, 470);

            preor.DrawEllipse(miPreor, 460, 458, 35, 35);
            preor.DrawString("75", Font, Brushes.Black, 470, 470);

            preor.DrawEllipse(miPreor, 500, 458, 35, 35);
            preor.DrawString("91", Font, Brushes.Black, 510, 470);

            preor.DrawEllipse(miPreor, 540, 458, 35, 35);
            preor.DrawString("78", Font, Brushes.Black, 550, 470);

            preor.DrawEllipse(miPreor, 580, 458, 35, 35);
            preor.DrawString("86", Font, Brushes.Black, 590, 470);
        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics inor;
            inor = CreateGraphics();
            inor.DrawString("InOrden", Font, Brushes.Blue, 0, 518);

            Pen miInor = new Pen(Color.Red, 1);
            inor.DrawEllipse(miInor, 60, 505, 35, 35);
            inor.DrawString("2", Font, Brushes.Black, 73, 518);

            inor.DrawEllipse(miInor, 100, 505, 35, 35);
            inor.DrawString("10", Font, Brushes.Black, 110, 517);

            inor.DrawEllipse(miInor, 140, 505, 35, 35);
            inor.DrawString("15", Font, Brushes.Black, 150, 517);

            inor.DrawEllipse(miInor, 180, 505, 35, 35);
            inor.DrawString("20", Font, Brushes.Black, 190, 517);

            inor.DrawEllipse(miInor, 220, 505, 35, 35);
            inor.DrawString("29", Font, Brushes.Black, 230, 517);

            inor.DrawEllipse(miInor, 260, 505, 35, 35);
            inor.DrawString("59", Font, Brushes.Black, 270, 517);

            inor.DrawEllipse(miInor, 300, 505, 35, 35);
            inor.DrawString("69", Font, Brushes.Black, 310, 517);

            inor.DrawEllipse(miInor, 340, 505, 35, 35);
            inor.DrawString("70", Font, Brushes.Black, 350, 517);

            inor.DrawEllipse(miInor, 380, 505, 35, 35);
            inor.DrawString("75", Font, Brushes.Black, 390, 517);

            inor.DrawEllipse(miInor, 420, 505, 35, 35);
            inor.DrawString("77", Font, Brushes.Black, 430, 517);

            inor.DrawEllipse(miInor, 460, 505, 35, 35);
            inor.DrawString("78", Font, Brushes.Black, 470, 517);

            inor.DrawEllipse(miInor, 500, 505, 35, 35);
            inor.DrawString("86", Font, Brushes.Black, 510, 517);

            inor.DrawEllipse(miInor, 540, 505, 35, 35);
            inor.DrawString("91", Font, Brushes.Black, 550, 517);

            inor.DrawEllipse(miInor, 580, 505, 35, 35);
            inor.DrawString("98", Font, Brushes.Black, 590, 517);
        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics postor;
            postor = CreateGraphics();
            postor.DrawString("PostOrden", Font, Brushes.Blue, 0, 566);

            Pen miPostor = new Pen(Color.Red, 1);
            postor.DrawEllipse(miPostor, 60, 554, 35, 35);
            postor.DrawString("2", Font, Brushes.Black, 73, 566);

            postor.DrawEllipse(miPostor, 100, 554, 35, 35);
            postor.DrawString("10", Font, Brushes.Black, 110, 566);

            postor.DrawEllipse(miPostor, 140, 554, 35, 35);
            postor.DrawString("15", Font, Brushes.Black, 150, 566);

            postor.DrawEllipse(miPostor, 180, 554, 35, 35);
            postor.DrawString("29", Font, Brushes.Black, 190, 566);

            postor.DrawEllipse(miPostor, 220, 554, 35, 35);
            postor.DrawString("69", Font, Brushes.Black, 230, 566);

            postor.DrawEllipse(miPostor, 260, 554, 35, 35);
            postor.DrawString("59", Font, Brushes.Black, 270, 566);

            postor.DrawEllipse(miPostor, 300, 554, 35, 35);
            postor.DrawString("20", Font, Brushes.Black, 310, 566);

            postor.DrawEllipse(miPostor, 340, 554, 35, 35);
            postor.DrawString("75", Font, Brushes.Black, 350, 566);

            postor.DrawEllipse(miPostor, 380, 554, 35, 35);
            postor.DrawString("86", Font, Brushes.Black, 390, 566);

            postor.DrawEllipse(miPostor, 420, 554, 35, 35);
            postor.DrawString("78", Font, Brushes.Black, 430, 566);

            postor.DrawEllipse(miPostor, 460, 554, 35, 35);
            postor.DrawString("91", Font, Brushes.Black, 470, 566);

            postor.DrawEllipse(miPostor, 500, 554, 35, 35);
            postor.DrawString("77", Font, Brushes.Black, 510, 566);

            postor.DrawEllipse(miPostor, 540, 554, 35, 35);
            postor.DrawString("98", Font, Brushes.Black, 550, 566);

            postor.DrawEllipse(miPostor, 580, 554, 35, 35);
            postor.DrawString("70", Font, Brushes.Black, 590, 566);
        }
    }
}
