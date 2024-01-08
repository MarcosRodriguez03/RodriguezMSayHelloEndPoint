
using Microsoft.AspNetCore.Mvc;


namespace RodriguezMSayHelloEndPoint.Controllers;
[ApiController]
[Route("[controller]")]
public class SayHelloController
{
    public List<string> sentence = new();

    [HttpPost]
    [Route("SayHelloMachine/name")]

    public List<string> SayHelloMachine(string name)
    {
        sentence.Add($"Hello, {name}!");
        return sentence;
    }

}
