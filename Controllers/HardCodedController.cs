//Isaiah Keith Ferguson
//10/26/2022
//End Point Quiz
using Microsoft.AspNetCore.Mvc;

namespace QUIZ.Controllers;

[ApiController]
[Route("[controller]")]
public class HardCodedController : ControllerBase
{
    [HttpGet]
    [Route("String")]

    public string Dinner()
    {
        return "I ate a 5 Glizzies from costco for dinner last night";
    }

    [HttpGet]
    [Route("Int")]

    public int Multiply()
    {
        return 8 * 8;
    }
}