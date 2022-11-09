using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using crudMySql.DTO;
using DAL;

namespace crudMySql.BLL
{
    class ProdutoBLL
    {
        Conexao objDAL = new Conexao();
        string tabela = "tbl_produto";
        public void InserirProduto(ProdutoDTO objProdutoDTO)
        {
            string sql = String.Format($@"insert into {tabela} values(null,
                        '{objProdutoDTO.Descricao}',
                        '{objProdutoDTO.Preco.ToString().Replace(',', '.')}',
                        '{objProdutoDTO.Quantidade}',
                        '{objProdutoDTO.Peso}',
                        '{objProdutoDTO.Tbl_categoria_id}',
                        '{objProdutoDTO.Tbl_fornecedor_id}'");
            objDAL.ExecutarComando(sql);
        }
        public void ExcluirProduto(ProdutoDTO objDTO)
        {
            string sql = $"delete from {tabela} where id = {objDTO.Id}";
            objDAL.ExecutarComando(sql);
        }
        public void alterar_produto(ProdutoDTO objDTO)
        {
            string sql = String.Format($@"update {tabela}
                            set descricao         = '{objDTO.Descricao}'
                                preco             = '{objDTO.Preco}'
                                quantidade        = '{objDTO.Quantidade}'
                                peso              = '{objDTO.Peso}'
                                tbl_categoria_id  = '{objDTO.Tbl_categoria_id}'
                                tbl_fornecedor_id = '{objDTO.Tbl_fornecedor_id}'
                            where id = '{objDTO.Id}';");
            objDAL.ExecutarComando(sql);
        }
        public DataTable ListarProdutos()
        {
            return objDAL.ExecutarConsulta($"select * from {tabela} order by descricao;");
        }
        public DataTable ListarProdutos(string condicao)
        {
            string pesquisa = $"select * from {tabela} where {condicao};";
            return objDAL.ExecutarConsulta(pesquisa);
        }
    }
}
