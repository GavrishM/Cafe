using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe.Model;

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
    }
}
