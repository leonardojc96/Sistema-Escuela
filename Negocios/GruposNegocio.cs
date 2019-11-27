using EscuelaForm.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaForm.Negocios
{
    public class GruposNegocio
    {
        public Grupos Get (string nombre)
        {
            using (NuevaEscuelaEntities db = new NuevaEscuelaEntities())
            {
                return db.Grupos.Where(x => x.nombre == nombre).FirstOrDefault();
            }
        }

        public ICollection<Grupos> Search(string nombre)
        {
            using (NuevaEscuelaEntities db = new NuevaEscuelaEntities())
            {
                return db.Grupos.Where(x => x.nombre.Contains(nombre)).ToList();
            }
        }
    }
}
