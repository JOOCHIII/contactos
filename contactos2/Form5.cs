using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static contactos2.ListaContactos;

namespace contactos2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameToDelete = textBox1.Text.Trim(); // Nombre del contacto a eliminar
            string phoneToDelete = textBox2.Text.Trim(); // Número de teléfono del contacto a eliminar

            // Verificar si ambos campos están vacíos
            if (string.IsNullOrEmpty(nameToDelete) && string.IsNullOrEmpty(phoneToDelete))
            {
                MessageBox.Show("Por favor, ingresa el nombre o el número de teléfono del contacto que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el contacto por nombre si el campo de nombre no está vacío
            if (!string.IsNullOrEmpty(nameToDelete))
            {
                Contact contactByName = ListaContactos.listaContactos.FirstOrDefault(c => c.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));
                if (contactByName != null)
                {
                    // Si el contacto por nombre se encuentra, eliminarlo
                    ListaContactos.listaContactos.Remove(contactByName);
                    MessageBox.Show("Contacto eliminado correctamente por nombre.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear(); // Limpiar el campo de nombre
                }
                else
                {
                    MessageBox.Show("No se encontró ningún contacto con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Buscar el contacto por teléfono si el campo de teléfono no está vacío
            else if (!string.IsNullOrEmpty(phoneToDelete))
            {
                Contact contactByPhone = ListaContactos.listaContactos.FirstOrDefault(c => c.Phone == phoneToDelete);
                if (contactByPhone != null)
                {
                    // Si el contacto por teléfono se encuentra, eliminarlo
                    ListaContactos.listaContactos.Remove(contactByPhone);
                    MessageBox.Show("Contacto eliminado correctamente por teléfono.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Clear(); // Limpiar el campo de teléfono
                }
                else
                {
                    MessageBox.Show("No se encontró ningún contacto con ese número de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
