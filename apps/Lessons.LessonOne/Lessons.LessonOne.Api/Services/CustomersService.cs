using System;

using Lessons.LessonOne.Api.Models;

namespace Lessons.LessonOne.Api.Services
{
    public class CustomersService : ICustomersService
    {
        public Customer CurrentCustomer { get; set; }

        public Customer Get()
        {
            Customer customer = new()
            {
                Id = Guid.NewGuid(),
                FirstName = "Zev",
                LastName = "Butler",
            };
            return customer;
        }

        public void Set(Customer customer)
        {
            CurrentCustomer = customer;
        }
    }
}
