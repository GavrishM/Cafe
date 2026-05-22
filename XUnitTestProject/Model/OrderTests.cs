using Cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject.Model
{
    public class OrderTests
    {
        [Fact]
        public void TConstructor()
        {
            //p1
            {
                int numberOrder = 1;
                double totalAmount = 1.5;
                string status = "OK";

                Order order = new Order(numberOrder, totalAmount, status);

                Assert.True(numberOrder == order.NumberOrder);
                Assert.True(totalAmount == order.TotalAmount);
                Assert.True(status == order.Status);
            }//p1
             //p2
            {
                int numberOrder = 2;
                double totalAmount = 1.6;
                string status = "2";

                Order order = new Order(numberOrder, totalAmount, status);

                Assert.True(numberOrder == order.NumberOrder);
                Assert.True(totalAmount == order.TotalAmount);
                Assert.True(status == order.Status);
            }//p2
             //p3
            {
                int numberOrder = 3;
                double totalAmount = 1.7;
                string status = "3";

                Order order = new Order(numberOrder, totalAmount, status);

                Assert.True(numberOrder == order.NumberOrder);
                Assert.True(totalAmount == order.TotalAmount);
                Assert.True(status == order.Status);
            }//p3
             //empty constructor
            {
                Order order = new Order();

                Assert.True(0 == order.NumberOrder);
                Assert.True(0 == order.TotalAmount);
                Assert.True("" == order.Status);
            }//empty constructor
        }
        [Fact]
        public void Order_WithValidData_ShouldBeValid()
        {
            // Создаем объект заказа с валидными значениями.
            Order order = new Order
            {
                NumberOrder = 1,     // Обязательное поле
                TotalAmount = 1.2,
                Status = "OK"
            };

            // Создаем контекст валидации на основе объекта
            var context = new ValidationContext(order);

            // Сюда будут записаны ошибки валидации, если они есть
            var result = new List<ValidationResult>();

            // Проводим валидацию объекта с учетом всех атрибутов [Required], [Range] и т.п.
            var isValid = Validator.TryValidateObject(order, context, result, true);

            // Ожидаем, что валидация прошла успешно (все поля корректны)
            Assert.True(isValid);

            // Также убеждаемся, что список ошибок пуст
            Assert.Empty(result);
        }

        //[Fact]
        //public void Order_WithInvalidFullName_ShouldBeInvalid()
        //{
        //    int? number = null;
        //    // Arrange
        //    Order order = new Order(Convert.ToInt32(number), 1.2, "OK");

        //    var context = new ValidationContext(order);
        //    var results = new List<ValidationResult>();

        //    // Act
        //    var isValid = Validator.TryValidateObject(order, context, results, true);

        //    // Assert
        //    Assert.False(isValid);
        //    Assert.Contains(results, r => r.ErrorMessage.Contains("Необходимо заполнить номер заказа"));
        //}
    }
}
