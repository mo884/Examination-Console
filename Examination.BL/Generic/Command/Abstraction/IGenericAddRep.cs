
namespace Examination.BL.Generic.Command.Abstraction
{
    public interface IGenericAddRep<T,G>
    {
        void Add(T item ,G ModelVM);
    }
}
