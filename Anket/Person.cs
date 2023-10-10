namespace Anket
{
    internal class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string fathername { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public DateTime birthday { get; set; }
        public string gender { get; set; }

        public Person(string name_, string surname_, string father_name_, string country_, string city_, string phone_, DateTime birthday_, string gender_)
        {
            name = name_;
            surname = surname_;
            fathername = father_name_;
            country = country_;
            city = city_;
            phone = phone_;
            birthday = birthday_;
            gender = gender_;
        }
    }
}
