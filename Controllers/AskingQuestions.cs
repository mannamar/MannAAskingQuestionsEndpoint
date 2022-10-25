using Microsoft.AspNetCore.Mvc;

namespace MannASayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
  [HttpGet]
  public string AskingQuestionsDefault()
  {
    string name = "you handsome devil";
    string wakeTime = "10am";
    return $"Hello {name}! You woke up at {wakeTime} today? Wild";
  }

  [HttpGet]
  [Route("{name}/{wakeTime}")]
  public string AskingQuestions(string name, string wakeTime)
  {
    return $"Hello {name}! You woke up at {wakeTime} today? Wild";
  }
}
