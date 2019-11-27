using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscuelaForm.Services;
using EscuelaForm.Modelo;

namespace EscuelaForm.Vistas
{
    public partial class frmModificar : Form
    {

        public frmModificar(Grupos grupos)
        {
            txtNombre.Text = grupos.nombre;
            cbProfesor.SelectedItem = grupos.Profesores;
            dtpFechaInicio.Value = grupos.fecha_inicio.Value;
            dtpFechaFin.Value = grupos.fecha_fin.Value;
            cbLugar.SelectedItem = grupos.lugar;
            txtMaxAlumnos.Text = grupos.maximo_alumnos.ToString();
            rtxtNotas.Text = grupos.notas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            Validaciones.CambiarEnable(this);
        }
    }
}
