using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEventPlanner.Modelo;
using ProyectoEventPlanner.Controlador;
namespace ProyectoEventPlanner.Vista
{
    public partial class AgregarDirectorio : Form
    {
        public AgregarDirectorio()
        {
            InitializeComponent();
            mostrar();
        }

        private void mostrar()
        {
            CDirectorio funcion = new CDirectorio();
            dgDirectorio.DataSource = funcion.Mostrar();
        }
        private void limpiar()
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            cbArea.SelectedIndex=-1;

        }


        private void Directorio_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEmpresa.Text)) {
                MessageBox.Show("Debe ingresar el nombre de la empresa");
                txtNombreEmpresa.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del contacto");
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                MessageBox.Show("Debe ingresar el primer apellido del contacto");
                txtPrimerApellido.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTelPrincipal.Text))
            {
                MessageBox.Show("Debe ingresar el número teléfonico principal del contacto");
                txtTelPrincipal.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbArea.SelectedItem.ToString()))
            {
                MessageBox.Show("Debe seleccionar el tipo de área al que pertenece el contacto");
                cbArea.Focus();
                return;
            }

            MDirectorio directorio = new MDirectorio();
            CDirectorio funcion = new CDirectorio();

            directorio.nombreEmpresa = txtNombreEmpresa.Text;
            directorio.nombre = txtNombre.Text;
            directorio.PrimerApellido = txtPrimerApellido.Text;
            directorio.SegundoApellido = txtSegundoApellido.Text;
            directorio.telPrincipal = txtTelPrincipal.Text;
            directorio.telOpcional = txtTelSecundario.Text;
            directorio.direccion = txtDireccion.Text;
            directorio.paginaWeb = txtPagWeb.Text;
            directorio.area = cbArea.SelectedItem.ToString();
            directorio.comentarios = txtComentarios.Text;
                funcion.agregar(directorio);
                mostrar();
                limpiar();
            

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CDirectorio funcion = new CDirectorio();
            
            dgDirectorio.DataSource = funcion.Buscar(txtBuscar.Text);

        }
    }
}
