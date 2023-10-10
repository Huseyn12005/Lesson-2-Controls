using System.Text.Json;
using Newtonsoft.Json;
namespace Anket
{

    public partial class Anket : Form
    {
        string? name_, surname_, father_, country_, city_, phone_, gender_;
        DateTime birthday_;
        List<Person>? persons = new List<Person>();
        public Anket()
        {
            InitializeComponent();
        }

        private void Name_Text_TextChanged(object sender, EventArgs e)
        {
            name_ = Name_Text.Text;
        }

        private void Surname_Text_TextChanged(object sender, EventArgs e)
        {
            surname_ = Surname_Text.Text;
        }

        private void Father_Text_TextChanged(object sender, EventArgs e)
        {
            father_ = Father_Text.Text;
        }

        private void Country_Text_TextChanged(object sender, EventArgs e)
        {
            country_ = Country_Text.Text;
        }

        private void City_Text_TextChanged(object sender, EventArgs e)
        {
            city_ = City_Text.Text;
        }

        private void Phone_Text_TextChanged(object sender, EventArgs e)
        {
            phone_ = Phone_Text.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            birthday_ = dateTimePicker1.Value;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Male.Checked) { gender_ = Male.Text; }
            else if (Female.Checked) { gender_ = Female.Text; }

            if (Name_Text.Text != "" && Surname_Text.Text != "" && Father_Text.Text != "" && Country_Text.Text != "" && City_Text.Text != "" && Phone_Text.Text != "" && (Male.Checked || Female.Checked))
            {
                Person person = new Person(name_!, surname_!, father_!, country_!, city_!, phone_!, birthday_, gender_!);
                persons.Add(person);
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string JsonPerson = System.Text.Json.JsonSerializer.Serialize(persons, options);
                File.WriteAllText($"../../../persons.json", JsonPerson);
            }
        }

        private void Anket_Load(object sender, EventArgs e)
        {
            string jsonFilePath = $"../../../persons.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                persons = JsonConvert.DeserializeObject<List<Person>>(jsonContent);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (persons != null)
            {
                foreach (var item in persons)
                {
                    if (item.name == textBox1.Text)
                    {
                        Name_Text.Text = item.name;
                        Surname_Text.Text = item.surname;
                        Father_Text.Text = item.fathername;
                        Country_Text.Text = item.country;
                        City_Text.Text = item.city;
                        Phone_Text.Text = item.phone;
                        dateTimePicker1.Value = item.birthday;
                        if (item.gender == "Male")
                            Male.Checked = true;
                        else if(item.gender == "Female")
                            Female.Checked = true;

                    }
                }
            }
        }
    }
}