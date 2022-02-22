using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Validation
{
    class EntityIdValidation<T> : ChainOfResponsibility<T> where T : Entity
    {
        public override T Handle(T request)
        {
            if (request.Id <= 0)
            {
                throw new ArgumentException("Id não pode ser menor ou igual a zero");
            }
            return base.Handle(request);
        }
    }
}
