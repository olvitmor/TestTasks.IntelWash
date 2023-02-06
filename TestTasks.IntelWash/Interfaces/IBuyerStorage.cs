using System.Collections.Generic;
using TestTasks.IntelWash.Models;

namespace TestTasks.IntelWash.Interfaces
{
    public interface IBuyerStorage
    {
        public List<Buyer> GetList();
    }
}
