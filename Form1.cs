using ProjektCS;

namespace ProjektC_
{
    public partial class Form1 : Form
    {
        
        public Form1(MyDbContext connection)
        {
            InitializeComponent();

            var filmy = connection.Film.ToList();

            foreach (var film in filmy)
            {
                DodajTestowaKarteProduktu(film.tytul, film.sciezkadoobrazu);
            }

            //DodajTestowaKarteProduktu("D&W", "C:\\Users\\Kacper\\GitHub\\ProjektCS\\123.jpg");
            //DodajTestowaKarteProduktu("","");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void DodajTestowaKarteProduktu(string movieName, string imagePath)
        {
            // Panel jako karta produktu
            var panel = new FlowLayoutPanel
            {
                //Width = 200,
                //Height = 200,
                //FlowDirection = FlowDirection.TopDown,
                MaximumSize = new Size(200, 1000),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0),
                AutoSize = true
            };

            // Obrazek produktu
            var pictureBox = new PictureBox
            {
                //Image = Image.FromFile("C:\\Users\\Kacper\\GitHub\\ProjektCS\\123.jpg"), // podaj prawid³ow¹ œcie¿kê do pliku JPG/PNG
                Image = Image.FromFile(imagePath), // podaj prawid³ow¹ œcie¿kê do pliku JPG/PNG
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(150, 300),
                Dock = DockStyle.Top    
            };

            // Tekst produktu
            var label = new Label
            {
                Text = movieName,
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Dock = DockStyle.Bottom
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);

            flowLayoutPanel1.Controls.Add(panel);
        }

    }

}
