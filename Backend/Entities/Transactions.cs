namespace Backend.Entities
{
    public class Transactions
    {
        public int Transaction_id { get; set; }
        public int Users_id { get; set; }
        public int Books_id { get; set; }
        public int Amout { get; set; }
        public string Rating { get; set; }
        public string Comment { get; set; }
        public string Transactions_Status { get; set; }
        public int Invoice_id { get; set; }

    }
}
