using Cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject.Model
{
    public class MealTests
    {
        [Fact]
        public void TConstructor()
        {
            //p1
            {
                string name = "name1";
                string type = "type1";
                string description = "description1";
                string contains = "contains1";
                double price = 1;
                double weight = 1;
                string status = "OK";

                Meal meal = new Meal(name, type, description, contains, price, weight, status);

                Assert.True(name == meal.Name);
                Assert.True(type == meal.Type);
                Assert.True(description == meal.Description);
                Assert.True(contains == meal.Contains);
                Assert.True(price == meal.Price);
                Assert.True(weight == meal.Weight);
                Assert.True(status == meal.Status);
            }//p1
             //p2
            {
                string name = "name2";
                string type = "type2";
                string description = "description2";
                string contains = "contains2";
                double price = 2;
                double weight = 2;
                string status = "2";

                Meal meal = new Meal(name, type, description, contains, price, weight, status);

                Assert.True(name == meal.Name);
                Assert.True(type == meal.Type);
                Assert.True(description == meal.Description);
                Assert.True(contains == meal.Contains);
                Assert.True(price == meal.Price);
                Assert.True(weight == meal.Weight);
                Assert.True(status == meal.Status);
            }//p2
             //p3
            {
                string name = "name3";
                string type = "type3";
                string description = "description3";
                string contains = "contains3";
                double price = 3;
                double weight = 3;
                string status = "3";

                Meal meal = new Meal(name, type, description, contains, price, weight, status);

                Assert.True(name == meal.Name);
                Assert.True(type == meal.Type);
                Assert.True(description == meal.Description);
                Assert.True(contains == meal.Contains);
                Assert.True(price == meal.Price);
                Assert.True(weight == meal.Weight);
                Assert.True(status == meal.Status);
            }//p3
             //empty constructor
            {
                Meal meal = new Meal();

                Assert.True(null == meal.Name);
                Assert.True(null == meal.Type);
                Assert.True(null == meal.Description);
                Assert.True(null == meal.Contains);
                //Assert.True(null == meal.Price);
                //Assert.True(null == meal.Weight);
                Assert.True(null == meal.Status);
            }//empty constructor
        }
    }
}
