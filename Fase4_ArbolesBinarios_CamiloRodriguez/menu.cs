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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bEs1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Escenario1 es1 = new Escenario1();
            es1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Escenario2 es2 = new Escenario2();
            es2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Esta seguro que desea salir", "Salir De La Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
