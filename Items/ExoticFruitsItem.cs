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

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault($"Increases maximum life by {LifePerFruit}\nIncreases maximum mana by {ManaPerFruit}\nOnly one can be consumed.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.LifeFruit);
		}

		public void UseItemHelp(Player player)
		{
			player.statLifeMax2 += LifePerFruit;
			player.statLife += LifePerFruit;
			player.statManaMax2 += ManaPerFruit;
			player.statMana += ManaPerFruit;
			if (Main.myPlayer == player.whoAmI)
			{
				player.HealEffect(LifePerFruit);
			}
		}
	}
}