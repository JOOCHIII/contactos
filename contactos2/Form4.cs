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
            string currentPhone = textBox1.Text.Trim(); 
            string newPhone = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(currentPhone) || string.IsNullOrEmpty(newPhone))
            {
                MessageBox.Show("Por favor, ingresa el número de teléfono actual y el nuevo número de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkPhone(newPhone))
            {
                MessageBox.Show("Por favor, introduce un número de teléfono válido (11 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contact contactToUpdate = ListaContactos.listaContactos.FirstOrDefault(c => c.Phone == currentPhone);

            if (contactToUpdate != null)
            {
                contactToUpdate.Phone = newPhone;

                MessageBox.Show("Número de teléfono actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún contacto con ese número de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
