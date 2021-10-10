using Elebris.Database.Manager;
using Elebris.Database.Manager.DataAccess;
using Elebris.Database.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.CRUD.Data
{
    //https://docs.microsoft.com/en-us/aspnet//blazor/state-management?view=aspnet-5.0&pivots=server
    //https://blog.jeremylikness.com/blog/blazor-state-management/
    //https://www.youtube.com/watch?v=Pm4LejeJkoU
    public class CachedLists : ICachedLists
    {
        private readonly IStatData _statData;
        private readonly IElebrisClassData _classData;
        private readonly IEquipmentData _equipmentData;

        public List<StatModel> CachedAttributes { get; set; } = new List<StatModel>();

        public List<StatGroupModel> CachedStatGroups { get; set; } = new List<StatGroupModel>();

        public List<ClassRoleModel> CachedClassRoles { get; set; } = new List<ClassRoleModel>();

        public List<EquipmentModel> CachedEquipmentTypes { get; set; } = new List<EquipmentModel>();

        public List<EquipmentGroupModel> CachedEquipmentGroups { get; set; } = new List<EquipmentGroupModel>();

        public CachedLists(IStatData statData, IElebrisClassData classData, IEquipmentData equipmentData)
        {
            _statData = statData;
            _classData = classData;
            _equipmentData = equipmentData;
            _ = SetAttributes();
            _ = SetStatGroups();
            _ = SetRoles();
            _ = SetEquipmentGroups();
            _ = SetEquipmentTypes();
        }

        private async Task SetAttributes()
        {
            List<StatModel> statList = await _statData.GetAllStats();
            foreach (var item in statList)
            {
                if (item.StatGroup == 1002)
                {
                    CachedAttributes.Add(item);
                }
            }
        }
        private async Task SetStatGroups()
        {
            CachedStatGroups = await _statData.GetAllStatGroups();
        }

        private async Task SetRoles()
        {
            CachedClassRoles = await _classData.GetAllClassRoles();
        }
        private async Task SetEquipmentGroups()
        {
            CachedEquipmentGroups = await _equipmentData.GetAllEquipmentGroups();
        }
        private async Task SetEquipmentTypes()
        {
            CachedEquipmentTypes = await _equipmentData.GetAllEquipmentModels();
        }
    }
}
