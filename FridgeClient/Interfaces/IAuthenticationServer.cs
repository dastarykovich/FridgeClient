using Microsoft.AspNetCore.Mvc;
using FridgeClient.Models.DataTransferObjects;
using RestEase;
using System.Threading.Tasks;

namespace FridgeClient.Interfaces
{
    [Header("Authentication-Agent", "RestEase")]
    public interface IAuthenticationServer
    {
        [Post("api/authentication")]
        Task<string> RegisterUser([Body] UserForRegistrationDto userForRegistration);

        [Post("api/authentication/login")]
        Task<string> Authenticate([Body] UserForAuthenticationDto user);
    }
}