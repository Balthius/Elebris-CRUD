using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.CRUD.Models
{
    public class DerivedStatUpdateModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "This is outside an acceptable bound")]
        public int ParentStatId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "This is outside an acceptable bound")]
        public int TargetStatId { get; set; }
        public float ScaleFromParent { get; set; }
    }
}
