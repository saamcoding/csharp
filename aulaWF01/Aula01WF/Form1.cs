namespace Aula01WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeDigitado = textBox1.Text;
            if (String.IsNullOrEmpty(nomeDigitado))
            //  SE NÃO FOI DIGITADO NADA
            {
                MessageBox.Show("Você não digitou seu nome!");
                return;
            }


            //  ALTERAR TEXTO DE LABEL1
            //  'label1' é o nome do controle e 'Text' é a propriedade do controle
            //  é usada diretamente, pois é uma instancia de controle, e cada
            //  controle tem um nome que você usa para referenciá-lo e manipular
            //  suas propriedades ou executar ações sobre ele.
            label1.Text = $"Me chamo {textBox1.Text} e Realizei meu primeiro 'Hello World!'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
