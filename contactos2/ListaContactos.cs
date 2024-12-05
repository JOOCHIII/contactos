using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactos2
{
    public static class ListaContactos
    {
        // Lista de contactos compartida entre todos los formularios
        public static List<Contact> listaContactos { get; set; } = new List<Contact>();

        // Clase Contact que define la estructura del contacto
        public class Contact
        {
            public string Name { get; set; }
            public string Phone { get; set; }
        }
    }
}
