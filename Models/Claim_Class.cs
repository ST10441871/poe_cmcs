using System;
using System.Collections.Generic; // Added to resolve ICollection<>  

namespace poe_cmcs.Models
{
    public class Claim_Class
    {
        public int LectureId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class SupportingDocument
    {
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }

    public class claim
    {
        public int ClaimId { get; set; }
        public int LectureId { get; set; }
        public DateTime claimed_month { get; set; }
        public double HourRate { get; set; }
        public double TotalHours { get; set; }
        public string Status { get; set; } = "Submit";
        public DateTime Submisson { get; set; } = DateTime.Now;

        public virtual ICollection<SupportingDocument> SupportingDocuments { get; set; } = new List<SupportingDocument>(); 
    }
    public class SupportingDocuments
    {
        public Claim_Class LectureID { get; set; }
        public claim ClaimID { get; set; }

        public string FileName { get; set; }
        public string FilePath { get; set; }


    }
}