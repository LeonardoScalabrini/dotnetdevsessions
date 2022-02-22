using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Validation
{
    class ProductPriceValidation : ChainOfResponsibility<Product>
    {
        public override Product Handle(Product request)
        {
            if (request.Price < 0)
            {
                throw new ArgumentException("Preço não pode ser negativo");
            }
            return base.Handle(request);
        }
    }
}
