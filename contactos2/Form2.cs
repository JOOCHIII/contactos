using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static contactos2.Form1;

namespace contactos2
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text.Trim();
            string name = textBox3.Text.Trim(); // Obtener el nombre desde el nuevo TextBox

            // Validar si se introdujo un teléfono o un nombre
            if (string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono o un nombre para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si se proporcionó un teléfono, buscar por teléfono
            if (!string.IsNullOrEmpty(phone))
            {
                if (!checkPhone(phone))
                {
                    MessageBox.Show("Por favor, introduce un número de teléfono válido (11 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ListaContactos.Contact contact = ListaContactos.listaContactos.Find(c => c.Phone == phone);

                if (contact != null)
                {
                    textBox2.Text = $"Nombre: {contact.Name}\r\nTeléfono: {contact.Phone}";
                }
                else
                {
                    textBox2.Text = "No se encontró ningún contacto con ese número.";
                }
            }

            // Si se proporcionó un nombre, buscar por nombre
            else if (!string.IsNullOrEmpty(name))
            {
                ListaContactos.Contact contact = ListaContactos.listaContactos
                    .FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

                if (contact != null)
                {
                    textBox2.Text = $"Nombre: {contact.Name}\r\nTeléfono: {contact.Phone}";
                }
                else
                {
                    textBox2.Text = "No se encontró ningún contacto con ese nombre.";
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            if (phone.Length != 11)
                return false;

            foreach (char c in phone)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

