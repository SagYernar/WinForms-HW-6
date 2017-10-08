using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace WindowsFormsApp5
{
    public partial class InformBuro : Form
    {
        List<User> users = new List<User>();
        User user = new User();
        BinaryFormatter formater = new BinaryFormatter();
        int index=0;

        public InformBuro()
        {
            InitializeComponent();
            maleComboBox.Items.AddRange(new string[]
            {
                "Мужчина",
                "Женщина"
            });
            familyComboBox.Items.AddRange(new string[]
            {
                "Свободный человек",
                "Человек в оковах брака"
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if ( !(String.IsNullOrEmpty(surnameTextBox.Text) ||
                 String.IsNullOrEmpty(nameTextBox.Text) ||
                 String.IsNullOrEmpty(fatherNameTextBox.Text) ||
                 String.IsNullOrEmpty(maleComboBox.Text) ||
                 String.IsNullOrEmpty(familyComboBox.Text)) &&
                 (surnameTextBox.Text != "Фамилия" ||
                 nameTextBox.Text != "Имя" ||
                 fatherNameTextBox.Text != "Отчество") )
            {
                user.Surname = surnameTextBox.Text;
                user.Name = nameTextBox.Text;
                user.FatherName = fatherNameTextBox.Text;
                user.DateOfBirth = dateOfBirthTimePicker.Value;
                user.Male = maleComboBox.Text;
                user.Family = familyComboBox.Text;
                users.Add(user);
                Save();
            }
        }

        private void Save()
        {
            using (FileStream stream = new FileStream("users.bin", FileMode.OpenOrCreate))
            {
                formater.Serialize(stream, users);
            }
        }

        private void TakeUsers()
        {
            using (FileStream stream = new FileStream("users.bin", FileMode.OpenOrCreate))
            {
                formater.Deserialize(stream);
            }
        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            if (users.Count != 0)
            {
                if (index > 0)
                {
                    index--;
                }
                surnameLabel.Text = users[index].Surname;
                nameLabel.Text = users[index].Name;
                fatherNameLabel.Text = users[index].FatherName;
                dateOfBirthLabel.Text = users[index].DateOfBirth.ToShortDateString();
                maleLabel.Text = users[index].Male;
                familyLabel.Text = users[index].Family;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (users.Count != 0)
            {
                if (index < users.Count-1)
                {
                    index++;
                }
                surnameLabel.Text = users[index].Surname;
                nameLabel.Text = users[index].Name;
                fatherNameLabel.Text = users[index].FatherName;
                dateOfBirthLabel.Text = users[index].DateOfBirth.ToShortDateString();
                maleLabel.Text = users[index].Male;
                familyLabel.Text = users[index].Family;
            }
        }
    }
}
