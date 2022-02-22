using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Validation
{
    class CategoryNameValidation : ChainOfResponsibility<Category>
    {
        public override Category Handle(Category request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                throw new ArgumentException("Nome não pode ser nulo ou vazio");
            }
            return base.Handle(request);
        }
    }
}
