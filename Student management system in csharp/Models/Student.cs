namespace StudentManagementSystem.Models
{
    class Student
    {
        public int StudentID { get; set; }
        public string RollNo { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        public decimal CGPA { get; set; }
    }
}