using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

[ApiController]
[Route("SnookingController")]
public class AtlantisController
{
    public AtlantisController(){}
    /*
    [HttpGet("/Login")]
    [ProducesResponseType(typeof(User),StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<User> GetUser([FromBody]User input , CancellationToken _cancellationToken)
    {
        Console.WriteLine(JsonSerializer.Serialize(input));
        var u = new User(input.mail, input.pass);
        return u;
    }
    */
}