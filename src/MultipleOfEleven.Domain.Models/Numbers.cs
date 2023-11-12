namespace MultipleOfEleven.Domain.Models
{
    public class Numbers
    {
        public Numbers(string[] numbers)
        {
            this.numbers = numbers;
        }

        public string[] numbers { get; private set; }
    }
}
