namespace Backend.Entities
{
    public class Invoice
    {
        public int Invoice_id { get; set; }
        public string Invoice_Status { get; set; }
        public string Create_by { get; set; }
        public DateTime Create_date { get; set; }
        public string Delete_by { get; set; }
        public DateTime Delete_date { get; set; }
        public string Update_by { get; set; }
        public DateTime Update_date { get; set; }

    }
}
