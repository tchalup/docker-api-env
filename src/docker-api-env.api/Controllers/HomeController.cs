using docker_api_env.api.Models;
using docker_api_env.dependency.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace docker_api_env.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly EnvironmentModel _environmentModel;
        private readonly ILogService _logService;

        public HomeController(IConfiguration _configuration, IServiceProvider serviceProvider)
        {
            _logService = serviceProvider.GetRequiredService<ILogService>();
            _environmentModel = _configuration.GetSection("Environment").Get<EnvironmentModel>()!;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var message = $"[{DateTime.UtcNow}] ::: Custom env: {_environmentModel.Custom}";

            _logService.WriteLog(message);

            return Ok(message);
        }
    }
}
