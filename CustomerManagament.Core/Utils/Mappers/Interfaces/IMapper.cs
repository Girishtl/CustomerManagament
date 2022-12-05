namespace CustomerManagament.Core.Utils.Mappers.Interfaces
{
    public interface IMapper<TRequest,TResponse>
    {
        TResponse Map(TRequest request);
    }
}
