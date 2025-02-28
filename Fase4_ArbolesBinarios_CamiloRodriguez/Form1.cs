using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fase4_ArbolesBinarios_CamiloRodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegi_Click(object sender, EventArgs e)
        {
            if (textBoxContra.Text != "")
            {

                if (textBoxContra.Text == "unad")
                {
                    this.Hide();
                    menu men = new menu();
                    men.ShowDialog();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                    textBoxContra.Text = "";
                    textBoxContra.Focus();
                }

            }
            else
            {
                MessageBox.Show("Por favor digite la contraseña");
                textBoxContra.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
