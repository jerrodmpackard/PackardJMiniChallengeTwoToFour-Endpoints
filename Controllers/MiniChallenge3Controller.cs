using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeTwoToFour_Endpoints.Services.MiniChallenge3;

namespace PackardJMiniChallengeTwoToFour_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]

public class MiniChallenge3Controller : ControllerBase
{
    private readonly IMiniChallenge3Service _miniChallenge3Service;

    public MiniChallenge3Controller(IMiniChallenge3Service miniChallenge3Service)
    {
        _miniChallenge3Service = miniChallenge3Service;
    }

    [HttpPost]
    [Route("AskQuestions/{name}/{wakeUpTime}")]

    public string AskQuestions(string name, string wakeUpTime)
    {
        return _miniChallenge3Service.AskQuestions(name, wakeUpTime);
    }
}
