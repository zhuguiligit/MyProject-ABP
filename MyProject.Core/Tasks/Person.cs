﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace MyProject.Tasks
{
    public class Person : Entity
    {
        public string Name { get; set; }
    }
}