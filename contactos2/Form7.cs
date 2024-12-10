using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactos2
{
    public partial class Form7 : Form

    {
        private static List<string> nombresguardados = new List<string>();

        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.UseSystemPasswordChar = !maskedTextBox1.UseSystemPasswordChar;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            maskedTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingresa un nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                nombresguardados.Add(nombre);

                Form1 form1 = new Form1(nombre);
                form1.Show();
                this.Hide();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
