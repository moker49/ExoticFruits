using ExoticFruits.Configs;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;

namespace ExoticFruits
{
    public class ExoticFruits : Mod
    {
        public enum FruitType
        {
            VANILLA,
            BIG,
            CALAMITY,
            CATALYST
        }
        internal static ExoticFruits instance;
        internal static int MaxFruits = ModContent.GetInstance<Config>().maxFruits;
        internal static int LifePerFruit = ModContent.GetInstance<Config>().lifePerFruit;
        internal static int ManaPerFruit = ModContent.GetInstance<Config>().manaPerFruit;
        internal static int LifeRequired = ModContent.GetInstance<Config>().lifeRequired;
        internal static int ManaRequired = ModContent.GetInstance<Config>().manaRequired;
        internal static bool enableFruitRecipes = ModContent.GetInstance<Config>().enableFruitRecipes;
        internal static bool enableCrystalRecipes = ModContent.GetInstance<Config>().enableCrystalRecipes;
        internal static bool enableFruitShards = ModContent.GetInstance<Config>().enableFruitShards;
        internal static int DefaultAmount = 10;
        internal static int BigFruitLifeValue = ModContent.GetInstance<Config>().bigFruitLifeMult * LifePerFruit;
        internal static int BigFruitManaValue = ModContent.GetInstance<Config>().bigFruitManaMult * ManaPerFruit;
        internal static int PotionDefenseValue = ModContent.GetInstance<Config>().potionDefenseValue;
        internal static int PotionDefenseDuration = ModContent.GetInstance<Config>().potionDefenseDuration;

        internal static Color softCyan = new Color(100, 200, 230);

        internal static Mod CalamityMod;
        internal static Mod CatalystMod;
        internal static Mod MunchiesMod;

        public override void Load()
        {
            instance = this;
        }

        public override void Unload()
        {
            instance = null;
        }
        public override void PostSetupContent()
        {
            AddMunchiesSupport();
        }

        private void AddMunchiesSupport()
        {
            if (ModLoader.TryGetMod("Munchies", out Mod munchiesMod))
            {
                MunchiesMod = munchiesMod;
                MunchiesModSupport.AddExoticConsumables();
            }

            if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod))
            {
                CalamityMod = calamityMod;
                if (MunchiesMod != null) MunchiesModSupport.AddCalamityConsumables();
            }

            if (ModLoader.TryGetMod("CatalystMod", out Mod catalystMod))
            {
                CatalystMod = catalystMod;
                if (MunchiesMod != null) MunchiesModSupport.AddCatalystConsumables();
            }
        }
    }
}