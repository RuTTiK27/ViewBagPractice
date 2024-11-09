namespace ViewBagPractice.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        //public string email { get; set; }
        //public string phone { get; set; }
        //public string city { get; set; }
        //public string state { get; set; }
        //public string country { get; set; }
        //public string phoneNumber { get; set; }
        //public string cityNumber { get; set; }
        //public string stateNumber { get; set; }
        //public string countryNumber { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student> 
            { 
                new Student { id=1,name="Rutvik",age=23},
                new Student { id=2,name="Karo",age=22},
                new Student { id=3,name="Kaka",age=32}
            };
        }
    }
}
