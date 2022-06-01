using System.Collections.Generic;

namespace SisFin
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public int Status { get; set; }

        public List<Categoria> _lstCategoria = new List<Categoria>();

        public Categoria()
        {

        }

        public Categoria(int id, string nome, string descricao, int tipo, int status)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Tipo = tipo;
            Status = status;
        }

        public void AddToList(int id, string nome, string descricao, int tipo, int status)
        {
            _lstCategoria.Add(new Categoria(id, nome, descricao, tipo, status));
        }

        public List<Categoria> ToList()
        {
            return _lstCategoria;
        }

        public List<Categoria> GeraCategorias()
        {
            AddToList(1, "Salário", "Salário da UNICAMP", 1, 1);

            AddToList(1, "Combustível", "Despesas com combustível", 2, 1);
            return _lstCategoria;
        }
    }
}