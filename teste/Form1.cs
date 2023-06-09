using System.Data;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;

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
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\tmp\veiculoVenda.xml");

            // Obter a lista de elementos desejados
            XmlNode xml = xmlDoc.SelectSingleNode("rootElement");

            XmlNodeList lista = xml.SelectNodes("veiculo");

            XmlNodeList veiculoNodes = xmlDoc.SelectNodes("//veiculo");

            // Criar uma lista de veículos
            List<veiculo> listaVeiculos = new List<veiculo>();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Marca");
            dataTable.Columns.Add("Veiculo");
            dataTable.Columns.Add("Ano");
            dataTable.Columns.Add("Cor");
            dataTable.Columns.Add("Tipo Combustivel");
            dataTable.Columns.Add("Preço");
            dataTable.Columns.Add("Guid");
            foreach (XmlNode veiculoNode in veiculoNodes)
            {
                string marca = veiculoNode.SelectSingleNode("marca").InnerText.ToString();
                string tipoVeiculo = veiculoNode.SelectSingleNode("tipoVeiculo").InnerText.ToString();
                string ano = veiculoNode.SelectSingleNode("ano").InnerText.ToString();
                string preco = veiculoNode.SelectSingleNode("preco").InnerText.ToString();
                string tipoCombustivel = veiculoNode.SelectSingleNode("tipoCombustivel").InnerText.ToString();
                string cor = veiculoNode.SelectSingleNode("cor").InnerText.ToString();
                string guid = veiculoNode.SelectSingleNode("guid").InnerText.ToString();
                //veiculo v = new veiculo();



                // Adicionar linhas ao DataTable
                dataTable.Rows.Add(marca, tipoVeiculo, ano, cor, tipoCombustivel, preco, guid);

                //v.ano = ano;
                //v.preco = preco;
                //v.tipoVeiculo = tipoVeiculo;
                //v.cor = cor;
                //v.preco = preco;
                //v.tipoCombustivel = tipoCombustivel;
                //Console.Write(marca);

                //listaVeiculos.Add(v);
            }
            gridVendas.DataSource = dataTable;

            xmlDoc.Load(@"C:\tmp\veiculoCompra.xml");

            // Obter a lista de elementos desejados
            xml = xmlDoc.SelectSingleNode("rootElement");

            lista = xml.SelectNodes("veiculo");

            veiculoNodes = xmlDoc.SelectNodes("//veiculo");

            // Criar uma lista de veículos
            listaVeiculos = new List<veiculo>();
            dataTable = new DataTable();
            dataTable.Columns.Add("Marca");
            dataTable.Columns.Add("Veiculo");
            dataTable.Columns.Add("Ano");
            dataTable.Columns.Add("Cor");
            dataTable.Columns.Add("Tipo Combustivel");
            dataTable.Columns.Add("Preço");
            dataTable.Columns.Add("Guid");
            foreach (XmlNode veiculoNode in veiculoNodes)
            {
                string marca = veiculoNode.SelectSingleNode("marca").InnerText.ToString();
                string tipoVeiculo = veiculoNode.SelectSingleNode("tipoVeiculo").InnerText.ToString();
                string ano = veiculoNode.SelectSingleNode("ano").InnerText.ToString();
                string preco = veiculoNode.SelectSingleNode("preco").InnerText.ToString();
                string tipoCombustivel = veiculoNode.SelectSingleNode("tipoCombustivel").InnerText.ToString();
                string cor = veiculoNode.SelectSingleNode("cor").InnerText.ToString();
                string guid = veiculoNode.SelectSingleNode("guid").InnerText.ToString();
                Console.Write(marca);
                //veiculo v = new veiculo();



                // Adicionar linhas ao DataTable
                dataTable.Rows.Add(marca, tipoVeiculo, ano, cor, tipoCombustivel, preco, guid);

                //v.ano = ano;
                //v.preco = preco;
                //v.tipoVeiculo = tipoVeiculo;
                //v.cor = cor;
                //v.preco = preco;
                //v.tipoCombustivel = tipoCombustivel;
                //Console.Write(marca);

                //listaVeiculos.Add(v);
            }
            gridCompra.DataSource = dataTable;

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
            Boolean compra = inputCompra.Checked;
            Boolean venda = inputVenda.Checked;
            if (_tipoVeiculo != null && _preco != null && _marca != null)
            {
                XmlDocument xmldoc = new XmlDocument();
                string caminho;
                if (compra)
                {
                    caminho = @"C:\tmp\veiculoCompra.xml";
                }
                else
                {
                    caminho = @"C:\tmp\veiculoVenda.xml";
                }

                xmldoc.Load(caminho);

                //Cria um novo nó
                XmlElement novoVeiculo = xmldoc.CreateElement("veiculo");
                XmlElement xmlGuid = xmldoc.CreateElement("guid");
                XmlElement xmlTipoVeiculo = xmldoc.CreateElement("tipoVeiculo");
                XmlElement xmlMarca = xmldoc.CreateElement("marca");
                XmlElement xmlAno = xmldoc.CreateElement("ano");
                XmlElement xmlTipoCombustivel = xmldoc.CreateElement("tipoCombustivel");
                XmlElement xmlCor = xmldoc.CreateElement("cor");
                XmlElement xmlPreco = xmldoc.CreateElement("preco");

                Guid guid = Guid.NewGuid();

                xmlGuid.InnerText = guid.ToString();
                xmlTipoVeiculo.InnerText = _tipoVeiculo;
                xmlTipoCombustivel.InnerText = _tipoCombustivel;
                xmlMarca.InnerText = _marca;
                xmlAno.InnerText = _ano;
                xmlCor.InnerText = _cor;
                xmlPreco.InnerText = _preco;

                novoVeiculo.AppendChild(xmlGuid);
                novoVeiculo.AppendChild(xmlTipoVeiculo);
                novoVeiculo.AppendChild(xmlMarca);
                novoVeiculo.AppendChild(xmlAno);
                novoVeiculo.AppendChild(xmlTipoCombustivel);
                novoVeiculo.AppendChild(xmlCor);
                novoVeiculo.AppendChild(xmlPreco);

                xmldoc.DocumentElement.AppendChild(novoVeiculo);
                xmldoc.Save(caminho);
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void abrirEdicao(object sender, EventArgs e)//editar de vendas
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\tmp\veiculoVenda.xml");

            // Obter a lista de elementos desejados
            XmlNode xml = xmlDoc.SelectSingleNode("rootElement");

            XmlNodeList lista = xml.SelectNodes("veiculo");

            XmlNodeList veiculoNodes = xmlDoc.SelectNodes("//veiculo");

            // Criar uma lista de veículos
            List<veiculo> listaVeiculos = new List<veiculo>();

            //string marca = veiculoNodes[0].SelectSingleNode("marca").InnerText;


            foreach (XmlNode veiculoNode in veiculoNodes)
            {
                string l = gridCompra.SelectedRows.ToString();
                //veiculo v = new veiculo();
                //v.tipoVeiculo = veiculoNode.SelectSingleNode("tipoVeiculo").InnerText;
                //v.marca = veiculoNode.SelectSingleNode("marca").InnerText;
                //v.ano = veiculoNode.SelectSingleNode("ano").InnerText;
                //v.tipoCombustivel = veiculoNode.SelectSingleNode("tipoCombustivel").InnerText;
                //v.cor = veiculoNode.SelectSingleNode("cor").InnerText;
                //v.preco = veiculoNode.SelectSingleNode("preco").InnerText;
                Console.Write(marca);

                //listaVeiculos.Add(v);
            }
            Console.WriteLine(listaVeiculos);
        }

        private void vendas_Enter(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\tmp\veiculoVenda.xml");

            // Obter a lista de elementos desejados
            XmlNode xml = xmlDoc.SelectSingleNode("rootElement");

            XmlNodeList lista = xml.SelectNodes("veiculo");

            XmlNodeList veiculoNodes = xmlDoc.SelectNodes("//veiculo");

            // Criar uma lista de veículos
            List<veiculo> listaVeiculos = new List<veiculo>();
            foreach (XmlNode veiculoNode in veiculoNodes)
            {
                string marca = veiculoNode.SelectSingleNode("marca").InnerText.ToString();
                string tipoVeiculo = veiculoNode.SelectSingleNode("tipoVeiculo").InnerText.ToString();
                string ano = veiculoNode.SelectSingleNode("ano").InnerText.ToString();
                string preco = veiculoNode.SelectSingleNode("preco").InnerText.ToString();
                string tipoCombustivel = veiculoNode.SelectSingleNode("tipoCombustivel").InnerText.ToString();
                string cor = veiculoNode.SelectSingleNode("cor").InnerText.ToString();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridCompra.Rows[e.RowIndex];

            string filePath = @"C:\tmp\veiculoCompra.xml";

            XDocument doc = XDocument.Load(filePath);

            string guid = row.Cells["Guid"].Value.ToString();
            string marca = row.Cells["Marca"].Value.ToString();
            string tipoVeiculo = row.Cells["Veiculo"].Value.ToString();
            string ano = row.Cells["Ano"].Value.ToString();
            string cor = row.Cells["Cor"].Value.ToString();
            string tipoCombustivel = row.Cells["Tipo Combustivel"].Value.ToString();
            string preco = row.Cells["Preço"].Value.ToString();
            XElement veiculo = doc.Descendants("veiculo")
                              .FirstOrDefault(e => e.Element("guid").Value == guid);

            if (veiculo != null)
            {
                // Atualizar os valores dos elementos
                veiculo.Element("marca").Value = marca;
                veiculo.Element("tipoVeiculo").Value = tipoVeiculo;
                veiculo.Element("ano").Value = ano;
                veiculo.Element("cor").Value = cor;
                veiculo.Element("tipoCombustivel").Value = tipoCombustivel;
                veiculo.Element("preco").Value = preco;

                // Salvar as alterações de volta para o arquivo XML
                doc.Save(filePath);
            }
        }

        private void gridVendas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridVendas.Rows[e.RowIndex];

            string filePath = @"C:\tmp\veiculoVenda.xml";

            XDocument doc = XDocument.Load(filePath);

            string guid = row.Cells["Guid"].Value.ToString();
            string marca = row.Cells["Marca"].Value.ToString();
            string tipoVeiculo = row.Cells["Veiculo"].Value.ToString();
            string ano = row.Cells["Ano"].Value.ToString();
            string cor = row.Cells["Cor"].Value.ToString();
            string tipoCombustivel = row.Cells["Tipo Combustivel"].Value.ToString();
            string preco = row.Cells["Preço"].Value.ToString();
            XElement veiculo = doc.Descendants("veiculo")
                              .FirstOrDefault(e => e.Element("guid").Value == guid);

            if (veiculo != null)
            {
                // Atualizar os valores dos elementos
                veiculo.Element("marca").Value = marca;
                veiculo.Element("tipoVeiculo").Value = tipoVeiculo;
                veiculo.Element("ano").Value = ano;
                veiculo.Element("cor").Value = cor;
                veiculo.Element("tipoCombustivel").Value = tipoCombustivel;
                veiculo.Element("preco").Value = preco;

                // Salvar as alterações de volta para o arquivo XML
                doc.Save(filePath);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sourceFilePath = @"C:\tmp\veiculoCompra.xml";

            // Exibir o diálogo de salvamento
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";
            saveFileDialog.Title = "Salvar arquivo XML";
            saveFileDialog.FileName = "veiculoCompraCopia.xml"; // Nome padrão para a cópia do arquivo

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;

                // Copiar o arquivo XML para o novo destino
                File.Copy(sourceFilePath, destinationFilePath);

                Console.WriteLine("Arquivo XML copiado com sucesso para: " + destinationFilePath);
            }
            else
            {
                Console.WriteLine("Operação de salvamento cancelada pelo usuário.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sourceFilePath = @"C:\tmp\veiculoVenda.xml";

            // Exibir o diálogo de salvamento
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";
            saveFileDialog.Title = "Salvar arquivo XML";
            saveFileDialog.FileName = "veiculoVendaCopia.xml"; // Nome padrão para a cópia do arquivo

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;

                // Copiar o arquivo XML para o novo destino
                File.Copy(sourceFilePath, destinationFilePath);

                Console.WriteLine("Arquivo XML copiado com sucesso para: " + destinationFilePath);
            }
            else
            {
                Console.WriteLine("Operação de salvamento cancelada pelo usuário.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sourceFilePath = @"C:\tmp\veiculoCompra.xml";
            string destinationFolderPath = @"C:\tmp\";

            // Gerar um novo GUID curto
            string guid = Guid.NewGuid().ToString().Substring(0, 8);

            // Construir o nome do arquivo de destino com o GUID
            string destinationFileName = $"veiculoCompra_{guid}.xml";
            string destinationFilePath = Path.Combine(destinationFolderPath, destinationFileName);

            // Copiar o arquivo XML para o novo destino
            File.Copy(sourceFilePath, destinationFilePath);

            Console.WriteLine("Arquivo XML copiado com sucesso para: " + destinationFilePath);

            // Abrir o arquivo XML após ser salvo
            OpenXmlFile(destinationFilePath);
        }

        static async void OpenXmlFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                // Abrir o arquivo XML com o aplicativo padrão associado
                await Task.Delay(TimeSpan.FromMilliseconds(1_000));
                Process.Start(filePath);
            }
            else
            {
                Console.WriteLine("Arquivo XML não encontrado: " + filePath);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sourceFilePath = @"C:\tmp\veiculoVenda.xml";

            string destinationFolderPath = @"C:\tmp\";

            // Gerar um novo GUID curto
            string guid = Guid.NewGuid().ToString().Substring(0, 8);

            // Construir o nome do arquivo de destino com o GUID
            string destinationFileName = $"veiculoVenda_{guid}.xml";
            string destinationFilePath = Path.Combine(destinationFolderPath, destinationFileName);

            // Copiar o arquivo XML para o novo destino
            File.Copy(sourceFilePath, destinationFilePath);

            Console.WriteLine("Arquivo XML copiado com sucesso para: " + destinationFilePath);

            // Abrir o arquivo XML após ser salvo
            OpenXmlFile(destinationFilePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gridVendas.SelectedRows.Count > 0)
            {
                // Obter o valor do GUID da célula selecionada
                string guidToRemove = gridVendas.SelectedRows[0].Cells["Guid"].Value.ToString();

                // Chamar o método para excluir o veículo com base no GUID
                string filePath = @"C:\tmp\veiculoVenda.xml";

                XDocument doc = XDocument.Load(filePath);

                // Localizar o veículo pelo GUID
                XElement veiculoToRemove = doc.Descendants("veiculo")
                                              .FirstOrDefault(e => e.Element("guid").Value == guidToRemove);

                if (veiculoToRemove != null)
                {
                    // Remover o elemento "veiculo" do documento XML
                    veiculoToRemove.Remove();

                    // Salvar as alterações de volta para o arquivo XML
                    doc.Save(filePath);
                    gridVendas.Rows.RemoveAt(gridCompra.SelectedRows[0].Index);
                    Console.WriteLine("Veículo removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Veículo não encontrado!");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (gridCompra.SelectedRows.Count > 0)
            {
                // Obter o valor do GUID da célula selecionada
                string guidToRemove = gridCompra.SelectedRows[0].Cells["Guid"].Value.ToString();

                // Chamar o método para excluir o veículo com base no GUID
                string filePath = @"C:\tmp\veiculoCompra.xml";

                XDocument doc = XDocument.Load(filePath);

                // Localizar o veículo pelo GUID
                XElement veiculoToRemove = doc.Descendants("veiculo")
                                              .FirstOrDefault(e => e.Element("guid").Value == guidToRemove);

                if (veiculoToRemove != null)
                {
                    // Remover o elemento "veiculo" do documento XML
                    veiculoToRemove.Remove();

                    // Salvar as alterações de volta para o arquivo XML
                    doc.Save(filePath);
                    gridCompra.Rows.RemoveAt(gridCompra.SelectedRows[0].Index);
                    Console.WriteLine("Veículo removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Veículo não encontrado!");
                }
            }
        }
    }


    public class veiculo
    {
        public string tipoVeiculo
        {
            get { return tipoVeiculo; }
            set { tipoVeiculo = value; }
        }

        public string guid
        {
            get { return marca; }
        }
        public string marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public string tipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }
        public string cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}