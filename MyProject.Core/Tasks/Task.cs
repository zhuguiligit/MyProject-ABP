using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace MyProject.Tasks
{
    public class Task : Entity<long>
    {
        public string Description { get; set; }

        public DateTime CreateTime { get; set; }

        [ForeignKey("AssignedPersonId")]
        public virtual Person AssignedPerson { get; set; }

        public int? AssignedPersonId { get; set; }
    }
}