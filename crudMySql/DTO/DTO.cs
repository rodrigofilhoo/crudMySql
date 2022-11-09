using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudMySql.DTO
{
    class ProdutoDTO
    {
        private int id;
        private string descricao;
        private double preco;
        private int quantidade;
        private double peso;
        private int tbl_categoria_id;
        private int tbl_fornecedor_id;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Descricao
        {
            get { return this.descricao; }
            set
            {
                if (value == "")
                {
                    throw new Exception("A descrição tem que ser preenchida");
                }
                else
                {
                    this.descricao = value;
                }

            }
        }
        public double Preco
        {
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("O preço está incorreto.");
                }
                else
                {
                    this.preco = value;
                }
            }
            get { return this.preco; }
        }
        public int Quantidade
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A quantidade está incorreta ");
                }
                else
                {
                    this.quantidade = value;
                }
            }
            get { return this.quantidade; }
        }

        public double Peso
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O peso está incorreto.");
                }
                else
                {
                    this.peso = value;
                }
            }
            get { return this.peso; }
        }
        public int Tbl_categoria_id
        {
            set { this.tbl_categoria_id = value; }
            get { return this.tbl_categoria_id; }
        }        
        public int Tbl_fornecedor_id
        {
            set { this.tbl_fornecedor_id = value; }
            get { return this.tbl_fornecedor_id; }
        }
    }
}
