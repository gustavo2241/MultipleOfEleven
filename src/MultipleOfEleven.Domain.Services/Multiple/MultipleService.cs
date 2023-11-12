using MultipleOfEleven.Domain.Models;

namespace MultipleOfEleven.Domain.Services.Multiple
{
    public class MultipleService : IMultipleService
    {
        public Result IsMultiple(Numbers obj)
        {
            try
            {
                var listResult = new Result();

                foreach (var number in obj.numbers)
                {
                    string numberString = number.ToString();

                    int sumOdd = 0;
                    int sumEven = 0;

                    for (int i = 0; i < numberString.Length; i++)
                    {
                        int dig = int.Parse(numberString[i].ToString());

                        if (i % 2 == 0)
                        {
                            sumEven += dig;
                        }
                        else
                        {
                            sumOdd += dig;
                        }
                    }

                    int dif = Math.Abs(sumEven - sumOdd);
                    var result =  dif % 11 == 0;

                    var responseNumbers = new ResponseNumbers(number, result);
                    listResult.result.Add(responseNumbers);
                }

                return listResult;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}