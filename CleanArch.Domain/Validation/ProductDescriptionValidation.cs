using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Validation
{
    class ProductDescriptionValidation : ChainOfResponsibility<Product>
    {
        public override Product Handle(Product request)
        {
            if (string.IsNullOrEmpty(request.Description))
            {
                throw new ArgumentException("Descrição não pode ser nulo ou vazio");
            }
            return base.Handle(request);
        }
    }
}
