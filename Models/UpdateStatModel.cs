using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.CRUD.Models
{
    public class UpdateStatModel
    {
        public int Id { get; set; }
        public string StatName { get; set; }
        public float BeginningValue { get; set; }
    }
}
