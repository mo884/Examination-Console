
namespace Examination.BL.Generic.Quieries.Abstraction
{
    public interface IGetById<T,G>where T : class
    {
        T GetById(G modelVm);
    }
}
