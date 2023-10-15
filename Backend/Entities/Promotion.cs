namespace Backend.Entities
{
    public class Promotion
    {
        public int Promotion_id { get; set; }
        public string Promotion_Name { get; set; }
        public int Discount_amount { get; set; }
        public DateTime Promotion_Start_date { get; set; }
        public DateTime Promotion_End_date { get; set; }
        public string Promotion_Status { get; set; }

    }
}
