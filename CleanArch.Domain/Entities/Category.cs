using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }

        public Category(string name)
        {
            Name = name;
            new CategoryNameValidation().Handle(this);
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            new CategoryNameValidation().
                SetNext(new EntityIdValidation<Category>()).Handle(this);
        }
    }
}
