using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleProjectsAPI.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
