using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeTwoToFour_Endpoints.Services.MiniChallenge4;

namespace PackardJMiniChallengeTwoToFour_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]

public class MiniChallenge4Controller : ControllerBase
{
    private readonly IMiniChallenge4Service _miniChallenge4Service;

    public MiniChallenge4Controller(IMiniChallenge4Service miniChallenge4Service)
    {
        _miniChallenge4Service = miniChallenge4Service;
    }

    [HttpPost]
    [Route("Comparisons/{num1}/{num2}")]
    public string Comparisons(string num1, string num2)
    {
        return _miniChallenge4Service.Comparisons(num1, num2);
    }
}
