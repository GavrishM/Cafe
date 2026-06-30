using Cafe.Data;
using Cafe.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

                Assert.True("" == meal.Name);
                Assert.True("" == meal.Type);
                Assert.True("" == meal.Description);
                Assert.True("" == meal.Contains);
                Assert.True(0 == meal.Price);
                Assert.True(0 == meal.Weight);
                Assert.True("" == meal.Status);
            }//empty constructor
        }

        [Fact]
        public void Meal_WithValidData_ShouldBeValid()
        {
            // Создаем объект клиента с валидными значениями.
            Meal meal = new Meal
            {
                Name = "Борщ",     // Обязательное поле
                Type = "Суп",
                Description = "Суп из...",
                Contains = "Вода...",
                Price = 50,
                Weight = 1,
                Status = "В наличии"
            };

            // Создаем контекст валидации на основе объекта
            var context = new ValidationContext(meal);

            // Сюда будут записаны ошибки валидации, если они есть
            var result = new List<ValidationResult>();

            // Проводим валидацию объекта с учетом всех атрибутов [Required], [Range] и т.п.
            var isValid = Validator.TryValidateObject(meal, context, result, true);

            // Ожидаем, что валидация прошла успешно (все поля корректны)
            Assert.True(isValid);

            // Также убеждаемся, что список ошибок пуст
            Assert.Empty(result);
        }

        [Fact]
        public void Meal_WithInvalidName_ShouldBeInvalid()
        {
            // Arrange
            Meal meal = new Meal(null, "Суп", "Суп из...", "Вода...", 50, 1, "В наличии");

            var context = new ValidationContext(meal);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(meal, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage.Contains("Необходимо заполнить название"));
        }
    }
}
