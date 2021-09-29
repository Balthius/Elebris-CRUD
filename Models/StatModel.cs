using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.CRUD.Models
{
    public class StatModel
    {
        public int Id { get; set; }

        [DisplayName("Stat Name")]
        [MinLength(2)]
        [MaxLength(40)]
        [Required]
        public string StatName { get; set; }
        public float BeginningValue { get; set; }
        public int StatGroup { get; set; }

    }
}
