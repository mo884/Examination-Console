
namespace Examination.BL.Generic.Quieries.Abstraction
{
    public interface IGetAllRep<T,G>where T : class
    {
        List<T> GetAllRep(G modelVm );
    }
}
