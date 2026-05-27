namespace StudentManagementSystem.Models
{
    class Course
    {
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
    }
}