﻿namespace teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "", "1", "1", "1", "1", "1", "1" }, -1);
            label1 = new Label();
            inputMarca = new TextBox();
            inputVeiculo = new ComboBox();
            inputAno = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputTipoCombustivel = new TextBox();
            inputCor = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tabControl1 = new TabControl();
            cadastro = new TabPage();
            label9 = new Label();
            inputCompra = new RadioButton();
            inputVenda = new RadioButton();
            inputPreco = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            vendas = new TabPage();
            gridVendas = new DataGridView();
            button7 = new Button();
            button6 = new Button();
            textBox7 = new TextBox();
            button3 = new Button();
            listView1 = new ListView();
            veiculo = new ColumnHeader();
            marca = new ColumnHeader();
            ano = new ColumnHeader();
            tipo_c = new ColumnHeader();
            cor = new ColumnHeader();
            preco = new ColumnHeader();
            compras = new TabPage();
            gridCompra = new DataGridView();
            button8 = new Button();
            button9 = new Button();
            textBox8 = new TextBox();
            button12 = new Button();
            veiculoBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            cadastro.SuspendLayout();
            vendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVendas).BeginInit();
            compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)veiculoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(593, 60);
            label1.TabIndex = 1;
            label1.Text = "Venda e Compra de Veículos";
            // 
            // inputMarca
            // 
            inputMarca.BackColor = SystemColors.InactiveBorder;
            inputMarca.CharacterCasing = CharacterCasing.Upper;
            inputMarca.Location = new Point(442, 36);
            inputMarca.Margin = new Padding(3, 4, 3, 4);
            inputMarca.Name = "inputMarca";
            inputMarca.Size = new Size(411, 27);
            inputMarca.TabIndex = 3;
            // 
            // inputVeiculo
            // 
            inputVeiculo.BackColor = SystemColors.InactiveBorder;
            inputVeiculo.FormattingEnabled = true;
            inputVeiculo.Items.AddRange(new object[] { "Carro", "Moto", "Caminhão", "Bicicleta", "Barco", "Avião" });
            inputVeiculo.Location = new Point(7, 36);
            inputVeiculo.Margin = new Padding(3, 4, 3, 4);
            inputVeiculo.Name = "inputVeiculo";
            inputVeiculo.Size = new Size(403, 28);
            inputVeiculo.TabIndex = 4;
            // 
            // inputAno
            // 
            inputAno.BackColor = SystemColors.InactiveBorder;
            inputAno.Location = new Point(7, 128);
            inputAno.Margin = new Padding(3, 4, 3, 4);
            inputAno.Name = "inputAno";
            inputAno.Size = new Size(403, 27);
            inputAno.TabIndex = 5;
            inputAno.KeyPress += inputAno_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 12);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 6;
            label3.Text = "Veículo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 12);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 104);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 8;
            label5.Text = "Ano";
            // 
            // inputTipoCombustivel
            // 
            inputTipoCombustivel.BackColor = SystemColors.InactiveBorder;
            inputTipoCombustivel.CharacterCasing = CharacterCasing.Upper;
            inputTipoCombustivel.Location = new Point(442, 128);
            inputTipoCombustivel.Margin = new Padding(3, 4, 3, 4);
            inputTipoCombustivel.Name = "inputTipoCombustivel";
            inputTipoCombustivel.Size = new Size(411, 27);
            inputTipoCombustivel.TabIndex = 9;
            inputTipoCombustivel.TextChanged += textBox4_TextChanged;
            // 
            // inputCor
            // 
            inputCor.BackColor = SystemColors.InactiveBorder;
            inputCor.CharacterCasing = CharacterCasing.Upper;
            inputCor.Location = new Point(7, 219);
            inputCor.Margin = new Padding(3, 4, 3, 4);
            inputCor.Name = "inputCor";
            inputCor.Size = new Size(403, 27);
            inputCor.TabIndex = 10;
            inputCor.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 104);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 11;
            label6.Text = "Tipo de Combustível";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 192);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 12;
            label7.Text = "Cor";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(cadastro);
            tabControl1.Controls.Add(vendas);
            tabControl1.Controls.Add(compras);
            tabControl1.Location = new Point(15, 72);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(882, 423);
            tabControl1.TabIndex = 14;
            // 
            // cadastro
            // 
            cadastro.BackColor = Color.AliceBlue;
            cadastro.Controls.Add(label9);
            cadastro.Controls.Add(inputCompra);
            cadastro.Controls.Add(inputVenda);
            cadastro.Controls.Add(inputPreco);
            cadastro.Controls.Add(button2);
            cadastro.Controls.Add(button1);
            cadastro.Controls.Add(label8);
            cadastro.Controls.Add(inputVeiculo);
            cadastro.Controls.Add(inputMarca);
            cadastro.Controls.Add(label7);
            cadastro.Controls.Add(inputAno);
            cadastro.Controls.Add(label6);
            cadastro.Controls.Add(label3);
            cadastro.Controls.Add(inputCor);
            cadastro.Controls.Add(label4);
            cadastro.Controls.Add(inputTipoCombustivel);
            cadastro.Controls.Add(label5);
            cadastro.Location = new Point(4, 29);
            cadastro.Margin = new Padding(3, 4, 3, 4);
            cadastro.Name = "cadastro";
            cadastro.Padding = new Padding(3, 4, 3, 4);
            cadastro.Size = new Size(874, 390);
            cadastro.TabIndex = 0;
            cadastro.Text = "Cadastro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 294);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 20;
            label9.Text = "Tipo";
            // 
            // inputCompra
            // 
            inputCompra.AutoSize = true;
            inputCompra.Location = new Point(165, 317);
            inputCompra.Name = "inputCompra";
            inputCompra.Size = new Size(83, 24);
            inputCompra.TabIndex = 19;
            inputCompra.TabStop = true;
            inputCompra.Text = "Compra";
            inputCompra.UseVisualStyleBackColor = true;
            inputCompra.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // inputVenda
            // 
            inputVenda.AutoSize = true;
            inputVenda.Location = new Point(18, 317);
            inputVenda.Name = "inputVenda";
            inputVenda.Size = new Size(71, 24);
            inputVenda.TabIndex = 18;
            inputVenda.TabStop = true;
            inputVenda.Text = "Venda";
            inputVenda.UseVisualStyleBackColor = true;
            // 
            // inputPreco
            // 
            inputPreco.Location = new Point(442, 219);
            inputPreco.Margin = new Padding(3, 4, 3, 4);
            inputPreco.Name = "inputPreco";
            inputPreco.Size = new Size(411, 27);
            inputPreco.TabIndex = 17;
            inputPreco.KeyPress += inputPreco_KeyPress_1;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(664, 307);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(177, 44);
            button2.TabIndex = 16;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(455, 307);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(177, 44);
            button1.TabIndex = 15;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 195);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 14;
            label8.Text = "Preço";
            // 
            // vendas
            // 
            vendas.BackColor = Color.AliceBlue;
            vendas.Controls.Add(gridVendas);
            vendas.Controls.Add(button7);
            vendas.Controls.Add(button6);
            vendas.Controls.Add(textBox7);
            vendas.Controls.Add(button3);
            vendas.Controls.Add(listView1);
            vendas.Location = new Point(4, 29);
            vendas.Margin = new Padding(3, 4, 3, 4);
            vendas.Name = "vendas";
            vendas.Padding = new Padding(3, 4, 3, 4);
            vendas.Size = new Size(874, 390);
            vendas.TabIndex = 1;
            vendas.Text = "Vendas";
            vendas.Enter += vendas_Enter;
            // 
            // gridVendas
            // 
            gridVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVendas.Location = new Point(7, 100);
            gridVendas.Name = "gridVendas";
            gridVendas.RowHeadersWidth = 51;
            gridVendas.RowTemplate.Height = 29;
            gridVendas.Size = new Size(859, 276);
            gridVendas.TabIndex = 7;
            gridVendas.CellEndEdit += gridVendas_CellEndEdit;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumPurple;
            button7.ForeColor = SystemColors.Window;
            button7.Location = new Point(740, 61);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(126, 31);
            button7.TabIndex = 6;
            button7.Text = "Gravar em XML";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.CornflowerBlue;
            button6.ForeColor = SystemColors.Window;
            button6.Location = new Point(312, 8);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 5;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.InactiveBorder;
            textBox7.Location = new Point(7, 8);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(298, 27);
            textBox7.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(7, 61);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(126, 31);
            button3.TabIndex = 1;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveBorder;
            listView1.Columns.AddRange(new ColumnHeader[] { veiculo, marca, ano, tipo_c, cor, preco });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem3 });
            listView1.Location = new Point(7, 100);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(859, 276);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // veiculo
            // 
            veiculo.Text = "Veículo";
            // 
            // marca
            // 
            marca.Text = "Marca";
            // 
            // ano
            // 
            ano.DisplayIndex = 4;
            ano.Text = "Ano";
            // 
            // tipo_c
            // 
            tipo_c.DisplayIndex = 2;
            tipo_c.Tag = "";
            tipo_c.Text = "Tipo de Combustível";
            // 
            // cor
            // 
            cor.DisplayIndex = 3;
            cor.Text = "Cor";
            // 
            // preco
            // 
            preco.Text = "Preço";
            // 
            // compras
            // 
            compras.BackColor = Color.AliceBlue;
            compras.Controls.Add(gridCompra);
            compras.Controls.Add(button8);
            compras.Controls.Add(button9);
            compras.Controls.Add(textBox8);
            compras.Controls.Add(button12);
            compras.Location = new Point(4, 29);
            compras.Margin = new Padding(3, 4, 3, 4);
            compras.Name = "compras";
            compras.Padding = new Padding(3, 4, 3, 4);
            compras.Size = new Size(874, 390);
            compras.TabIndex = 2;
            compras.Text = "Compras";
            // 
            // gridCompra
            // 
            gridCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCompra.Location = new Point(8, 99);
            gridCompra.Name = "gridCompra";
            gridCompra.RowHeadersWidth = 51;
            gridCompra.RowTemplate.Height = 29;
            gridCompra.Size = new Size(859, 276);
            gridCompra.TabIndex = 14;
            gridCompra.CellEndEdit += gridCompra_CellEndEdit;
            // 
            // button8
            // 
            button8.BackColor = Color.MediumPurple;
            button8.ForeColor = SystemColors.Window;
            button8.Location = new Point(741, 61);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(126, 31);
            button8.TabIndex = 13;
            button8.Text = "Gravar em XML";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.CornflowerBlue;
            button9.ForeColor = SystemColors.Window;
            button9.Location = new Point(312, 8);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(86, 31);
            button9.TabIndex = 12;
            button9.Text = "Buscar";
            button9.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.InactiveBorder;
            textBox8.Location = new Point(7, 8);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(298, 27);
            textBox8.TabIndex = 11;
            // 
            // button12
            // 
            button12.BackColor = Color.Red;
            button12.ForeColor = SystemColors.Window;
            button12.Location = new Point(7, 61);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(126, 31);
            button12.TabIndex = 8;
            button12.Text = "Excluir";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // veiculoBindingSource
            // 
            veiculoBindingSource.DataSource = typeof(veiculo);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(911, 519);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            cadastro.ResumeLayout(false);
            cadastro.PerformLayout();
            vendas.ResumeLayout(false);
            vendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVendas).EndInit();
            compras.ResumeLayout(false);
            compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)veiculoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox inputMarca;
        private ComboBox inputVeiculo;
        private TextBox inputAno;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inputTipoCombustivel;
        private TextBox inputCor;
        private Label label6;
        private Label label7;
        private TabControl tabControl1;
        private TabPage cadastro;
        private TabPage vendas;
        private TabPage compras;
        private Label label8;
        private ListView listView1;
        private ColumnHeader veiculo;
        private ColumnHeader marca;
        private ColumnHeader ano;
        private ColumnHeader tipo_c;
        private ColumnHeader cor;
        private ColumnHeader preco;
        private Button button2;
        private Button button1;
        private Button button6;
        private TextBox textBox7;
        private Button button3;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox8;
        private Button button12;
        private TextBox inputPreco;
        private Label label9;
        private RadioButton inputCompra;
        private RadioButton inputVenda;
        private BindingSource veiculoBindingSource;
        private DataGridView gridVendas;
        private DataGridView gridCompra;
    }
}