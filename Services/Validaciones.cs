using EscuelaForm.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaForm.Services
{
    public static class Validaciones
    {
        public static bool ValidaFormulario(string formName)
        {
            bool encontrado = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    form.Show();
                    encontrado = true;
                }
            }

            return encontrado;
        }

        public static void CambiarEnable(Form form)
        {
            foreach (Control item in form.Controls)
            {
                item.Enabled = true;
            }
        }
    }
}
