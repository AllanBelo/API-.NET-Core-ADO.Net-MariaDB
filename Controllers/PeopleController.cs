using Microsoft.AspNetCore.Mvc;
using PeopleAPI.Repository;

namespace PeopleAPI.Controllers
{
   [ApiController]
    [Route("/api/[controller]")]
    public class PeopleController:ControllerBase
    {
        private readonly IPeopleRepository _peopleRepository;
        public PeopleController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        [HttpGet("{PersonID}")]
        public IActionResult GetAction(int PersonID)
        {
            var people = _peopleRepository.GetPeople(PersonID);
            if(people == null)
            {
                return NotFound();
            }
            return Ok(people);
        }
    }
}