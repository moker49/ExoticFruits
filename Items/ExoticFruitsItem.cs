using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using ExoticFruits.Configs;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsItem : ModItem
	{
        internal static int MaxFruits = ModContent.GetInstance<ExoticFruitsConfig>().maxFruits;
        internal static int LifePerFruit = ModContent.GetInstance<ExoticFruitsConfig>().lifePerFruit;
		internal static int ManaPerFruit = ModContent.GetInstance<ExoticFruitsConfig>().manaPerFruit;
		internal static int LifeRequired = ModContent.GetInstance<ExoticFruitsConfig>().lifeRequired;
		internal static int ManaRequired = ModContent.GetInstance<ExoticFruitsConfig>().manaRequired;
		internal static bool enableFruitRecipes = ModContent.GetInstance<ExoticFruitsConfig>().enableFruitRecipes;
		internal static bool enableCrystalRecipes = ModContent.GetInstance<ExoticFruitsConfig>().enableCrystalRecipes;

		internal void SetStaticDefaultsBase(string displayName)
		{
			DisplayName.SetDefault(displayName);
			Tooltip.SetDefault($"Increases maximum life by {LifePerFruit}\nIncreases maximum mana by {ManaPerFruit}\nOnly one can be consumed.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.LifeFruit);
		}

		internal bool CanUseItemBase(Player player, int fruitIndex)
        {
			return player.statLifeMax >= LifeRequired && player.statManaMax >= ManaRequired && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[fruitIndex] < MaxFruits;
		}
		internal bool UseItemBase(Player player, int fruitIndex)
		{
			player.statLifeMax2 += LifePerFruit;
			player.statLife += LifePerFruit;
			player.statManaMax2 += ManaPerFruit;
			player.statMana += ManaPerFruit;
			if (Main.myPlayer == player.whoAmI)
			{
				player.HealEffect(LifePerFruit);
			}
			player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[fruitIndex]++;
			return true;
		}
	}
}