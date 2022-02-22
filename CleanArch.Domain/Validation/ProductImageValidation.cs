using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Validation
{
    class ProductImageValidation : ChainOfResponsibility<Product>
    {
        public override Product Handle(Product request)
        {
            if (request.Image.Length > 250)
            {
                throw new ArgumentException("Imagem deve ter no maximo 250 caracteres");
            }
            return base.Handle(request);
        }
    }
}
