using System;

namespace TestTasks.IntelWash.Managers
{
    public static class IdManager
    {
        public static string NewId() => Guid.NewGuid().ToString();
    }
}
