
namespace WindowsFormsApp1
{
    internal class Grades
    {
        private int id { get; set; }
        private double Math { get; set; }
        private double Physics { get; set; }
        private double Chemistiry { get; set; }
        private double Biology { get; set; }
        private double English { get; set; }
        private double History { get; set; }
        public Grades(int id, double Math, double Physics, double Chemistiry, double Biology, double English, double History)
        {
            this.id = id;
            this.Math = Math;
            this.Physics = Physics;
            this.English = English;
            this.History = History;
            this.Biology = Biology;
            this.Chemistiry = Chemistiry;
        }

        public int GetId() { return id; }
        public double GetMath() { return Math; }
        public double GetChemistiry() { return Chemistiry; }
        public double GetBiology() { return Biology; }
        public double GetPhysics() { return Physics; }
        public double GetHistory() { return History; }
        public double GetEnglish() { return English; }

    }
}
