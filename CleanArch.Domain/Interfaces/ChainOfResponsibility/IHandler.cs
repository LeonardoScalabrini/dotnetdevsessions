namespace CleanArch.Domain.Validation
{
    public interface IHandler <T>
    {
        IHandler<T> SetNext(IHandler<T> handler);
        T Handle(T request);
    }
}
