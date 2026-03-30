namespace Cafe.Model
{
    public class Order : EFModel                    //Заказ
    {                                               //
        public int NumberOrder { get; set; }        //Номер заказа
        public List<Meal> Contains { get; set; }    //Содержимое заказа
        public double TotalAmount { get; set; }     //Счет
        public string Status { get; set; }          //Статус
                                                    //Конструктор заказа (снизу)
        public Order(int numberOrder, List<Meal> contains, double totalAmount, string status)
        {
            NumberOrder = numberOrder;
            Contains = contains;
            TotalAmount = totalAmount;
            Status = status;
        }
    }
}
