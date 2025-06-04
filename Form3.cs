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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjektCS
{
    public partial class Form3 : Form
    {
        private readonly MyDbContext _connection;
        private readonly int _filmId;
        private string _saveOrUpdate;
        public Form3(MyDbContext connection, Filmy film, string saveOrUpdate)
        {
            InitializeComponent();

            _connection = connection;
            _filmId = film.id;
            _saveOrUpdate = saveOrUpdate;

            buttonBrowse.Click += buttonBrowse_Click;
            buttonBrowseImage.Click += buttonBrowseImage_Click;

            var aktor = connection.Aktorzy.OrderBy(a => a.id).ToList();
            for (int i = 0; i < aktor.Count; i++)
            {
                comboBox5.Items.Add(aktor[i].imie + " " + aktor[i].nazwisko);
            }

            var rezyser = connection.Rezyserzy.OrderBy(r => r.id).ToList();
            for (int i = 0; i < rezyser.Count; i++)
            {
                comboBox6.Items.Add(rezyser[i].imie + " " + rezyser[i].nazwisko);
            }
            if (_saveOrUpdate == "update")
            {
                textBox1.Text = film.tytul;
                dateTimePicker1.Value = film.data_wydania;
                textBox3.Text = film.gatunki;
                buttonBrowseImage.Text = film.sciezkadoobrazu;
                buttonBrowse.Text = film.sciezka_do_pliku;

                comboBox5.SelectedIndex = aktor.FindIndex(a => a.id == film.aktor_id);

                comboBox6.SelectedIndex = rezyser.FindIndex(r => r.id == film.rezyser_id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sprawdzanie wymaganych pól
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                comboBox5.SelectedIndex < 0 ||
                comboBox6.SelectedIndex < 0)
            {
                MessageBox.Show("Uzupełnij wszystkie wymagane pola: tytuł, gatunki, aktor, reżyser.");
                return;
            }

            if (_saveOrUpdate == "update")
            {
                // Pobierz film z bazy po ID
                var film = _connection.Film.FirstOrDefault(f => f.id == _filmId);
                if (film != null)
                {
                    film.tytul = textBox1.Text;
                    film.data_wydania = dateTimePicker1.Value;
                    film.gatunki = textBox3.Text;
                    film.sciezkadoobrazu = buttonBrowseImage.Text;
                    film.aktor_id = comboBox5.SelectedIndex + 1;
                    film.rezyser_id = comboBox6.SelectedIndex + 1;
                    film.sciezka_do_pliku = buttonBrowse.Text;

                    _connection.SaveChanges();
                    MessageBox.Show("Film został zaktualizowany.");
                }
                else
                {
                    MessageBox.Show("Nie znaleziono filmu do aktualizacji.");
                }
            }
            else if (_saveOrUpdate == "save")
            {
                // Tworzenie nowego filmu
                var newFilm = new Filmy
                {
                    tytul = textBox1.Text,
                    data_wydania = dateTimePicker1.Value,
                    gatunki = textBox3.Text,
                    sciezkadoobrazu = buttonBrowseImage.Text,
                    aktor_id = comboBox5.SelectedIndex + 1,
                    rezyser_id = comboBox6.SelectedIndex + 1,
                    sciezka_do_pliku = buttonBrowse.Text
                };
                _connection.Film.Add(newFilm);
                _connection.SaveChanges();
                MessageBox.Show("Nowy film został zapisany.");
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki wideo|*.mp4;*.avi;*.mkv|Wszystkie pliki|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    buttonBrowse.Text = openFileDialog.FileName;

                    try
                    {
                        var file = TagLib.File.Create(openFileDialog.FileName);
                        // Przykład: metadana showName może być zapisana jako custom tag lub w polu Title
                        string showName = file.Tag.Title;

                        // Jeśli showName jest customową metadane, spróbuj ją pobrać z AdditionalFields
                        if (string.IsNullOrEmpty(showName) && file.TagTypes.HasFlag(TagLib.TagTypes.Id3v2))
                        {
                            var id3v2Tag = (TagLib.Id3v2.Tag)file.GetTag(TagLib.TagTypes.Id3v2);
                            var showNameFrame = id3v2Tag.GetFrames("TXXX")
                                .OfType<TagLib.Id3v2.UserTextInformationFrame>()
                                .FirstOrDefault(f => f.Description == "showName");
                            if (showNameFrame != null)
                                showName = showNameFrame.Text.FirstOrDefault();
                        }

                        if (!string.IsNullOrEmpty(showName))
                        {
                            textBox1.Text = showName;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nie udało się odczytać metadanych: " + ex.Message);
                    }
                }
            }
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki graficzne|*.jpg;*.jpeg;*.png;*.bmp|Wszystkie pliki|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    buttonBrowseImage.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
