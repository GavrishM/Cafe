using Cafe.Data;
using Microsoft.EntityFrameworkCore;

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
        public void OnPost_ShouldReturnPage_WhenModelStateIsInvalid()
        {/*
            // Arrange
            var context = GetDbContext();
            var pageModel = new Cafe.Pages.Clients.CreateModel(context);

            pageModel.ModelState.AddModelError("Title", "Required");

            // Act
            var result = pageModel.OnPost();

            // Assert
            object value = result.Should().BeOfType<PageResult>();
            context.Clients.Count().Should().Be(0);
        */}

        [Fact]
        public void OnPost_ShouldAddBookAndRedirect_WhenModelStateIsValid()
        {/*
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
            result.Should().BeOfType<RedirectToPageResult>();

            var redirect = result as RedirectToPageResult;
            redirect.PageName.Should().Be("Index");

            context.Clients.Count().Should().Be(1);
            context.Clients.First().FullName.Should().Be("Igoref Igor Igorevich");
        */}
    }
}
