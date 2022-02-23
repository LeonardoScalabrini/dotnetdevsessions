using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; }

        public int CategoryId { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public int Stock { get; private set; }

        public string Image { get; private set; }

        public Category Category { get; private set; }

        public Product(int id, string name, int categoryId, string description, decimal price, int stock, string image, Category category)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
            Category = category;
            new ProductDescriptionValidation()
                .SetNext(new ProductImageValidation())
                .SetNext(new ProductNameValidation())
                .SetNext(new ProductPriceValidation())
                .SetNext(new ProductStockValidation())
                .SetNext(new EntityIdValidation<Product>())
                .Handle(this);
        }
    }
}
