using Microsoft.AspNetCore.Mvc;

public class StorageController : BaseController
{
    private DataContext dataContext;
    //через AddSingleton указываем объект, и потом через конструктор класса получаем
    //доступ к этому объекту из любой части приложения.
    public StorageController(DataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    [HttpGet("SetString/{value}")]
    public void SetString(string value)
    {
        dataContext.Str = value;
    }

    [HttpGet("GetString")]
    public string GetString()
    {
        return dataContext.Str;
    }

}