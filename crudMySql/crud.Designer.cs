namespace MetroSetUi
{
    partial class crud
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_crud = new MetroFramework.Controls.MetroLabel();
            this.btn_close = new MetroFramework.Controls.MetroButton();
            this.btn_minimize = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_produto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_preco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_quantidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_peso = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbx_categoria = new MetroFramework.Controls.MetroComboBox();
            this.cbx_fornecedor = new MetroFramework.Controls.MetroComboBox();
            this.metroSetListBox2 = new MetroSet_UI.Controls.MetroSetListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new MetroFramework.Controls.MetroButton();
            this.btn_excluir = new MetroFramework.Controls.MetroButton();
            this.btn_limpar = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_descricao = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_crud
            // 
            this.lbl_crud.AutoSize = true;
            this.lbl_crud.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_crud.Location = new System.Drawing.Point(7, 6);
            this.lbl_crud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_crud.Name = "lbl_crud";
            this.lbl_crud.Size = new System.Drawing.Size(41, 19);
            this.lbl_crud.TabIndex = 0;
            this.lbl_crud.Text = "Crud";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(25, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Location = new System.Drawing.Point(0, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(26, 23);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Text = "-";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID Produto:";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(24, 71);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(149, 23);
            this.txt_produto.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Preço:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(230, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Categoria";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(24, 126);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(149, 23);
            this.txt_preco.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Quantidade:";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(24, 180);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(149, 23);
            this.txt_quantidade.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Peso";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(24, 236);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(149, 23);
            this.txt_peso.TabIndex = 4;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_close);
            this.metroPanel1.Controls.Add(this.btn_minimize);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(648, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 28);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(230, 104);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Fornecedor";
            // 
            // cbx_categoria
            // 
            this.cbx_categoria.FormattingEnabled = true;
            this.cbx_categoria.ItemHeight = 23;
            this.cbx_categoria.Location = new System.Drawing.Point(230, 71);
            this.cbx_categoria.Name = "cbx_categoria";
            this.cbx_categoria.Size = new System.Drawing.Size(121, 29);
            this.cbx_categoria.TabIndex = 5;
            // 
            // cbx_fornecedor
            // 
            this.cbx_fornecedor.FormattingEnabled = true;
            this.cbx_fornecedor.ItemHeight = 23;
            this.cbx_fornecedor.Location = new System.Drawing.Point(230, 127);
            this.cbx_fornecedor.Name = "cbx_fornecedor";
            this.cbx_fornecedor.Size = new System.Drawing.Size(121, 29);
            this.cbx_fornecedor.TabIndex = 6;
            // 
            // metroSetListBox2
            // 
            this.metroSetListBox2.BackColor = System.Drawing.Color.White;
            this.metroSetListBox2.BorderColor = System.Drawing.Color.LightGray;
            this.metroSetListBox2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetListBox2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetListBox2.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.metroSetListBox2.HoveredItemColor = System.Drawing.Color.DimGray;
            this.metroSetListBox2.IsDerivedStyle = true;
            this.metroSetListBox2.ItemHeight = 30;
            this.metroSetListBox2.Location = new System.Drawing.Point(-15, -15);
            this.metroSetListBox2.MultiSelect = false;
            this.metroSetListBox2.Name = "metroSetListBox2";
            this.metroSetListBox2.SelectedIndex = -1;
            this.metroSetListBox2.SelectedItem = null;
            this.metroSetListBox2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetListBox2.SelectedItemColor = System.Drawing.Color.White;
            this.metroSetListBox2.SelectedText = null;
            this.metroSetListBox2.SelectedValue = null;
            this.metroSetListBox2.ShowBorder = false;
            this.metroSetListBox2.ShowScrollBar = false;
            this.metroSetListBox2.Size = new System.Drawing.Size(75, 23);
            this.metroSetListBox2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetListBox2.StyleManager = null;
            this.metroSetListBox2.TabIndex = 8;
            this.metroSetListBox2.ThemeAuthor = "Narwin";
            this.metroSetListBox2.ThemeName = "MetroLite";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 293);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(24, 310);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(91, 43);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(121, 310);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(91, 43);
            this.btn_excluir.TabIndex = 9;
            this.btn_excluir.Text = "Excluir";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(218, 310);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(91, 43);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(226, 159);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Descrição";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(230, 181);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(149, 23);
            this.txt_descricao.TabIndex = 7;
            // 
            // crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 367);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroSetListBox2);
            this.Controls.Add(this.cbx_fornecedor);
            this.Controls.Add(this.cbx_categoria);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbl_crud);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.HeaderColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "crud";
            this.Padding = new System.Windows.Forms.Padding(13, 71, 13, 11);
            this.SmallLineColor1 = System.Drawing.Color.White;
            this.SmallLineColor2 = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.crud_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_crud;
        private MetroFramework.Controls.MetroButton btn_close;
        private MetroFramework.Controls.MetroButton btn_minimize;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_produto;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_preco;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_quantidade;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_peso;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cbx_categoria;
        private MetroFramework.Controls.MetroComboBox cbx_fornecedor;
        private MetroSet_UI.Controls.MetroSetListBox metroSetListBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btn_salvar;
        private MetroFramework.Controls.MetroButton btn_excluir;
        private MetroFramework.Controls.MetroButton btn_limpar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_descricao;
    }
}

