using Elebris.Database.Manager;
using Elebris.Database.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.CRUD.Data
{
    //https://blog.jeremylikness.com/blog/blazor-state-management/
    public class CachedLists : ICachedLists
    {
        private readonly IStatData _statData;

        public List<CoreStatModel> CachedAttributes { get; set; } = new List<CoreStatModel>();

        public List<StatGroupModel> CachedStatGroups { get; set; } = new List<StatGroupModel>();

        public CachedLists(IStatData statData)
        {
            _statData = statData;


            _ = SetAttributes();
            _ = SetStatGroups();
        }

        private async Task SetAttributes()
        {
            List<CoreStatModel> statList = await _statData.GetAllStats();
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
    }
}
