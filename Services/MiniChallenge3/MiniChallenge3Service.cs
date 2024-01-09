namespace PackardJMiniChallengeTwoToFour_Endpoints.Services.MiniChallenge3;

public class MiniChallenge3Service : IMiniChallenge3Service
{
    public string AskQuestions(string name, string wakeUpTime)
    {
        return $"Your name is {name} and you woke up at {wakeUpTime} today.";
    }
}
