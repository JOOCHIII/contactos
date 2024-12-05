using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static contactos2.Form2;

namespace contactos2
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();

            // Validar que el nombre no esté vacío
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el teléfono: debe ser un número de 11 dígitos
            if (!checkPhone(phone))
            {
                MessageBox.Show("Por favor, introduce un número de teléfono válido (11 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el contacto ya existe en la lista por número de teléfono
            if (ListaContactos.listaContactos.Any(c => c.Phone == phone))
            {
                MessageBox.Show("El número de teléfono ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar el nuevo contacto a la lista
            ListaContactos.listaContactos.Add(new ListaContactos.Contact { Name = name, Phone = phone });

            // Mostrar mensaje de éxito
            MessageBox.Show("Contacto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos de texto
            textBox1.Clear();
            textBox2.Clear();
            this.Close();
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



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
