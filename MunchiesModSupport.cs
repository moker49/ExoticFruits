using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System;
using System.Collections.Generic;
using ExoticFruits.Items.Fruits;

namespace ExoticFruits
{
    public class MunchiesModSupport
    {
        private readonly static Dictionary<string, Type> _vanillaFruitTypes = new Dictionary<string, Type>
        {
            { "ExoticFruits00", typeof(ExoticFruits00) },
            { "ExoticFruits01", typeof(ExoticFruits01) },
            { "ExoticFruits02", typeof(ExoticFruits02) },
            { "ExoticFruits03", typeof(ExoticFruits03) },
            { "ExoticFruits04", typeof(ExoticFruits04) },
            { "ExoticFruits05", typeof(ExoticFruits05) },
            { "ExoticFruits06", typeof(ExoticFruits06) },
            { "ExoticFruits07", typeof(ExoticFruits07) },
            { "ExoticFruits08", typeof(ExoticFruits08) },
            { "ExoticFruits09", typeof(ExoticFruits09) },
            { "ExoticFruits10", typeof(ExoticFruits10) },
        };


        internal static void AddExoticConsumables()
        {
            // Exotic Fruit 00
            ModItem exoticFruit00 = ModContent.GetInstance<ExoticFruits00>();
            AddMultiModConsumable(exoticFruit00, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 0), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 01
            ModItem exoticFruit01 = ModContent.GetInstance<ExoticFruits01>();
            AddMultiModConsumable(exoticFruit01, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 1), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 02
            ModItem exoticFruit02 = ModContent.GetInstance<ExoticFruits02>();
            AddMultiModConsumable(exoticFruit02, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 2), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 03
            ModItem exoticFruit03 = ModContent.GetInstance<ExoticFruits03>();
            AddMultiModConsumable(exoticFruit03, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 3), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 04
            ModItem exoticFruit04 = ModContent.GetInstance<ExoticFruits04>();
            AddMultiModConsumable(exoticFruit04, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 4), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 05
            ModItem exoticFruit05 = ModContent.GetInstance<ExoticFruits05>();
            AddMultiModConsumable(exoticFruit05, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 5), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 06
            ModItem exoticFruit06 = ModContent.GetInstance<ExoticFruits06>();
            AddMultiModConsumable(exoticFruit06, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 6), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 07
            ModItem exoticFruit07 = ModContent.GetInstance<ExoticFruits07>();
            AddMultiModConsumable(exoticFruit07, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 7), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 08
            ModItem exoticFruit08 = ModContent.GetInstance<ExoticFruits08>();
            AddMultiModConsumable(exoticFruit08, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 8), () => ExoticFruits.MaxFruits, null, null);

            // Exotic Fruit 09
            ModItem exoticFruit09 = ModContent.GetInstance<ExoticFruits09>();
            AddMultiModConsumable(exoticFruit09, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 9), () => ExoticFruits.MaxFruits, null, null);


            // big fruit
            ModItem bigFruit = ModContent.GetInstance<ExoticFruits10>();
            AddMultiModConsumable(bigFruit, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.BIG, 0), () => ExoticFruits.MaxFruits, null, null);

        }

        private static void AddMultiModConsumable(ModItem modItem, Func<int> fruitsConsumed, Func<int> maxFruits, string difficulty, Func<bool> availability = null)
        {
            if (modItem == null) return;
            object[] consumableArgs = {
                "AddMultiUseConsumable",
                ExoticFruits.instance,
                "1.3", // MunchiesMod.Call version
                modItem,
                "player", // category
                fruitsConsumed,
                maxFruits,
                null, //Color.Red, // Custom text color (or null)
                difficulty, //"expert", // Difficulty (or null)
                null, // Extra tooltip of type LocalizedText
                availability, //() => Main.expertMode, // Availability (or null if always available)
                null // Acquisition text of type LocalizedText, or null if not necessary
            };
            ExoticFruits.MunchiesMod.Call(consumableArgs);
        }

        private static ModItem CreateModItemInstance(string typeName)
        {
            Type type = Type.GetType(typeName);
            if (type != null && typeof(ModItem).IsAssignableFrom(type))
            {
                return (ModItem)Activator.CreateInstance(type);
            }
            throw new InvalidOperationException($"Type '{typeName}' could not be found or is not a ModItem.");
        }
    }

}