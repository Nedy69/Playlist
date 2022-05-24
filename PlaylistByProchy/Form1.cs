using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlaylistByProchy
{
    public partial class Form1 : Form
    {
        private readonly List<Pisnicka> _pisnickaList = new List<Pisnicka>();

        public Form1()
        {
            InitializeComponent();

            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 172, Nazev = "Sklo", Oblibenost = 1,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 135, Nazev = "Pribehy, sny", Oblibenost = 2,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 140, Nazev = "Highway", Oblibenost = 3,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 216, Nazev = "Lavazza", Oblibenost = 4,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 174, Nazev = "Vice City", Oblibenost = 5,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 114, Nazev = "Co lidi udelaj", Oblibenost = 6,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 163, Nazev = "pro love", Oblibenost = 7,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 190, Nazev = "Nostalgie", Oblibenost = 8,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 152, Nazev = "Baby shark", Oblibenost = 9,
                Stari = new TimeSpan(2, 5, 1, 2)
            });
            _pisnickaList.Add(new Pisnicka
            {
                Album = "Pribehy a sny", Autor = "Viktor Sheen", Delka = 173, Nazev = "Stiny", Oblibenost = 10,
                Stari = new TimeSpan(2, 5, 1, 2)
            });

            _pisnickaList = _pisnickaList.OrderByDescending(p => p.Oblibenost).ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _pisnickaList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = new Form2(_pisnickaList[e.RowIndex]);
            if (form.ShowDialog() != DialogResult.OK) return;
            _pisnickaList[e.RowIndex] = form.Pisnicka;
            dataGridView1.DataSource = _pisnickaList.OrderByDescending(p => p.Oblibenost).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}