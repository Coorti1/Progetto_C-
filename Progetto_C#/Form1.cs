namespace Progetto_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string voceSelezionata = listBox1.SelectedItem.ToString().Trim();
            MessageBox.Show("Hai selezionato: " + voceSelezionata);

            Form f = null;

            switch (voceSelezionata)
            {
                case "Tiramisù": f = new Form2(); break;
                case "Brioche": f = new Form3(); break;
                case "Frittella": f = new Form4(); break;
                case "Cheesecake": f = new Form5(); break;
                case "Plumcake": f = new Form6(); break;
                case "Crostata": f = new Form7(); break;
                case "Biscotti": f = new Form8(); break;
                case "Pandoro": f = new Form9(); break;
                case "Gelato": f = new Form10(); break;
                case "CiccioCake": f = new Form11(); break;
                default:
                    MessageBox.Show("Dolce non riconosciuto!");
                    break;
            }

            f?.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormLista fm = new FormLista();

            fm.listBox1.Items.Add("Elemento 1");
            fm.listBox1.Items.Add("Elemento 2");

            fm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
