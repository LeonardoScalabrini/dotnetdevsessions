using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Validation
{
    class ProductNameValidation : ChainOfResponsibility<Product>
    {
        public override Product Handle(Product request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                throw new ArgumentException("Nome não pode ser nulo ou vazio");
            }
            return base.Handle(request);
        }
    }
}
