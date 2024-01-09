using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeTwoToFour_Endpoints.Services.MiniChallenge2;

namespace PackardJMiniChallengeTwoToFour_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]

public class MiniChallenge2Controller : ControllerBase
{
    private readonly IMiniChallenge2Service _miniChallenge2Service;

    public MiniChallenge2Controller(IMiniChallenge2Service miniChallenge2Service)
    {
        _miniChallenge2Service = miniChallenge2Service;
    }

    [HttpPost]
    [Route("AddNums/{num1}/{num2}")]
    public string AddNums(string num1, string num2)
    {
        return _miniChallenge2Service.AddNums(num1, num2);
    }
}
