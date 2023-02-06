using System;

namespace TestTasks.IntelWash.Interfaces
{
    public interface ILogger
    {
        public void Log(string message);

        public void LogError(string message);
        public void LogError(Exception ex);

    }
}
