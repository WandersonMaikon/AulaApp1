using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Produto
    {
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

    }

}
