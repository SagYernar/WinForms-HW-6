using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Фамилия
//¦ Имя
//¦ Отчество
//¦ Пол
//¦ Год и дата рождения
//¦ Семейный статус
//¦ Дополнительная информация

namespace WindowsFormsApp5
{
    [Serializable]
    public class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Male { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Family { get; set; }

    }
}
