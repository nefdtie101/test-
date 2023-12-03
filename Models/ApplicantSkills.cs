using Microsoft.AspNetCore.Mvc.Rendering;
namespace Recruitment_Angels.Models
{
    public class ApplicantSkills
    {
        public IList<ApplicantSkillsTable> Table { get; set; }
    }
    public class ApplicantSkillsTable
    {
        public string SkillName { get; set; }
        public int proficiency { get; set; }
    }
}
