using ExoticFruits.Configs;
using Terraria.ModLoader;

namespace ExoticFruits
{
	public class ExoticFruits : Mod
	{
        internal static int MaxFruits = ModContent.GetInstance<Config>().maxFruits;
        internal static int LifePerFruit = ModContent.GetInstance<Config>().lifePerFruit;
        internal static int ManaPerFruit = ModContent.GetInstance<Config>().manaPerFruit;
        internal static int LifeRequired = ModContent.GetInstance<Config>().lifeRequired;
        internal static int ManaRequired = ModContent.GetInstance<Config>().manaRequired;
        internal static bool enableFruitRecipes = ModContent.GetInstance<Config>().enableFruitRecipes;
        internal static bool enableCrystalRecipes = ModContent.GetInstance<Config>().enableCrystalRecipes;
        internal static bool enableFruitShards = ModContent.GetInstance<Config>().enableFruitShards;
        internal static int DefaultAmount = 10;
        internal static int BigFruitValue = 5 * LifePerFruit;
        internal static int PotionDefenseValue = ModContent.GetInstance<Config>().potionDefenseValue;
        internal static int PotionDefenseDuration = ModContent.GetInstance<Config>().potionDefenseDuration;
    }
}