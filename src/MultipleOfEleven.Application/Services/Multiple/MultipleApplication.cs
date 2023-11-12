using MultipleOfEleven.Application.Dtos;
using MultipleOfEleven.Application.Models;
using MultipleOfEleven.Domain.Models;
using MultipleOfEleven.Domain.Services.Multiple;

namespace MultipleOfEleven.Application.Services.Multiple
{
    public class MultipleApplication : IMultipleApplication
    {
        private readonly IMultipleService _multipleService;

        public MultipleApplication(IMultipleService multipleService)
        {
            _multipleService = multipleService;
        }

        public Result IsMultipleOfEleven(PostNumbersModel obj)
        {
            return _multipleService.IsMultiple(obj.ToMultiple());
        }
    }
}
