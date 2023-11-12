namespace MultipleOfEleven.Domain.Models
{
    public class Result
    {
        public List<ResponseNumbers> result { get; private set; } = new List<ResponseNumbers>();
    }

    public class ResponseNumbers
    {
        public ResponseNumbers(string number, bool isMultiple)
        {
            this.number = number;
            this.isMultiple = isMultiple;
        }

        public string number { get; private set; }
        public bool isMultiple { get; private set; }
    }
}
