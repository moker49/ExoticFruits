using ExoticFruits.Configs;
using Terraria.ModLoader;

namespace ExoticFruits
{
	public class ExoticFruits : Mod
	{
        internal static int MaxFruits = ModContent.GetInstance<ExoticFruitsConfig>().maxFruits;
        internal static int LifePerFruit = ModContent.GetInstance<ExoticFruitsConfig>().lifePerFruit;
        internal static int ManaPerFruit = ModContent.GetInstance<ExoticFruitsConfig>().manaPerFruit;
        internal static int LifeRequired = ModContent.GetInstance<ExoticFruitsConfig>().lifeRequired;
        internal static int ManaRequired = ModContent.GetInstance<ExoticFruitsConfig>().manaRequired;
        internal static bool enableFruitRecipes = ModContent.GetInstance<ExoticFruitsConfig>().enableFruitRecipes;
        internal static bool enableCrystalRecipes = ModContent.GetInstance<ExoticFruitsConfig>().enableCrystalRecipes;
        internal static bool enableFruitShards = ModContent.GetInstance<ExoticFruitsConfig>().enableFruitShards;
        internal static int DefaultAmount = 10;
        internal static int BigFruitValue = 5 * LifePerFruit;
    }
}