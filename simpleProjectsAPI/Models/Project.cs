﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleProjectsAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }
        public int CategoryId { get; set; }
    }
}
