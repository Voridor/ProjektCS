using ProjektC_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProjektCS
{
    public partial class Form2 : Form
    {
        Filmy filmF;
        MyDbContext connectionF;
        public Form2(Filmy film, MyDbContext connection)
        {
            InitializeComponent();

            var aktor = connection.Aktorzy.OrderBy(a => a.id).ToList();
            var rezyser = connection.Rezyserzy.OrderBy(r => r.id).ToList();

            filmF = film;
            connectionF = connection;

            label1.Text += film.tytul;
            label2.Text += film.data_wydania.ToString("dd-MM-yyyy");
            label3.Text += rezyser.FirstOrDefault(r => r.id == film.rezyser_id)?.imie + " " + rezyser.FirstOrDefault(r => r.id == film.rezyser_id)?.nazwisko;
            label4.Text += aktor.FirstOrDefault(a => a.id == film.aktor_id)?.imie + " " + aktor.FirstOrDefault(a => a.id == film.aktor_id)?.nazwisko;
            //label5.Text += film.sciezka_do_pliku;
            label6.Text += film.gatunki;

            linkLabel1.Text = film.sciezka_do_pliku ?? "Brak pliku";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;

            pictureBox1.Image = Image.FromFile(film.sciezkadoobrazu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var form3 = new Form3(connectionF, filmF, "update");
            form3.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(filmF.sciezka_do_pliku) && System.IO.File.Exists(filmF.sciezka_do_pliku))
            {
                System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{filmF.sciezka_do_pliku}\"");
            }
            else
            {
                MessageBox.Show("Brak ścieżki do pliku lub plik nie istnieje.");
            }
        }
    }
}
