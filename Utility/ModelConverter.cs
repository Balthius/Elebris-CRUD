using Elebris.Database.Models;
using Elebris.Database.Manager;
using Elebris.Database.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.Utilities
{
    public static class ModelConverter
    {
        public static CharacterModel CovertFromDBModel(CharacterModel dbModel)
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
        public static DerivedStatUpdateModel CovertFromDBModel(DerivedStatModel dbModel)
        {
            DerivedStatUpdateModel model = new DerivedStatUpdateModel();
            model.Id = dbModel.Id;
            model.Name = dbModel.Name;
            model.ParentStatId = dbModel.ParentStatId;
            model.TargetStatId = dbModel.TargetStatId;
            model.ScaleFromParent = dbModel.ScaleFromParent;

            return model;
        }
        public static StatModel CovertFromDBModel(StatModel dbModel)
        {
            StatModel model = new StatModel();
            model.Id = dbModel.Id;
            model.StatName = dbModel.StatName;
            model.BeginningValue = dbModel.BeginningValue;
            model.StatGroup = dbModel.StatGroup;

            return model;
        }
        public static ElebrisClassModel CovertFromDBModel(ElebrisClassModel dbModel)
        {
            ElebrisClassModel model = new ElebrisClassModel();
            model.Id = dbModel.Id;
            model.Name = dbModel.Name;
            model.GoverningAttribute = dbModel.GoverningAttribute;
            model.Description = dbModel.Description;

            return model;
        }
        public static EquipmentModel CovertFromDBModel(EquipmentModel dbModel)
        {
            EquipmentModel model = new EquipmentModel();
            model.Id = dbModel.Id;
            model.Name = dbModel.Name;
            model.EquipmentGroup = dbModel.EquipmentGroup;
            model.Description = dbModel.Description;

            return model;
        }
        public static ClassRoleModel CovertFromDBModel(ClassRoleModel dbModel)
        {
            ClassRoleModel model = new ClassRoleModel();
            model.Id = dbModel.Id;
            model.Name = dbModel.Name;
            model.Description = dbModel.Description;

            return model;
        }

        public static CharacterModel CovertToDBModel(CharacterModel appModel)
        {
            CharacterModel dbModel = new CharacterModel();
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
        public static StatModel CovertToDBModel(StatModel appModel)
        {
            StatModel model = new StatModel();

            model.Id = appModel.Id;
            model.StatName = appModel.StatName;
            model.BeginningValue = appModel.BeginningValue;

            model.StatGroup = appModel.StatGroup;
            return model;
        }
        public static DerivedStatModel CovertToDBModel(DerivedStatUpdateModel appModel)
        {
            DerivedStatModel model = new DerivedStatModel();
            model.Id = appModel.Id;
            model.Name = appModel.Name;
            model.ParentStatId = appModel.ParentStatId;
            model.TargetStatId = appModel.TargetStatId;
            model.ScaleFromParent = appModel.ScaleFromParent;
            return model;
        }
        public static ElebrisClassModel CovertToDBModel(ElebrisClassModel appModel)
        {
            ElebrisClassModel model = new ElebrisClassModel();
            model.Id = appModel.Id;
            model.Name = appModel.Name;
            model.GoverningAttribute = appModel.GoverningAttribute;
            model.Description = appModel.Description;

            return model;
        }
        public static EquipmentModel CovertToDBModel(EquipmentModel appModel)
        {
            EquipmentModel model = new EquipmentModel();
            model.Id = appModel.Id;
            model.Name = appModel.Name;
            model.EquipmentGroup = appModel.EquipmentGroup;
            model.Description = appModel.Description;

            return model;
        }
        public static ClassRoleModel CovertToDBModel(ClassRoleModel appModel)
        {
            ClassRoleModel model = new ClassRoleModel();
            model.Id = appModel.Id;
            model.Name = appModel.Name;
            model.Description = appModel.Description;

            return model;
        }
    }
}
