
using Cafe.Model;
using System.ComponentModel.DataAnnotations;
namespace XUnitTestProject.Model
{
    public class ClientTests
    {
        [Fact]
        public void TConstructor()
        {
            //p1
            {
                string fullName = "fullName1";
                string email = "email1";
                string phone = "phone1";
                int age = 19;

                Client client = new Client(fullName, email, phone, age);

                Assert.True(fullName == client.FullName);
                Assert.True(email == client.Email);
                Assert.True(phone == client.Phone);
                Assert.True(age == client.Age);
            }//p1
             //p2
            {
                string fullName = "fullName2";
                string email = "email2";
                string phone = "phone2";
                int age = 20;

                Client client = new Client(fullName, email, phone, age);

                Assert.True(fullName == client.FullName);
                Assert.True(email == client.Email);
                Assert.True(phone == client.Phone);
                Assert.True(age == client.Age);
            }//p2
             //p3
            {
                string fullName = "fullName3";
                string email = "email3";
                string phone = "phone3";
                int age = 18;

                Client client = new Client(fullName, email, phone, age);

                Assert.True(fullName == client.FullName);
                Assert.True(email == client.Email);
                Assert.True(phone == client.Phone);
                Assert.True(age == client.Age);
            }//p3
             //empty constructor
            {
                Client client = new Client();

                Assert.True("" == client.FullName);
                Assert.True("" == client.Email);
                Assert.True("" == client.Phone);
                Assert.True(0 == client.Age);
            }//empty constructor
        }

        [Fact]
        public void Client_WithValidData_ShouldBeValid()
        {
            // Создаем объект клиента с валидными значениями.
            Client client = new Client
            {
                FullName = "Igoref Igor Igorevich",     // Обязательное поле
                Email = "Igoref",
                Phone = "+79707654345",
                Age = 23
            };

            // Создаем контекст валидации на основе объекта
            var context = new ValidationContext(client);

            // Сюда будут записаны ошибки валидации, если они есть
            var result = new List<ValidationResult>();

            // Проводим валидацию объекта с учетом всех атрибутов [Required], [Range] и т.п.
            var isValid = Validator.TryValidateObject(client, context, result, true);

            // Ожидаем, что валидация прошла успешно (все поля корректны)
            Assert.True(isValid);

            // Также убеждаемся, что список ошибок пуст
            Assert.Empty(result);
        }

        [Fact]
        public void Client_WithInvalidFullName_ShouldBeInvalid()
        {
            // Arrange
            Client client = new Client(null, "...@gmail.com", "+7897889898", 23);

            var context = new ValidationContext(client);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(client, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage.Contains("Необходимо заполнить ФИО"));
        }
    }
}
