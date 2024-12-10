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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace contactos2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPhone = textBox1.Text.Trim();  
            string newPhone = textBox2.Text.Trim();  
            string newName = textBox3.Text.Trim();   
            string oldName = textBox4.Text.Trim();   

            if (string.IsNullOrEmpty(oldPhone) || string.IsNullOrEmpty(newPhone) ||
                string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(oldName))
            {
                MessageBox.Show("Por favor, completa todos los campos (teléfono antiguo, nuevo teléfono, nuevo nombre y nombre antiguo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkPhone(newPhone))
            {
                MessageBox.Show("Por favor, introduce un número de teléfono válido (11 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkName(newName))
            {
                MessageBox.Show("Por favor, introduce un nombre válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contact contactToUpdate = ListaContactos.listaContactos
                .FirstOrDefault(c => c.Name.Equals(oldName, StringComparison.OrdinalIgnoreCase)
                                  && c.Phone == oldPhone);

            if (contactToUpdate != null)
            {
                
                contactToUpdate.Name = newName;
                contactToUpdate.Phone = newPhone;

                MessageBox.Show("Información del contacto actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún contacto con ese nombre y número de teléfono antiguos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
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
        private bool checkName(string name)
        {
            return !string.IsNullOrEmpty(name) && name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
