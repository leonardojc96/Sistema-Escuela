using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscuelaForm.Vistas;
using EscuelaForm.Services;
using EscuelaForm.Negocios;
using EscuelaForm.Modelo;

namespace EscuelaForm
{
    public partial class frmInicio : Form
    {
        InicioNegocio inicioNegocio = new InicioNegocio();
        GruposNegocio gruposNegocio = new GruposNegocio();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCrearGrupo_Click_1(object sender, EventArgs e)
        {

            if (!Validaciones.ValidaFormulario("frmCrearGrupo"))
            {
                frmCrearGrupo frm = new frmCrearGrupo();
                frm.Show();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

            inicioNegocio.CambiarBotonMasInfo(dtgvAlumnos);
            inicioNegocio.CambiarBotonMasInfo(dtgvGrupos);
            inicioNegocio.CambiarBotonMasInfo(dtgvProfesores);
        }

        private void dtgvGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn 
                && e.RowIndex >= 0)
            {
                if (!Validaciones.ValidaFormulario("frmModificar"))
                {
                    string nombre = senderGrid.CurrentRow.Cells["Nombre"].Value.ToString();
                    Grupos grupos = gruposNegocio.Get(nombre);
                    frmModificar frm = new frmModificar(grupos);
                    frm.Show();
                }
            }
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidaFormulario("frmAulas"))
            {
                frmAulas frm = new frmAulas();
                frm.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
