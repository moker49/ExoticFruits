using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System;
using System.Collections.Generic;
using ExoticFruits.Items.Fruits;
using ExoticFruits.Items.CalamityFruits;
using ExoticFruits.Items.CatalystFruits;

namespace ExoticFruits
{
    public class MunchiesModSupport
    {
        internal static void AddExoticConsumables()
        {
            // Exotic Fruit 00
            ModItem exoticFruit00 = ModContent.GetInstance<ExoticFruits00>();
            LocalizedText aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits00.Acquisition");
            AddMultiModConsumable(exoticFruit00, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 0), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 01
            ModItem exoticFruit01 = ModContent.GetInstance<ExoticFruits01>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits01.Acquisition");
            AddMultiModConsumable(exoticFruit01, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 1), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 02
            ModItem exoticFruit02 = ModContent.GetInstance<ExoticFruits02>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits02.Acquisition");
            AddMultiModConsumable(exoticFruit02, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 2), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 03
            ModItem exoticFruit03 = ModContent.GetInstance<ExoticFruits03>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits03.Acquisition");
            AddMultiModConsumable(exoticFruit03, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 3), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 04
            ModItem exoticFruit04 = ModContent.GetInstance<ExoticFruits04>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits04.Acquisition");
            AddMultiModConsumable(exoticFruit04, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 4), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 05
            ModItem exoticFruit05 = ModContent.GetInstance<ExoticFruits05>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits05.Acquisition");
            AddMultiModConsumable(exoticFruit05, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 5), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 06
            ModItem exoticFruit06 = ModContent.GetInstance<ExoticFruits06>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits06.Acquisition");
            AddMultiModConsumable(exoticFruit06, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 6), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 07
            ModItem exoticFruit07 = ModContent.GetInstance<ExoticFruits07>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits07.Acquisition");
            AddMultiModConsumable(exoticFruit07, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 7), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 08
            ModItem exoticFruit08 = ModContent.GetInstance<ExoticFruits08>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits08.Acquisition");
            AddMultiModConsumable(exoticFruit08, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 8), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 09
            ModItem exoticFruit09 = ModContent.GetInstance<ExoticFruits09>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits09.Acquisition");
            AddMultiModConsumable(exoticFruit09, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.VANILLA, 9), () => ExoticFruits.MaxFruits, null, null, aquizition);


            // Exotic Fruit 10 big fruit
            ModItem bigFruit = ModContent.GetInstance<ExoticFruits10>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits10.Acquisition");
            AddMultiModConsumable(bigFruit, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.BIG, 0), () => ExoticFruits.MaxFruits, null, null, aquizition);

        }
        internal static void AddCalamityConsumables()
        {
            // Exotic Fruit 11
            ModItem exoticFruit11 = ModContent.GetInstance<ExoticFruits11>();
            LocalizedText aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits11.Acquisition");
            AddMultiModConsumable(exoticFruit11, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 0), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 12
            ModItem exoticFruit12 = ModContent.GetInstance<ExoticFruits12>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits12.Acquisition");
            AddMultiModConsumable(exoticFruit12, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 1), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 13
            ModItem exoticFruit13 = ModContent.GetInstance<ExoticFruits13>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits13.Acquisition");
            AddMultiModConsumable(exoticFruit13, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 2), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 14
            ModItem exoticFruit14 = ModContent.GetInstance<ExoticFruits14>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits14.Acquisition");
            AddMultiModConsumable(exoticFruit14, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 3), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 15
            ModItem exoticFruit15 = ModContent.GetInstance<ExoticFruits15>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits15.Acquisition");
            AddMultiModConsumable(exoticFruit15, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 4), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 16
            ModItem exoticFruit16 = ModContent.GetInstance<ExoticFruits16>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits16.Acquisition");
            AddMultiModConsumable(exoticFruit16, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 5), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 17
            ModItem exoticFruit17 = ModContent.GetInstance<ExoticFruits17>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits17.Acquisition");
            AddMultiModConsumable(exoticFruit17, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 6), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 18
            ModItem exoticFruit18 = ModContent.GetInstance<ExoticFruits18>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits18.Acquisition");
            AddMultiModConsumable(exoticFruit18, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 7), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 19
            ModItem exoticFruit19 = ModContent.GetInstance<ExoticFruits19>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits19.Acquisition");
            AddMultiModConsumable(exoticFruit19, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 8), () => ExoticFruits.MaxFruits, null, null, aquizition);

            // Exotic Fruit 20
            ModItem exoticFruit20 = ModContent.GetInstance<ExoticFruits20>();
            aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits20.Acquisition");
            AddMultiModConsumable(exoticFruit20, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CALAMITY, 9), () => ExoticFruits.MaxFruits, null, null, aquizition);
        }
        internal static void AddCatalystConsumables()
        {
            // Exotic Fruit 21
            ModItem exoticFruit21 = ModContent.GetInstance<ExoticFruits21>();
            LocalizedText aquizition = ExoticFruits.instance.GetLocalization("Items.ExoticFruits21.Acquisition");
            AddMultiModConsumable(exoticFruit21, () => ExoticFruitsPlayer.getFruitsConsumed(ExoticFruits.FruitType.CATALYST, 0), () => ExoticFruits.MaxFruits, null, null, aquizition);
        }

        private static void AddMultiModConsumable(ModItem modItem, Func<int> fruitsConsumed, Func<int> maxFruits, string difficulty, Func<bool> availability = null, LocalizedText aquizition = null)
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
                aquizition // Acquisition text of type LocalizedText, or null if not necessary
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