using Microsoft.AspNetCore.Mvc;

namespace MVC_DataBase.Components
{
    [ViewComponent]
    public class Message
    {
        public string Invoke()
        {
            return "Entered data isn't valid";
        }
    }
}
