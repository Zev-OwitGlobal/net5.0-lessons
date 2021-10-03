using System;
using System.Threading.Tasks;

using Lessons.LessonOne.Api.Models;
using Lessons.LessonOne.Api.Services;

using Microsoft.AspNetCore.Mvc;

namespace Lessons.LessonOne.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ISetable<Customer> _setable;
        private readonly IGetable<Customer> _getable;
        private readonly ICustomersProfileService _profileService;

        public CustomersController(ISetable<Customer> setable, IGetable<Customer> getable, ICustomersProfileService profileService)
        {
            _setable = setable;
            _getable = getable;
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Customer customer = _getable.Get();
            _setable.Set(customer);

            Profile profile = new()
            {
                Birthdate = DateTime.Now,
                FavoriteColor = "Purple",
                Weight = 300
            };


            _profileService.SetCustomerProfile(profile);

            return Ok(customer);
        }
    }
}
