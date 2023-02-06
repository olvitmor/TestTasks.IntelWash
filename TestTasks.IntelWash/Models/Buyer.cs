using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TestTasks.IntelWash.Managers;

namespace TestTasks.IntelWash.Models
{
    public class Buyer
    {
        public string Id { get; set; } = IdManager.NewId();
        public string Name { get; set; }
        public List<string> SalesIds { get; set; } = new List<string>();

        public Buyer()
        {

        }

        public Buyer(string id, string name, List<string> salesIds)
        {
            Id = id;
            Name = name;
            SalesIds = salesIds;
        }

        public Buyer(string name, List<string> salesIds)
        {
            Id = null;
            Name = name;
            SalesIds = salesIds;
        }

    }
}
