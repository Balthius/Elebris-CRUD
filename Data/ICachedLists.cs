using Elebris.Database.Manager;
using Elebris.Database.Manager.Models;
using System.Collections.Generic;

namespace Elebris.CRUD.Data
{
    public interface ICachedLists
    {
        List<StatModel> CachedAttributes { get; set; }
        List<StatGroupModel> CachedStatGroups { get; set; }
        List<ClassRoleModel> CachedClassRoles { get; set; } 

        List<EquipmentModel> CachedEquipmentTypes { get; set; } 

        List<EquipmentGroupModel> CachedEquipmentGroups { get; set; }

    }
}