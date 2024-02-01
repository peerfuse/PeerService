using Microsoft.AspNetCore.Mvc;
using P2PokerBean;
using P2PokerEntitys;
using P2PokerSingleton;

namespace P2PokerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RoomControl : ControllerBase
{
    [HttpPost()]
    [Route("createroom")]
    [ProducesResponseType(typeof(Room), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<string?> Create(
        [FromBody] Guid id,
        CancellationToken cancellationToken
    )
    {
        var output = new Room();
        output.OnStart();
        Room r = RegisterRoom(output);
        IActionResult result = CreatedAtAction(nameof(Create), new { r.UUID }, r);
        if (result is not null)
        {
            return r.UUID.ToString();
        }

        return null;
        await Task.CompletedTask;
    }
    
    [HttpGet("getroom/{id:guid}")]
    [ProducesResponseType(typeof(Room), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken
    )
    {
        Room r = GetRoom(id);
        return Ok(r);
    }

    private Room GetRoom(Guid id)
    => Singleton._singleton().CreateRoomRepository(Singleton._singleton().CreateDBContext()).Get(id);

    private Room RegisterRoom(Room output)
    {
        var db = Singleton._singleton().CreateDBContext();
        var repository = Singleton._singleton().CreateRoomRepository(db);
        repository.Insert(output);
        Room room = repository.Get(output.UUID);
        return room;
    }

    [HttpGet("AllRooms")]
    public IEnumerable<Room> Get() => GetAllRoom();

    List<Room> GetAllRoom()
    {
        var db = Singleton._singleton().CreateDBContext();
        var repository = Singleton._singleton().CreateRoomRepository(db);
        var room = repository.GetRooms();
        return room;
    }
}