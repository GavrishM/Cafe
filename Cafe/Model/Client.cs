namespace Cafe.Model
{
    public class Client : EFModel           //Клиент
    {                                       //
        public string FullName { get; set; }//ФИО
        public string Email { get; set; }  //Почта
        public string Phone {  get; set; } //Номер телефона
        public int Age { get; set; }       //Возвраст
                                            //Конструктор (снизу)
        public Client(string fullName, string email, string phone, int age)
        {
            FullName = fullName;
            Email = email;
            Phone = phone;
            Age = age; 
        }
        public Client() 
        {
            FullName = "";
            Email = "";
            Phone = "";
            Age = 0;
        }
    }
}
