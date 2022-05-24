using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistByProchy
{
    public partial class Form2 : Form
    {
        public Pisnicka Pisnicka { get; set; }
        public Form2(Pisnicka pisnicka)
        {
            InitializeComponent();
            textBox1.Text = pisnicka.Nazev;
            textBox2.Text = pisnicka.Album;
            textBox4.Text = pisnicka.Autor;
            numericUpDown1.Value = pisnicka.Oblibenost;
            numericUpDown2.Value = pisnicka.Delka;
            Pisnicka = pisnicka;

            dateTimePicker1.Value = DateTime.Now.Subtract(pisnicka.Stari);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pisnicka.Nazev = textBox1.Text;
            Pisnicka.Autor = textBox2.Text;
            Pisnicka.Autor = textBox4.Text;
            Pisnicka.Oblibenost = (int)numericUpDown1.Value;
            Pisnicka.Delka = (int)numericUpDown2.Value;
            Pisnicka.Stari = DateTime.Now - dateTimePicker1.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
