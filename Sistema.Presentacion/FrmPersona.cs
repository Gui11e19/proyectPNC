using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dgvListado.DataSource = Npersona.Listar();
                lblTotal.Text = "Total registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        

        private void Formato()
        {
            
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            errorIcono.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if(txtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre");
                }
                else
                {
                    Rpta = Npersona.Insertar(txtNombre.Text, txtApellidos.Text, txtTelefono.Text, int.Parse(txtEdad.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se inserto de forma correcta el registro.");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

    }
}
