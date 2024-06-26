using System.Reflection.PortableExecutable;

namespace HRM.Models
{
    public class Parsons
    {
        public Guid Parson_id { get; set; }// guid is a return type like int its create the randome different numbers upto 16 digits.
        public string FullName { get; set; } = string.Empty;
        public string genger { get; set; } = "";
        public string Address { get; set; } = "";
        public string WhoToMeet { get; set; } = "";
        public string purpose { get; set; } = "";
        public string Email { get; set; } = string.Empty;
        public decimal Phone_no { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}
