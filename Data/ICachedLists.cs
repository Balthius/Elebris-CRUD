using Elebris.Database.Manager;
using Elebris.Database.Manager.Models;
using System.Collections.Generic;

namespace Elebris.CRUD.Data
{
    public interface ICachedLists
    {
        List<CoreStatModel> CachedAttributes { get; set; }
        List<StatGroupModel> CachedStatGroups { get; set; }
    }
}