using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade()
        {            
        }

        public Cidade(int id, string nome, string estado)
        {
            this.Id = id;
            this.Nome = nome;
            this.Estado = estado;
        }

        public string? Nome { get; set; }
        public string? Estado { get; set; }
    }
   
}
