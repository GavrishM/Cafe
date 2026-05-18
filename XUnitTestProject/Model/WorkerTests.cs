using Cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject.Model
{
    public class WorkerTests
    {
        [Fact]
        public void TConstructor()
        {
            //p1
            {
                string fullName = "fullName1";
                int age = 19;
                string position = "position1";
                string phone = "phone1";

                Worker worker = new Worker(fullName, age, position, phone);

                Assert.True(fullName == worker.FullName);
                Assert.True(age == worker.Age);
                Assert.True(position == worker.Position);
                Assert.True(phone == worker.Phone);
            }//p1
             //p2
            {
                string fullName = "fullName2";
                int age = 20;
                string position = "position2";
                string phone = "phone2";

                Worker worker = new Worker(fullName, age, position, phone);

                Assert.True(fullName == worker.FullName);
                Assert.True(age == worker.Age);
                Assert.True(position == worker.Position);
                Assert.True(phone == worker.Phone);
            }//p2
             //p3
            {
                string fullName = "fullName3";
                int age = 21;
                string position = "position3";
                string phone = "phone3";

                Worker worker = new Worker(fullName, age, position, phone);

                Assert.True(fullName == worker.FullName);
                Assert.True(age == worker.Age);
                Assert.True(position == worker.Position);
                Assert.True(phone == worker.Phone);
            }//p3
             //empty constructor
            {
                Worker worker = new Worker();

                Assert.True("" == worker.FullName);
                Assert.True(0 == worker.Age);
                Assert.True("" == worker.Position);
                Assert.True("" == worker.Phone);
            }//empty constructor
        }
        [Fact]
        public void Worker_WithValidData_ShouldBeValid()
        {
            // Создаем объект работника с валидными значениями.
            Worker worker = new Worker
            {
                FullName = "Igoref Igor Igorevich",     // Обязательное поле
                Age = 23,
                Position = "Manager",
                Phone = "+79707654345"
            };

            // Создаем контекст валидации на основе объекта
            var context = new ValidationContext(worker);

            // Сюда будут записаны ошибки валидации, если они есть
            var result = new List<ValidationResult>();

            // Проводим валидацию объекта с учетом всех атрибутов [Required], [Range] и т.п.
            var isValid = Validator.TryValidateObject(worker, context, result, true);

            // Ожидаем, что валидация прошла успешно (все поля корректны)
            Assert.True(isValid);

            // Также убеждаемся, что список ошибок пуст
            Assert.Empty(result);
        }

        [Fact]
        public void Worker_WithInvalidFullName_ShouldBeInvalid()
        {
            // Arrange
            Worker worker = new Worker(null, 23, "Manager", "+7897889898");

            var context = new ValidationContext(worker);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(worker, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage.Contains("Необходимо заполнить ФИО"));
        }
    }
}
