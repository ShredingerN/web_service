using Microsoft.AspNetCore.Mvc;

//http://localhost:5000/api/Test
public class TestController : BaseController
{

    //http://localhost:5000/api/Test/test
    [HttpGet("test")]
    public string GetText()
    {
        return "forecast1";
    }
}