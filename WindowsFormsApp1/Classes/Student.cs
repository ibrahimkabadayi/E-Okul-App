
namespace WindowsFormsApp1
{
    public class Student
    {
        private int id { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private int age { get; set; }
        private string password { get; set; }
        public Student(int id, string name, string surname, int age, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.password = password;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public int getAge() { return age; }
        public string getSurname() { return surname; }
        public string getPassword() { return password; }
    }
}
