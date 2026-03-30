namespace Cafe.Model
{
    public class Meal : EFModel                     //Заказ
    {                                               //
        public string Type { get; set; }	        //Категория\тип(напитки,десерты...)
        public string Description { get; set; }     //Описание
        public string Contains { get; set; }   	    //Состав
        public double Price { get; set; }           //Цена(рубли)
        public double Weight { get; set; }	        //Вес(кг)
        public string Status { get; set; }          //Статус
                                                    //Конструктор заказа (снизу)
        public Meal(string name, string type, string description, string contains, double price, double weight, string status)
        {
            Name = name;
            Type = type;
            Description = description;
            Contains = contains;
            Price = price;
            Weight = weight;
            Status = status;
        }
    }
}
