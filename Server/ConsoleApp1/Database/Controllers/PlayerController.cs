-using Database.Models;
using Database.Services;
using Microsoft.AspNetCore.Mvc;

namespace Database.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PlayerDBController : ControllerBase
    {
        public PlayerDBController()
        {
        }

        //GET All Action
        [HttpGet]
        public ActionResult<List<Player>> GetAll() =>
        PlayerServices.GetAll();

        //GET by id Action
        [HttpGet("{id}")]
        public ActionResult<Player> Get(int id)
        {
            var player = PlayerServices.Get(id);

            if (player == null)
                return NotFound();

            return player;
        }


        //PUT
        [HttpPut("{id}")]
        public IActionResult Update(int id, PlayerDB player)
        {
            if (id != player.id)
                return BadRequest();

            var existingPizza = PlayerServices.Get(id);
            if (existingPizza is null)
                return NotFound();

            Player
              
                Services.Update(player);
            return NoContent();
        }

    }


}
































































