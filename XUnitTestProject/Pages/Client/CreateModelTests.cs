using Cafe.Data;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTestProject.Pages.Client
{
    public class CreateModelTests
    {

        private ApplicationDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new ApplicationDbContext(options);
        }

        [Fact]
        public void CreateModel_Exists()
        {
            /*
                Проверка существования модели.
            */

            var model = new Cafe.Pages.Clients.CreateModel(null!);
            Assert.NotNull(model);
        }

        [Fact]
        public void OnPost_ShouldReturnPage_WhenModelStateIsInvalid()
        {
            /*
                Проверка заполнения ФИО при создании клиента через страницу.
            */

            // Arrange
            var context = GetDbContext();
            var pageModel = new Cafe.Pages.Clients.CreateModel(context);

            pageModel.ModelState.AddModelError("Client.FullName", "Необходимо заполнить ФИО");

            // Act
            var result = pageModel.OnPost();

            // Assert
            object value = result.ShouldBeOfType<PageResult>();
            context.Clients.Count().ShouldBe(0);
        }

        [Fact]
        public void OnPost_ShouldAddBookAndRedirect_WhenModelStateIsValid()
        {
            /*
                Проверка сохранения созданного клиента и перехода на страницу Index.
            */

            // Arrange
            var context = GetDbContext();
            var pageModel = new Cafe.Pages.Clients.CreateModel(context);

            pageModel.Client = new Cafe.Model.Client
            {
                FullName = "Igoref Igor Igorevich",
                Email = "Igoref",
                Phone = "+79707654345",
                Age = 23
            };

            // Act
            var result = pageModel.OnPost();

            // Assert
            result.ShouldBeOfType<RedirectToPageResult>();

            var redirect = result as RedirectToPageResult;
            redirect.PageName.ShouldBe("Index");

            context.Clients.Count().ShouldBe(1);
            context.Clients.First().FullName.ShouldBe("Igoref Igor Igorevich");
        }
    }
}
