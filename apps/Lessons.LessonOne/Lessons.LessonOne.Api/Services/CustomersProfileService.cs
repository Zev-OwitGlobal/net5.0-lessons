using System;

using Lessons.LessonOne.Api.Models;

namespace Lessons.LessonOne.Api.Services
{
    public class CustomersProfileService : ICustomersProfileService
    {
        private readonly ICustomersService _service;

        public CustomersProfileService(ICustomersService service)
        {
            _service = service;
        }

        public Profile GetById(Guid id)
        {
            return new()
            {
                Birthdate = DateTime.Now,
                FavoriteColor = "Red",
                Weight = 170,
            };
        }

        public void SetCustomerProfile(Profile profile)
        {
            Customer customer = _service.CurrentCustomer;
            customer.Profile = profile;
        }
    }
}
