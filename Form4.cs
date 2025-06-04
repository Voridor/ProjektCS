using ProjektC_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProjektCS
{
    public partial class Form4 : Form
    {
        private readonly MyDbContext _connection;
        private readonly string _whatToAdd;

        public Form4(MyDbContext connection, string whatToAdd)
        {
            InitializeComponent();
            _connection = connection;
            _whatToAdd = whatToAdd.ToLower();

            this.Text = _whatToAdd == "aktor" ? "Dodaj aktora" : "Dodaj reżysera";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text.Trim();
            string nazwisko = textBox3.Text.Trim();
            DateTime dataUrodzenia;

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
            {
                MessageBox.Show("Wprowadź imię i nazwisko.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Zakładam, że masz kontrolkę DateTimePicker o nazwie dateTimePicker1
            if (!DateTime.TryParse(dateTimePicker1.Text, out dataUrodzenia))
            {
                MessageBox.Show("Wprowadź poprawną datę urodzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_whatToAdd == "aktor")
            {
                var aktor = new Aktorzy { imie = imie, nazwisko = nazwisko, data_urodzenia = dataUrodzenia };
                _connection.Aktorzy.Add(aktor);
            }
            else if (_whatToAdd == "reżyser" || _whatToAdd == "rezyser")
            {
                var rezyser = new Rezyserzy { imie = imie, nazwisko = nazwisko, data_urodzenia = dataUrodzenia };
                _connection.Rezyserzy.Add(rezyser);
            }
            else
            {
                MessageBox.Show("Nieznany typ do dodania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _connection.SaveChanges();
            MessageBox.Show("Dodano do bazy danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
