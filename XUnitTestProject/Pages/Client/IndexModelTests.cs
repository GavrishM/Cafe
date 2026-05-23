using Cafe.Data;
using Cafe.Pages;
using Cafe.Pages.Clients;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject.Pages.Client
{
    public class IndexModelTests
    {
        [Fact]
        public void IndexModel_Exists_AndHasBooksProperty()
        {
            var model = new Cafe.Pages.Clients.IndexModel(null!);

            Assert.NotNull(model);
            Assert.IsType<Cafe.Pages.Clients.IndexModel>(model);
        }

        [Fact]
        public void IndexModel_OnGet_LoadsClientsFromDatabase()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new ApplicationDbContext(options);

            context.Clients.Add(new Cafe.Model.Client
            {
                FullName = "Клиент 1",
                Email = "client1@gmail.com",
                Phone = "+791111111111",
                Age = 1
            });

            context.Clients.Add(new Cafe.Model.Client
            {
                FullName = "Клиент 2",
                Email = "client2@gmail.com",
                Phone = "+792222222222",
                Age = 2
            });

            context.SaveChanges();

            var model = new Cafe.Pages.Clients.IndexModel(context);
            model.OnGet();

            Assert.Equal(2, model.Clients.Count);
        }

    }
}
