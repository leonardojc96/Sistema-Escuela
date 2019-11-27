using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EscuelaForm.Negocios
{
    class InicioNegocio
    {
        public void CambiarBotonMasInfo(DataGridView dt)
        {
            foreach (DataGridViewRow item in dt.Rows)
            {
                item.Cells[4].Value = "Mas Info";
            }
        }
    }
}
