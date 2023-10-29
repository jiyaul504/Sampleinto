namespace Sampleinto.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
       

        // Additional properties
        public string Major { get; set; }  // Student's major
        public double CGPA { get; set; }    // Grade Point Average
        public int Grade { get; set; }     // Current grade level
    }

}
