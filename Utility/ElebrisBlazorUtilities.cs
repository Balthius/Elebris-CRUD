using Elebris.CRUD.Models;
using Elebris.Database.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.Utilities
{
    public static class ElebrisBlazorUtilities
    {
        public static CharacterModel CovertFromDBModel(CoreCharacterModel dbModel)
        {
            CharacterModel appModel = new CharacterModel();
            appModel.FirstName = dbModel.FirstName;
            appModel.LastName = dbModel.LastName;
            appModel.Id = dbModel.Id;
            appModel.Strength = dbModel.Strength;
            appModel.Constitution = dbModel.Constitution;
            appModel.Agility = dbModel.Agility;
            appModel.Expertise = dbModel.Expertise;
            appModel.Intelligence = dbModel.Intelligence;
            appModel.Wisdom = dbModel.Wisdom;

            return appModel;
        }
        public static StatModel CovertFromDBModel(CoreStatModel dbModel)
        {
            StatModel model = new StatModel();
            model.Id = dbModel.Id;
            model.StatName = dbModel.StatName;
            model.BeginningValue = dbModel.BeginningValue;
            model.StatGroup = dbModel.StatGroup;

            return model;
        }
       
        public static CoreCharacterModel CovertToDBModel(CharacterModel appModel)
        {
            CoreCharacterModel dbModel = new CoreCharacterModel();
            dbModel.FirstName = appModel.FirstName;
            dbModel.LastName = appModel.LastName;
            dbModel.Id = appModel.Id;
            dbModel.Strength = appModel.Strength;
            dbModel.Constitution = appModel.Constitution;
            dbModel.Agility = appModel.Agility;
            dbModel.Expertise = appModel.Expertise;
            dbModel.Intelligence = appModel.Intelligence;
            dbModel.Wisdom = appModel.Wisdom;

            return dbModel;
        }
        public static CoreStatModel CovertToDBModel(StatModel appModel)
        {
            CoreStatModel model = new CoreStatModel();

            model.Id = appModel.Id;
            model.StatName = appModel.StatName;
            model.BeginningValue = appModel.BeginningValue;

            model.StatGroup = appModel.StatGroup;
            return model;
        }
    }
}
