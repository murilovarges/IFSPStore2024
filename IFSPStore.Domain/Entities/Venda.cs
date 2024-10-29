using System.Text.Json.Serialization;
using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda()
        {
            Items = new List<VendaItem>();
        }

        public Venda(int id, DateTime data, float valorTotal, Usuario? usuario, Cliente? cliente, 
            List<VendaItem> items) : base(id)
        {
            Data = data;
            ValorTotal = valorTotal;
            Usuario = usuario;
            Cliente = cliente;
            Items = items;
        }

        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual List<VendaItem> Items { get; set; }
    }

    public class VendaItem : BaseEntity<int>
    {
        public VendaItem()
        {

        }

        public VendaItem(int id, Produto? produto, int quantidade, float valorUnitario, float valorTotal, Venda? venda) : base(id)
        {
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            Venda = venda;
        }

        public virtual Produto? Produto { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }
        [JsonIgnore]
        public virtual Venda? Venda { get; set; }
    }
}