using System.ComponentModel.DataAnnotations;

namespace Cafe.Model
{
    public class Worker : EFModel               //Работник
    {                                           //
        [Required(ErrorMessage = "Необходимо заполнить ФИО")]
        public string FullName { get; set; }    //ФИО
        public int Age { get; set; }            //Возвраст
        public string Position { get; set; }    //Должность
        public string Phone { get; set; }       //Номер телефона
                                                //Конструктор (снизу)
        public Worker(string fullName, int age, string position, string phone) 
        {
            FullName = fullName;
            Age = age;
            Position = position;
            Phone = phone;
        }
        public Worker()
        {
            FullName = "";
            Age = 0;
            Position = "";
            Phone = "";
        }
    }
}
