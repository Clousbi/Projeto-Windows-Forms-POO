using System.Text.RegularExpressions;
using System.Xml;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            veiculo v = new veiculo();
            
            string _tipoVeiculo = inputVeiculo.Text;
            string _marca = inputMarca.Text;
            string _ano = inputAno.Text;
            string _tipoCombustivel = inputTipoCombustivel.Text;
            string _cor = inputCor.Text;
            string _preco = inputPreco.Text;
            if (_tipoVeiculo != null && _preco != null && _marca != null)
            {

                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(@"C:\tmp\veiculo.xml");
                //Cria um novo nó
                XmlElement novoVeiculo = xmldoc.CreateElement("veiculo");
                XmlElement xmlTipoVeiculo = xmldoc.CreateElement("tipoVeiculo");
                XmlElement xmlMarca = xmldoc.CreateElement("marca");
                XmlElement xmlAno = xmldoc.CreateElement("ano");
                XmlElement xmlTipoCombustivel = xmldoc.CreateElement("tipoCombustivel");
                XmlElement xmlCor = xmldoc.CreateElement("cor");
                XmlElement xmlPreco = xmldoc.CreateElement("preco");

                xmlTipoVeiculo.InnerText = _tipoVeiculo;
                xmlTipoCombustivel.InnerText = _tipoCombustivel;
                xmlMarca.InnerText = _marca;
                xmlAno.InnerText = _ano;
                xmlCor.InnerText = _cor;
                xmlPreco.InnerText = _preco;


                novoVeiculo.AppendChild(xmlTipoVeiculo);
                novoVeiculo.AppendChild(xmlMarca);
                novoVeiculo.AppendChild(xmlAno);
                novoVeiculo.AppendChild(xmlTipoCombustivel);
                novoVeiculo.AppendChild(xmlCor);
                novoVeiculo.AppendChild(xmlPreco);

                xmldoc.DocumentElement.AppendChild(novoVeiculo);
                xmldoc.Save(@"C:\tmp\veiculo.xml");
            }
        }



        private void inputAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("este campo aceita somente numero e virgula");
            }
        }

        private void inputPreco_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                if (w == string.Empty) w = "00";

                if (e.KeyChar.Equals((char)Keys.Back))      //  If backspace
                    w = w.Substring(0, w.Length - 1);      //      takes out the rightmost digit
                else
                    w += e.KeyChar;
                inputPreco.Text = t.SelectionStart.ToString();

                t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}