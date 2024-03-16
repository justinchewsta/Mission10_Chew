using API_Mission10.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IBowlersRepository _bowlersRepository;
        public BowlersController(IBowlersRepository temp) {
            _bowlersRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
        var BowlersData = from Bowlers in _bowlersRepository.Bowlers
                         join Teams in _bowlersRepository.Teams on Bowlers.TeamID equals Teams.TeamID
                         select new JoinedBowler
                         {
                             BowlerID = Bowlers.BowlerID,
                             BowlerFirstName = Bowlers.BowlerFirstName,
                             BowlerMiddleInit = Bowlers.BowlerMiddleInit,
                             BowlerLastName = Bowlers.BowlerLastName,
                             BowlerAddress = Bowlers.BowlerAddress,
                             BowlerCity = Bowlers.BowlerCity,
                             BowlerState = Bowlers.BowlerState,
                             BowlerZip = Bowlers.BowlerZip,
                             BowlerPhoneNumber = Bowlers.BowlerPhoneNumber,
                             TeamID = Bowlers.TeamID,
                             TeamName = Teams.TeamName
                         };
            return BowlersData.Where(data => data.TeamName == "Marlins" || data.TeamName == "Sharks").ToList();
        }
    }

}