using Microsoft.Extensions.Configuration;
using ProjektCS;
using ProjektCS.Migrations;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProjektC_
{
    public partial class Form1 : Form
    {
        MyDbContext connectionF;
        Filmy filmF;
        public Form1(MyDbContext connection)
        {
            InitializeComponent();
            connectionF = connection;
            flowLayoutPanel1.AutoScroll = true; // <-- Dodaj tê liniê

            var filmy = connection.Film.ToList();
            connectionF = connection;
            filmF = new Filmy();
            var tasks = new List<Task>();
            foreach (var film in filmy)
            {
                if (!string.IsNullOrEmpty(film.sciezkadoobrazu))
                {
                    tasks.Add(DodajTestowaKarteProduktu(film.tytul, film.sciezkadoobrazu, film, connection));
                }
            }
            Task.WhenAll(tasks).GetAwaiter().GetResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task DodajTestowaKarteProduktu(string movieName, string imagePath, Filmy film = null, MyDbContext connection = null)
        {
            var label = new Label
            {
                Text = movieName,
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0, 5, 0, 10)
            };

            Image image = null;
            try
            {
                if (!string.IsNullOrEmpty(imagePath))
                {
                    if (Uri.TryCreate(imagePath, UriKind.Absolute, out var uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
                    {
                        using var httpClient = new HttpClient();
                        var imageBytes = await httpClient.GetByteArrayAsync(uri);
                        using var ms = new MemoryStream(imageBytes);
                        image = Image.FromStream(ms);
                    }
                    else if (File.Exists(imagePath))
                    {
                        image = Image.FromFile(imagePath);
                    }
                }
            }
            catch
            {
                image = null;
            }

            var pictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.AutoSize,
                Margin = new Padding(0, 10, 0, 0),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            //if (image != null)
            //{
            //    pictureBox.Size = image.Size;
            //}

            var verticalLayout = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                WrapContents = false,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(0),
                Padding = new Padding(0)
            };

            verticalLayout.Controls.Add(pictureBox);
            verticalLayout.Controls.Add(label);

            int panelWidth = 300;
            int panelHeight = 520;

            var panel = new Panel
            {
                Width = panelWidth,
                Height = panelHeight,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0),

                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Cursor = Cursors.Hand
            };

            panel.Controls.Add(verticalLayout);

            EventHandler openForm2 = (s, e) => { new Form2(film, connection).Show(); };
            panel.Click += openForm2;
            pictureBox.Click += openForm2;
            label.Click += openForm2;

            flowLayoutPanel1.Controls.Add(panel);
        }

        private void fIlmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new Form3(connectionF, filmF, "save");
            form3.Show();
        }

        private void aktoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form4 = new Form4(connectionF, "aktor");
            form4.Show();
        }

        private void re¿yseraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form4 = new Form4(connectionF, "re¿yser");
            form4.Show();
        }

        private async void odœwie¿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            using (var connection = new MyDbContext(connectionString))
            {
                var filmy = connection.Film.ToList();
                filmF = new Filmy();

                var tasks = new List<Task>();
                foreach (var film in filmy)
                {
                    if (!string.IsNullOrEmpty(film.sciezkadoobrazu))
                    {
                        tasks.Add(DodajTestowaKarteProduktu(film.tytul, film.sciezkadoobrazu, film, connection));
                    }
                }
                await Task.WhenAll(tasks);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            string selectedFilter = listBox1.SelectedItem?.ToString();

            flowLayoutPanel1.Controls.Clear();

            var filmy = connectionF.Film.ToList();

            // Pobierz listy aktorów i re¿yserów do pamiêci (optymalizacja dla prostoty)
            var aktorzy = connectionF.Aktorzy.ToList();
            var rezyserzy = connectionF.Rezyserzy.ToList();

            if (!string.IsNullOrEmpty(searchText) && !string.IsNullOrEmpty(selectedFilter))
            {
                switch (selectedFilter)
                {
                    case "Nazwa":
                        filmy = filmy.Where(f =>
                            !string.IsNullOrEmpty(f.tytul) &&
                            f.tytul.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                        ).ToList();
                        break;

                    case "Re¿yser":
                        filmy = filmy.Where(f =>
                        {
                            var rez = rezyserzy.FirstOrDefault(r => r.id == f.rezyser_id);
                            return rez != null && (
                                (!string.IsNullOrEmpty(rez.imie) && rez.imie.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                (!string.IsNullOrEmpty(rez.nazwisko) && rez.nazwisko.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                            );
                        }).ToList();
                        break;

                    case "Aktor":
                        filmy = filmy.Where(f =>
                        {
                            var akt = aktorzy.FirstOrDefault(a => a.id == f.aktor_id);
                            return akt != null && (
                                (!string.IsNullOrEmpty(akt.imie) && akt.imie.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                (!string.IsNullOrEmpty(akt.nazwisko) && akt.nazwisko.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                            );
                        }).ToList();
                        break;

                    case "Data wydania":
                        filmy = filmy.Where(f =>
                            f.data_wydania.ToString("yyyy-MM-dd").Contains(searchText)
                        ).ToList();
                        break;

                    case "Gatunek":
                        filmy = filmy.Where(f =>
                            !string.IsNullOrEmpty(f.gatunki) &&
                            f.gatunki.Split(',')
                                .Select(g => g.Trim())
                                .Any(g => g.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        ).ToList();
                        break;
                }
            }

            var tasks = new List<Task>();
            foreach (var film in filmy)
            {
                if (!string.IsNullOrEmpty(film.sciezkadoobrazu))
                {
                    tasks.Add(DodajTestowaKarteProduktu(film.tytul, film.sciezkadoobrazu, film, connectionF));
                }
            }
            await Task.WhenAll(tasks);
        }

        private void aktoraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form4 = new Form4(connectionF, "re¿yser");
            form4.Show();
        }

        private void usuñOstatnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionF.Film.RemoveRange(connectionF.Film.OrderByDescending(f => f.id).Take(connectionF.Film.ToList().Count));
        }
    }
}
