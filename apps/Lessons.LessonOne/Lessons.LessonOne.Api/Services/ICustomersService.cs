using Lessons.LessonOne.Api.Models;

namespace Lessons.LessonOne.Api.Services
{
    public interface ICustomersService : IGetable<Customer>, ISetable<Customer>
    {
        Customer CurrentCustomer { get; set; }
    }
}
