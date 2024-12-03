namespace IFSPStore.App.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public string? UnidadeVenda { get; set; }
        public int? IdGrupo { get; set; }
        public string? Grupo { get; set; }
    }
}
