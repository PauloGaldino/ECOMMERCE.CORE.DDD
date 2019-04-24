using System.Collections.Generic;

namespace Domain.Entities.Vendas
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string NomeCategoria { get; set; }
        public string Descricao { get; set; }
        public List<Bebida> Bebidas { get; set; }
    }
}
