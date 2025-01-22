using Microsoft.AspNetCore.Mvc;

//http://localhost:5000/api/Hello
public class HelloController : BaseController
{

    //http://localhost:5000/api/Test/test1/{name}
    [HttpGet("hello/{name}")]
    public string GetHelloText(string name)
    {
        return $"Hi, {name}";
    }


}