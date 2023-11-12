using MultipleOfEleven.Domain.Models;

namespace MultipleOfEleven.Domain.Services.Multiple
{
    public interface IMultipleService
    {
        Result IsMultiple(Numbers obj);
    }
}
