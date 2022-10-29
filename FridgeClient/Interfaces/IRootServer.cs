using Microsoft.AspNetCore.Mvc;
using RestEase;

namespace FridgeClient.Interfaces
{
    public interface IRootServer
    {
        [Get("api")]
        IActionResult GetRoot([Header("Accept")] string mediaType);
    }
}