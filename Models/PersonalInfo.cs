namespace Recruitment_Angels.Models
{
    public class PersonalInfo
    {
        public IList<Table> Table { get; set; }
    }

    public class Table
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string altEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string altPhoneNumber { get; set; }
        public string DOB { get; set; }
        public string PhotoPath { get; set; }
        public int Status { get; set; }
        public DateTime DateApplied { get; set; }
        public string Gender { get; set; }
        public string CandidateDescription { get; set; }
        public bool PublicView { get; set; }
        public int Sector { get; set; }
        public string JobTitle { get; set; }
        public string AcademicLevel { get; set; }
        public string MinimumSalary { get; set; }
        public int LineOrder { get; set; }
    }
}
