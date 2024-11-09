namespace docker_api_env.dependency.Interfaces
{
    public interface ILogService
    {
        Task WriteLog(string message);
    }
}
