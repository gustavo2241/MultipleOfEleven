using MultipleOfEleven.Application.Models;
using MultipleOfEleven.Domain.Models;

namespace MultipleOfEleven.Application.Services.Multiple
{
    public interface IMultipleApplication
    {
        Result IsMultipleOfEleven(PostNumbersModel obj);
    }
}
