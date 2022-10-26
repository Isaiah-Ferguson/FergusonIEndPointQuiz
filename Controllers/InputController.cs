//Isaiah Keith Ferguson
//10/26/2022
//End Point Quiz
using Microsoft.AspNetCore.Mvc;

namespace QUIZ.Controllers;

[ApiController]
[Route("[controller]")]
public class InputController : ControllerBase
{
    [HttpGet]
    [Route("String/{Dinner}")]

    public string Dinner(string Dinner)
    {
        return $"I ate a {Dinner} from costco for dinner last night";
    }

    [HttpGet]
    [Route("Int/{num1}/{num2}")]

    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
}