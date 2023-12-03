using Microsoft.AspNetCore.Mvc.Rendering;
namespace Recruitment_Angels.Models
{
    public class WorkExperience
    {
        public IList<WorkExperienceTable> Table { get; set; }
    }
    public class WorkExperienceTable
    {
        public string PositionTitle { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public string Summary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LineOrder { get; set; }
        public string Salary { get; set; }
    }
}
