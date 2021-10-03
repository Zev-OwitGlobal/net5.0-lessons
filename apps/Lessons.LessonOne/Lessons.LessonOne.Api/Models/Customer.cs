using System;

namespace Lessons.LessonOne.Api.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Profile Profile { get; set; }
    }
}
