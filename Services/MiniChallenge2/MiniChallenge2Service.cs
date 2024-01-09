namespace PackardJMiniChallengeTwoToFour_Endpoints.Services.MiniChallenge2;

public class MiniChallenge2Service : IMiniChallenge2Service
{
    public string AddNums(string num1, string num2)
    {
        double isANumber1 = 0;
        double isANumber2 = 0;

        bool success = double.TryParse(num1, out isANumber1) && double.TryParse(num2, out isANumber2);

        if (success)
        {
            double sum = isANumber1 + isANumber2;
            return $"The sum of {num1} and {num2} is {sum}!";
        }
        else
        {
            return "Please make sure both inputs are numbers.";
        }


    }
}
