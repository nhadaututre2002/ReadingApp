namespace Backend.Entities
{
    public class Users
    {
        public int Users_id { get; set; }
        public string Username { get; set; }
        public string Users_Password { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public string Subscription_status { get; set; }
        public int Notification_id { get; set; }
        public string Country { get; set; }
    }
}
