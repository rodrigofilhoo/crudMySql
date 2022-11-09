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
        //FornecedorBLL objFornBLL = new FornecedorBLL();
        //CategoriaBLL objCategBLL = new CategoriaBLL();
        private void carregar_dgv()
        {
            dataGridView1.DataSource = objProdutoBLL.ListarProdutos();
        }
        private void carregar_categora()
        {
            cbx_categoria.DataSource = objCategBLL.ListarCategorias();
        }

    }
}
