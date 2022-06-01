using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
    class Conta
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private int Id_Categoria { get; set; }
        private int Status { get; set; }

        private List<Conta> lstConta = new List<Conta>();

        public List<Conta> toList() { return lstConta; }

        public Conta() { }

        public Conta(int id, string nome, string descricao, int id_Categoria, int status)
        {
            Id = id;
            Descricao = descricao;
            Id_Categoria = id_Categoria;
            Status = status;
            Nome = nome;
        }

        public void addToList(int id, string nome, string descricao, int id_Categoria, int status)
        {
            lstConta.Add(new Conta(id, nome, descricao, id_Categoria, status));
        }

        public List<Conta> GeraContas()
        {
            addToList(1, "HRT", "Valor para ter uma vida minimamente decente", 4, 1);
            addToList(2, "Transporte", "Valor da mensalidade do ônibus fretado", 2, 1);

            return lstConta;
        }
    }
}
