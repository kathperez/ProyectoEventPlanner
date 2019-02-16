using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEventPlanner.Controlador;

namespace ProyectoEventPlanner.Vista
{
    public partial class VerDirectorio : Form
    {
        public VerDirectorio()
        {
            InitializeComponent();
            mostrar();
        }
        private void mostrar()
        {
            CDirectorio funcion = new CDirectorio();
            dgDirectorio.DataSource = funcion.Mostrar();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CDirectorio funcion = new CDirectorio();

            dgDirectorio.DataSource = funcion.Buscar(txtBuscar.Text);
        }
    }
}
