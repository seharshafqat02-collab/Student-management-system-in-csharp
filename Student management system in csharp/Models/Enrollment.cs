namespace StudentManagementSystem.Models
{
    class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public string Grade { get; set; }
        public string EnrollmentDate { get; set; }
    }
}