using HRM.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AURA.Models
{
    public class Candidates
    {
        [Key]
        public Guid CandidateId { get; set; }// guid is a return type like int its create the randome different numbers upto 16 digits.
        public string CadidateCurrentAddress { get; set; }
        public string CadidatePermanentAddress { get; set; }
        public string Experiance { get; set; }
        public string Domain { get; set; }
       
        public Guid ParsonId { get; set; }
        [ForeignKey("ParsonId")]
        public Parsons ParsonData { get; set; }






    }
}
