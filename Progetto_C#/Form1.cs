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

            string voceSelezionata = listBox1.SelectedItem.ToString();
            if (voceSelezionata == "Tiramisù")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form2 nuovaFinestra = new Form2();
                nuovaFinestra.Show();
            }

            else if (voceSelezionata == "Brioche")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form3 nuovaFinestra = new Form3();
                nuovaFinestra.Show();
            }
            else if (voceSelezionata == "Frittella")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form4 nuovaFinestra = new Form4();
                nuovaFinestra.Show();
            }
            else if (voceSelezionata == "Cheesecake")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form5 nuovaFinestra = new Form5();
                nuovaFinestra.Show();
            }
            else if (voceSelezionata == "Plumcake")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form6 nuovaFinestra = new Form6();
                nuovaFinestra.Show();
            }
            else if (voceSelezionata == "Crostata")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form7 nuovaFinestra = new Form7();
                nuovaFinestra.Show();
            }
            else if (voceSelezionata == "Biscotti")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form8 nuovaFinestra = new Form8();
                nuovaFinestra.Show();
            }
            else if (voceSelezionata == "Pandoro")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form9 nuovaFinestra = new Form9();
                nuovaFinestra.Show();
            }
            else if (voceSelezionata == "Gelato")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form10 nuovaFinestra = new Form10();
                nuovaFinestra.Show();
            }
            else if (voceSelezionata == "CiccioCake")
            {
                MessageBox.Show("Hai selezionato: " + voceSelezionata);
                Form11 nuovaFinestra = new Form11();
                nuovaFinestra.Show();
            }





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
