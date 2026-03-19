namespace Cafe.Model
{
    public class Order : EFModel                    //Заказ
    {                                               //
        public int NumberOrder { get; set; }        //Номер заказа
        public string OrderContains { get; set; }   //Содержимое заказа
        public double TotalAmount { get; set; }     //Счет
        public string Status { get; set; }          //Статус
    }
}
