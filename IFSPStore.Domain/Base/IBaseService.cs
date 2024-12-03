using FluentValidation;

namespace IFSPStore.Domain.Base
{
    public interface IBaseService<TEntity> where TEntity : IBaseEntity
    {
        public void AttachObject(object obj);

        TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;

        void Delete(int id);

        IEnumerable<TOutputModel> Get<TOutputModel>(bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class;

        TOutputModel GetById<TOutputModel>(int id, bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class;

        TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;


    }
}
