
namespace WindowsFormsApp1
{
    internal class Teacher
    {
        private int id { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private string subject { get; set; }
        private string password { get; set; }
        public Teacher(int id, string name, string surname, string subject, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.subject = subject;
            this.password = password;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public string getSubject() { return subject; }
        public string getSurname() { return surname; }
        public string getPassword() { return password; }
    }
}
