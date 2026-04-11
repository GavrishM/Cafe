using System.ComponentModel.DataAnnotations;

namespace Cafe.Model
{
    public class Order : EFModel                             //Заказ
    {                                                        //
        [Required(ErrorMessage = "Необходимо заполнить номер заказа")]
        public int NumberOrder { get; set; }                 //Номер заказа
        //public List<Meal> Contains { get; set; } = new();    //Содержимое заказа
        public double TotalAmount { get; set; }              //Счет
        public string Status { get; set; }                   //Статус
                                                             //Конструктор заказа (снизу)
        public Order(int numberOrder, /*List<Meal> contains, */double totalAmount, string status)
        {
            NumberOrder = numberOrder;
            //Contains = contains;
            TotalAmount = totalAmount;
            Status = status;
        }
        public Order() { }
    }
}
