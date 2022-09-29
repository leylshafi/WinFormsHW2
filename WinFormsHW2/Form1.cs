using System.Globalization;

namespace WinFormsHW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<User> users = new List<User>();

        private void button1_Click(object sender, EventArgs e)
        {
            string gender="";
            foreach (Control c in Genders.Controls)
            {
                if (c is RadioButton ch && ch.Checked)
                {

                    gender = c.Text;
                }
            }
            User user = new User(TxtName.Text, TxtSurname.Text, TxtFatherName.Text, TxtCountry.Text, TxtCity.Text, TxtPhone.Text, TxtBirthday.Value.ToString(), gender);
            users.Add(user);
            MessageBox.Show(user.ToString());

            var jsonString = System.Text.Json.JsonSerializer.Serialize(users);
            File.WriteAllText("Users.json", jsonString);
            TxtName.Text = null;
            TxtSurname.Text = null;
            TxtFatherName.Text = null;
            TxtCountry.Text = null;
            TxtCity.Text = null;
            TxtPhone.Text = null;
            TxtBirthday.Text = null;
            foreach (Control c in Genders.Controls)
            {
                if (c is RadioButton ch && ch.Checked)
                {

                   ch.Checked = false;
                }
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {

            using FileStream fs = new FileStream("Users.json", FileMode.Open);
            users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(fs);

            for (int i = 0; i < users.Count; i++)
            {
                if(SearchName.Text==users[i].Name)
                {
                    TxtName.Text = users[i].Name;
                    TxtSurname.Text = users[i].Surname;
                    TxtFatherName.Text = users[i].FatherName;
                    TxtCountry.Text = users[i].Country;
                    TxtCity.Text = users[i].City;
                    TxtPhone.Text = users[i].Phone;
                    TxtBirthday.Value= DateTime.Parse(users[i].Birthday);
                    if (users[i].Gender=="Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else radioButton2.Checked = true;
                }
            }
        }
    }
}