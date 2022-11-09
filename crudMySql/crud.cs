using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using crudMySql.DTO;
using crudMySql.BLL;

namespace MetroSetUi
{
    public partial class crud : MetroSetForm
    {
        public crud()
        {
            InitializeComponent();
        }

        private void crud_Load(object sender, EventArgs e)
        {
            carregar_categora();
            carregar_fornecedor();
            carregar_dgv();
        }
        ProdutoDTO objProdutoDTO = new ProdutoDTO();
        ProdutoBLL objProdutoBLL = new ProdutoBLL();
        FornecedorBLL objFornBLL = new FornecedorBLL();
        CategoriaBLL objCategBLL = new CategoriaBLL();
        private void carregar_dgv()
        {
            dataGridView1.DataSource = objProdutoBLL.ListarProdutos();
        }
        private void carregar_categora()
        {
            cbx_categoria.DataSource = objCategBLL.ListarCategorias();
            cbx_categoria.DisplayMember = "descricao";
            cbx_categoria.ValueMember = "id";
        }
        private void carregar_fornecedor()
        {
            cbx_fornecedor.DataSource = objFornBLL.ListarCategorias();
            cbx_fornecedor.DisplayMember = "descricao";
            cbx_fornecedor.ValueMember = "id";
        }
        private void LimparComponentes()
        {
            txt_peso.Clear();
            txt_preco.Clear();
            txt_produto.Clear();
            txt_quantidade.Clear();
            txt_descricao.Clear();
            cbx_categoria = null;
            cbx_fornecedor = null;
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                objProdutoDTO.Preco = double.Parse(txt_preco.Text);
                objProdutoDTO.Peso = double.Parse(txt_peso.Text);
                objProdutoDTO.Descricao = txt_descricao.Text;
                objProdutoDTO.Quantidade = int.Parse(txt_quantidade.Text);
                objProdutoDTO.Tbl_categoria_id = Convert.ToInt32(cbx_categoria.SelectedValue);
                objProdutoDTO.Tbl_fornecedor_id = Convert.ToInt32(cbx_fornecedor.SelectedValue);

                if (txt_produto.Text = "")
                {

                }
            }
            catch
            {

            }
        }
    }
}
