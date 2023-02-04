using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private static Regex reg = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNetzID.Visible= false;
            lblErsteHost.Visible= false;
            lblAnzahlHosts.Visible= false;
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            string ipText = textBox1.Text; 
            ipText = ipText.Trim();

            string netzwerkMaske = textBox1.Text;
            netzwerkMaske.Trim();

            lblAnzahlHosts.Text = ipText;
            lblAnzahlHosts.Visible = true; 
        }

        private void checkEingabeFormat(object sender, EventArgs e)
           
        {
            if (!reg.IsMatch((sender as TextBox).Text))
                {
                (sender as TextBox).Text = "Ungültig";
                (sender as TextBox).SelectAll();
                (sender as TextBox).Focus();
            }   
        }
    }

  
}