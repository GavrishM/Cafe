using Cafe.Data;
using Cafe.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace XUnitTestProject.Data
{
    public class ApplicationDbContextTests
    {
        private ApplicationDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new ApplicationDbContext(options);
        }

        [Fact]
        public void CanAddClientToDatabase()
        {
            var context = GetDbContext();
            var client = new Client { FullName = "Тестовый клиент", Email = "test@gmail.com", Phone = "+7636736736837", Age = 21 };

            context.Clients.Add(client);
            context.SaveChanges();

            Assert.Equal(1, context.Clients.Count());
        }

        [Fact]
        public void CanAddMealToDatabase()
        {
            var context = GetDbContext();
            var meal = new Meal { Name = "Тестовое блюдо", Type = "test", Description = "test", Contains = "test", Price = 1.2, Weight = 0.5, Status = "t" };

            context.Meals.Add(meal);
            context.SaveChanges();

            Assert.Equal(1, context.Meals.Count());
        }

        [Fact]
        public void CanAddOrderToDatabase()
        {
            var context = GetDbContext();
            var order = new Order { NumberOrder = 2, TotalAmount = 1.2, Status = "test" };

            context.Orders.Add(order);
            context.SaveChanges();

            Assert.Equal(1, context.Orders.Count());
        }

        [Fact]
        public void CanAddWorkerToDatabase()
        {
            var context = GetDbContext();
            var worker = new Worker { FullName = "Тестовый работник", Age = 21, Position = "test", Phone = "+7636736736837" };

            context.Workers.Add(worker);
            context.SaveChanges();

            Assert.Equal(1, context.Workers.Count());
        }
    }
}
