﻿namespace SCHALE.Common.Database.ModelExtensions
{
    public static class AccountExtensions
    {
        public static List<CharacterDB> AddCharacters(this AccountDB account, SCHALEContext context, params CharacterDB[] characters)
        {
            foreach (var character in characters)
            {
                character.AccountServerId = account.ServerId;
                context.Characters.Add(character);
            }
            
            return [.. characters];
        }

        public static List<EquipmentDB> AddEquipment(this AccountDB account, SCHALEContext context, params EquipmentDB[] equipmentDB)
        {
            foreach (var equipment in equipmentDB)
            {
                equipment.AccountServerId = account.ServerId;

                var existingEquipment = account.Equipment.FirstOrDefault(x => x.UniqueId == equipment.UniqueId);

                if (existingEquipment != null && equipment.BoundCharacterServerId == default)
                    existingEquipment.StackCount += equipment.StackCount;
                else
                    context.Equipment.Add(equipment);
            }

            return [.. equipmentDB];
        }

        public static List<WeaponDB> AddWeapons(this AccountDB account, SCHALEContext context, params WeaponDB[] weapons)
        {
            foreach (var weapon in weapons)
            {
                weapon.AccountServerId = account.ServerId;
                context.Weapons.Add(weapon);
            }

            return [.. weapons];
        }

        public static List<ItemDB> AddItems(this AccountDB account, SCHALEContext context, params ItemDB[] items)
        {
            foreach (var item in items)
            {
                item.AccountServerId = account.ServerId;
                context.Items.Add(item);
            }

            return [.. items];
        }

        public static List<GearDB> AddGears(this AccountDB account, SCHALEContext context, params GearDB[] gears)
        {
            foreach (var gear in gears)
            {
                gear.AccountServerId = account.ServerId;
                context.Gears.Add(gear);

                var targetCharacter = account.Characters.FirstOrDefault(x => x.ServerId == gear.BoundCharacterServerId);
                targetCharacter.EquipmentServerIds.Add(gear.ServerId);
            }

            return [.. gears];
        }
    }
}
