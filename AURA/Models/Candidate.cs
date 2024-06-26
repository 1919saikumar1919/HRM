namespace AURA.Models
{
    public class Candidate
    {
        public Guid Candidate_id { get; set; }// guid is a return type like int its create the randome different numbers upto 16 digits.
        public string FirstName { get; set; }=string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string genger { get; set; } = "";
        public string Address { get; set; } = "";
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;
        public decimal Phone_no { get; set; } 
    }
}
