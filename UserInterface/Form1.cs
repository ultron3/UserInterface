namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string textToSave = textBox1.Text; // Ottieni il testo dalla casella di testo

            // Specifica il percorso del file in cui desideri salvare il testo
            string filePath = "C:\\Users\\IdeaPad\\OneDrive\\Documenti\\file.txt";

            // Utilizza il metodo File.WriteAllText per salvare il testo nel file
            System.IO.File.WriteAllText(filePath, textToSave);

            MessageBox.Show("Testo salvato con successo nel file.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}