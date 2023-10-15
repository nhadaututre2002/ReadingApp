namespace Backend.Dto.Users
{
    public class UserPriceDto
    {
        public int Users_id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Users_Password { get; set; }
        public string Country { get; set; }
        public int TotalPrice { get; set; }
    }
}
