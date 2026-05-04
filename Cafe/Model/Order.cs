using System.ComponentModel.DataAnnotations;

namespace Cafe.Model
{
    public class Order : EFModel                             //Заказ
    {                                                        //
        [Required(ErrorMessage = "Необходимо заполнить номер заказа")]
        public int NumberOrder { get; set; }                 //Номер заказа
        public double TotalAmount { get; set; }              //Счет
        public string Status { get; set; }                   //Статус
                                                             //Конструктор заказа (снизу)
        public Order(int numberOrder, double totalAmount, string status)
        {
            NumberOrder = numberOrder;
            TotalAmount = totalAmount;
            Status = status;
        }
        public Order()
        {
            NumberOrder = 0;
            TotalAmount = 0;
            Status = "";
        }
    }
}
