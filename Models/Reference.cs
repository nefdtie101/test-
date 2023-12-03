using Microsoft.AspNetCore.Mvc.Rendering;
namespace Recruitment_Angels.Models
{
    public class reference
    {
        public IList<referenceTable> Table { get; set; }
    }
    public class referenceTable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
