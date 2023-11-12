using MultipleOfEleven.Application.Models;
using MultipleOfEleven.Domain.Models;

namespace MultipleOfEleven.Application.Dtos
{
    public static class MultipleApplicationDtoExt
    {
        public static Numbers? ToMultiple(this PostNumbersModel obj)
            => obj is null ? null : new Numbers
            (
                obj.numbers
            );
    }
}
