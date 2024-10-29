

namespace IFSPStore.Domain.Base
{
    public abstract class BaseEntity<TID>
    {
        protected BaseEntity()
        {
            
        }

        protected BaseEntity(TID id) 
        { 
            Id = id;
        }

        public TID? Id { get; set; }
    }
}
