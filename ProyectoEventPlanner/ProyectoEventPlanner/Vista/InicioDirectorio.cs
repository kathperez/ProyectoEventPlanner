using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEventPlanner.Vista
{
    public partial class InicioDirectorio : Form
    {
        public InicioDirectorio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDirectorio agregarDirectorio = new AgregarDirectorio();
            agregarDirectorio.Show();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarDirectorio editarDirectorio = new EditarDirectorio();
            editarDirectorio.Show();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerDirectorio verDirectorio = new VerDirectorio();
            verDirectorio.Show();
        }
    }
}
