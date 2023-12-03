using Microsoft.AspNetCore.Mvc.Rendering;

namespace Recruitment_Angels.Models
{

    public class QualificationsTable
    {
        public string Institution { get; set; }
        public string InstitutionLocation { get; set; }
        public string Qualification { get; set; }
        public int LineOrderQual { get; set; }
        public DateTime AcquiredDate { get; set; }
        public bool InProgressEducation { get; set; }

    }

    public class Qualifications
    {
        public IList<QualificationsTable> Table { get; set; }
    }

}

