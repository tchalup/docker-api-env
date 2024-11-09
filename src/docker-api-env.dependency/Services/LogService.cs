using docker_api_env.dependency.Interfaces;

namespace docker_api_env.dependency.Services
{
    public class LogService : ILogService
    {
        public async Task WriteLog(string message)
        {
            await Task.Factory.StartNew(() => Console.WriteLine(message));
        }
    }
}
