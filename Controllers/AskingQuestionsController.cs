// Amardeep Mann
// 10-25-22
// AskingQuestions Endpoint
// Added the ability to take in an input via web URL for our AskingQuestions function
// Peer reviewed by Andrew Nilsson: Good job with the default and the inputs work well on postman as well as the string that is returned.
// Github URL: https://github.com/peedrama/MannAAskingQuestionsEndpoint

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
