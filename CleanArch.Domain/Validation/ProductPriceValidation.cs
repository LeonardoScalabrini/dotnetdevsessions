using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Validation
{
    class ProductStockValidation : ChainOfResponsibility<Product>
    {
        public override Product Handle(Product request)
        {
            if (request.Stock < 0)
            {
                throw new ArgumentException("Estoque não pode ser negativo");
            }
            return base.Handle(request);
        }
    }
}
