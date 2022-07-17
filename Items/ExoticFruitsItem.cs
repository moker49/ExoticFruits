using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ExoticFruits.Items
{
	internal class ExoticFruitsItem : ModItem
	{
		public const int MaxFruits = 1;
		public const int LifePerFruit = 10;
		public const int ManaPerFruit = 10;

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
			return player.statLifeMax >= 400 && player.GetModPlayer<ExoticFruitsPlayer>().exoticFruits[fruitIndex] < MaxFruits;
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