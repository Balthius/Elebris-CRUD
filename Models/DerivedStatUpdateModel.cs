using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.CRUD.Models
{
    public class DerivedStatUpdateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentStatId { get; set; }
        public string TargetStatId { get; set; }
        public float BaseFromParent { get; set; }
        public float ScaleFromParent { get; set; }
    }
}
