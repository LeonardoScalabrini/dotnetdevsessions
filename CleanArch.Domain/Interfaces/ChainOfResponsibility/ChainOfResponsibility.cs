namespace CleanArch.Domain.Validation
{
    public abstract class ChainOfResponsibility<T> : IHandler<T>
    {
        private IHandler<T>? NextHandler;

        public IHandler<T> SetNext(IHandler<T> handler)
        {
            NextHandler = handler;
            return handler;
        }

        public virtual T Handle(T request)
        {
            if (NextHandler != null)
                return NextHandler.Handle(request);

            return request;
        }
    }
}
