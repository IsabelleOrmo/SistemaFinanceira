using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
    class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Id_Categoria { get; set; }
        public int Status { get; set; }

        public List<Conta> _lstConta = new List<Conta>();

        public List<Conta> toList() { return _lstConta; }

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
            _lstConta.Add(new Conta(id, nome, descricao, id_Categoria, status));
        }

        public void addToList(Conta conta)
        {
            _lstConta.Add(conta);
        }

        public List<Conta> GeraContas()
        {
            addToList(1, "Salário monitoria", "Valor correspondente ao salário das monitorias", 0, 1);
            addToList(2, "Transporte", "Valor da mensalidade do ônibus fretado", 1, 1);
            return _lstConta;
        }
    }
}
